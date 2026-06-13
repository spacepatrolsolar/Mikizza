from __future__ import annotations

import argparse
import csv
import re
import shutil
from collections import Counter
from pathlib import Path
from typing import Iterable

import UnityPy


DEFAULT_APP_ROOT = Path("Payload/domino.app")
DEFAULT_OUT = Path("research/original-ipa-inspection/unitypy-export")


def asset_files(data: Path) -> list[Path]:
    files = [
        data / "mainData",
        data / "resources.assets",
        data / "unity default resources",
    ]
    files.extend(sorted(data.glob("sharedassets*.assets")))
    files.extend(sorted(data.glob("level*")))
    return [path for path in files if path.is_file()]


def safe_name(value: str | None, fallback: str) -> str:
    name = value or fallback
    name = re.sub(r"[^A-Za-z0-9._ -]+", "_", name).strip()
    name = re.sub(r"\s+", "_", name)
    return name[:120] or fallback


def unique_path(path: Path) -> Path:
    if not path.exists():
        return path
    stem = path.stem
    suffix = path.suffix
    parent = path.parent
    index = 2
    while True:
        candidate = parent / f"{stem}-{index}{suffix}"
        if not candidate.exists():
            return candidate
        index += 1


def write_csv(path: Path, rows: Iterable[dict[str, object]], fieldnames: list[str]) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    with path.open("w", newline="", encoding="utf-8") as handle:
        writer = csv.DictWriter(handle, fieldnames=fieldnames)
        writer.writeheader()
        for row in rows:
            writer.writerow(row)


def copy_loose_assets(root: Path, out: Path) -> list[dict[str, object]]:
    loose_extensions = {
        ".png",
        ".jpg",
        ".jpeg",
        ".gif",
        ".mp3",
        ".aif",
        ".aiff",
        ".mp4",
        ".dat",
        ".xml",
        ".plist",
        ".db",
        ".strings",
        ".nib",
    }
    copied: list[dict[str, object]] = []
    for source in sorted(root.rglob("*")):
        if not source.is_file():
            continue
        if source.suffix.lower() not in loose_extensions:
            continue
        rel = source.relative_to(root)
        dest = out / "loose" / rel
        dest.parent.mkdir(parents=True, exist_ok=True)
        shutil.copy2(source, dest)
        copied.append(
            {
                "source": str(rel),
                "kind": source.suffix.lower().lstrip(".") or "no_extension",
                "bytes": source.stat().st_size,
                "output": str(dest.relative_to(out)),
            }
        )
    return copied


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Extract readable Unity 4-era assets from the original Mikizza app bundle."
    )
    parser.add_argument(
        "--app-root",
        type=Path,
        default=DEFAULT_APP_ROOT,
        help="Path to the unpacked Payload/domino.app bundle.",
    )
    parser.add_argument(
        "--output",
        type=Path,
        default=DEFAULT_OUT,
        help="Directory where extracted assets and CSV reports should be written.",
    )
    return parser.parse_args()


def main() -> None:
    args = parse_args()
    root = args.app_root
    data_root = root / "Data"
    out = args.output

    if not root.is_dir():
        raise SystemExit(f"App bundle not found: {root}")
    if not data_root.is_dir():
        raise SystemExit(f"Unity Data directory not found: {data_root}")

    out.mkdir(parents=True, exist_ok=True)
    object_rows: list[dict[str, object]] = []
    export_rows: list[dict[str, object]] = []
    failure_rows: list[dict[str, object]] = []
    totals: Counter[str] = Counter()

    for source in asset_files(data_root):
        try:
            env = UnityPy.load(str(source))
        except Exception as exc:  # noqa: BLE001 - exporter report wants concrete failures.
            failure_rows.append(
                {
                    "source": source.name,
                    "path_id": "",
                    "type": "LOAD",
                    "name": "",
                    "error": f"{type(exc).__name__}: {exc}",
                }
            )
            continue

        for obj in env.objects:
            type_name = obj.type.name
            totals[type_name] += 1
            name = ""
            object_rows.append(
                {
                    "source": source.name,
                    "path_id": obj.path_id,
                    "type": type_name,
                    "name": name,
                }
            )

            if type_name not in {"Texture2D", "Sprite", "Mesh", "TextAsset", "Shader", "AudioClip"}:
                continue

            try:
                data = obj.read()
                name = getattr(data, "m_Name", None) or getattr(data, "name", None) or ""
                object_rows[-1]["name"] = name
            except Exception as exc:  # noqa: BLE001
                failure_rows.append(
                    {
                        "source": source.name,
                        "path_id": obj.path_id,
                        "type": type_name,
                        "name": name,
                        "error": f"read {type(exc).__name__}: {exc}",
                    }
                )
                continue

            fallback = f"{source.name}_{type_name}_{obj.path_id}"
            stem = safe_name(name, fallback)

            try:
                if type_name == "Texture2D":
                    image = data.image
                    dest = unique_path(out / "textures" / f"{stem}.png")
                    dest.parent.mkdir(parents=True, exist_ok=True)
                    image.save(dest)
                    export_rows.append(
                        {
                            "source": source.name,
                            "path_id": obj.path_id,
                            "type": type_name,
                            "name": name,
                            "output": str(dest.relative_to(out)),
                        }
                    )
                elif type_name == "Sprite":
                    image = data.image
                    dest = unique_path(out / "sprites" / f"{stem}.png")
                    dest.parent.mkdir(parents=True, exist_ok=True)
                    image.save(dest)
                    export_rows.append(
                        {
                            "source": source.name,
                            "path_id": obj.path_id,
                            "type": type_name,
                            "name": name,
                            "output": str(dest.relative_to(out)),
                        }
                    )
                elif type_name == "Mesh":
                    dest = unique_path(out / "meshes" / f"{stem}.obj")
                    dest.parent.mkdir(parents=True, exist_ok=True)
                    dest.write_text(data.export(), encoding="utf-8")
                    export_rows.append(
                        {
                            "source": source.name,
                            "path_id": obj.path_id,
                            "type": type_name,
                            "name": name,
                            "output": str(dest.relative_to(out)),
                        }
                    )
                elif type_name == "TextAsset":
                    script = getattr(data, "m_Script", b"")
                    if isinstance(script, str):
                        payload = script.encode("utf-8", errors="replace")
                    else:
                        payload = bytes(script)
                    dest = unique_path(out / "text-assets" / f"{stem}.bytes")
                    dest.parent.mkdir(parents=True, exist_ok=True)
                    dest.write_bytes(payload)
                    export_rows.append(
                        {
                            "source": source.name,
                            "path_id": obj.path_id,
                            "type": type_name,
                            "name": name,
                            "output": str(dest.relative_to(out)),
                        }
                    )
                elif type_name == "Shader":
                    dest = unique_path(out / "shaders" / f"{stem}.shader.txt")
                    dest.parent.mkdir(parents=True, exist_ok=True)
                    shader_source = getattr(data, "m_Script", None)
                    if shader_source:
                        dest.write_text(str(shader_source), encoding="utf-8", errors="replace")
                    else:
                        exported = data.export()
                        if isinstance(exported, bytes):
                            dest.write_bytes(exported)
                        else:
                            dest.write_text(str(exported), encoding="utf-8", errors="replace")
                    export_rows.append(
                        {
                            "source": source.name,
                            "path_id": obj.path_id,
                            "type": type_name,
                            "name": name,
                            "output": str(dest.relative_to(out)),
                        }
                    )
                elif type_name == "AudioClip":
                    samples = data.samples
                    if not samples:
                        raise ValueError("AudioClip exposed no embedded samples")
                    for sample_name, sample_bytes in samples.items():
                        sample_stem = safe_name(sample_name, stem)
                        dest = unique_path(out / "audio" / sample_stem)
                        dest.parent.mkdir(parents=True, exist_ok=True)
                        dest.write_bytes(sample_bytes)
                        export_rows.append(
                            {
                                "source": source.name,
                                "path_id": obj.path_id,
                                "type": type_name,
                                "name": name,
                                "output": str(dest.relative_to(out)),
                            }
                        )
            except Exception as exc:  # noqa: BLE001
                failure_rows.append(
                    {
                        "source": source.name,
                        "path_id": obj.path_id,
                        "type": type_name,
                        "name": name,
                        "error": f"export {type(exc).__name__}: {exc}",
                    }
                )

    loose_rows = copy_loose_assets(root, out)

    write_csv(
        out / "object-inventory.csv",
        object_rows,
        ["source", "path_id", "type", "name"],
    )
    write_csv(
        out / "exports.csv",
        export_rows,
        ["source", "path_id", "type", "name", "output"],
    )
    write_csv(
        out / "failures.csv",
        failure_rows,
        ["source", "path_id", "type", "name", "error"],
    )
    write_csv(
        out / "loose-assets.csv",
        loose_rows,
        ["source", "kind", "bytes", "output"],
    )

    with (out / "summary.txt").open("w", encoding="utf-8") as handle:
        handle.write("Unity object type counts\n")
        for type_name, count in totals.most_common():
            handle.write(f"{type_name}: {count}\n")
        handle.write(f"\nExported Unity objects: {len(export_rows)}\n")
        handle.write(f"Copied loose assets: {len(loose_rows)}\n")
        handle.write(f"Failures: {len(failure_rows)}\n")

    print(f"Exported Unity objects: {len(export_rows)}")
    print(f"Copied loose assets: {len(loose_rows)}")
    print(f"Failures: {len(failure_rows)}")
    print(f"Output: {out}")


if __name__ == "__main__":
    main()
