# Unity Extraction Tooling Next Pass

This note keeps the next extraction experiments portable. Do not commit downloaded extractor binaries, unpacked IPAs, local app bundles, or outputs that contain machine-local paths.

## Current baseline

- Source IPA SHA-256: `3ced9b66e838f93fe125db319b941add6818c50b48528ee1dc6c1aaea80f4012`
- App version: `1.15`
- Unity version: `4.1.5f1`
- UnityPy baseline: `tools/extract_unity_assets.py` exported 201 Unity objects and copied 367 loose bundle assets.
- AssetRipper baseline: macOS arm64 `1.3.14` exported a Unity-project-shaped tree to `assetripper-export`.
- Remaining UnityPy failures are low-value default resources plus one embedded `AudioClip` named `kasha`. The app also ships `kasha.mp3` as a loose resource.

## Tool candidates

| Tool | Best use here | macOS fit | Notes |
| --- | --- | --- | --- |
| [AssetRipper](https://github.com/AssetRipper/AssetRipper/releases) | Best chance at reconstructing Unity project structure, scenes, prefabs, materials, and script bindings beyond raw asset export. | Native mac arm64 and mac x64 release assets are available in current releases. | `1.3.14` has relevant Unity-pre-5.5 changes: 32-bit file IDs before Unity 5.5 and shader script display before Unity 5.5. macOS arm64 export succeeded when driven through the local web API. |
| [AssetStudio](https://github.com/Perfare/AssetStudio/releases) | Cross-check readable Unity assets and possibly recover asset names or previews that UnityPy misses. | No native macOS release; latest published builds are .NET/Windows-oriented. | Useful as a Windows or VM fallback. Older `UnityStudio` releases may be closer in age to Unity 4-era assets, but they are also Windows-era GUI tools. |
| [UABE](https://github.com/SeriousCache/UABE/releases) | Manual inspection/editing of serialized Unity assets and type trees. | Windows release binaries only. | Better as a Windows fallback than a first local macOS attempt. |
| [UABEA](https://github.com/nesrak1/UABEA/releases) | Manual asset database inspection with newer AssetsTools.NET behavior. | Current releases provide Windows and Linux builds, not macOS builds. | Possible VM/container fallback, but less direct than AssetRipper on this Mac. |
| UnityPy | Portable scripted extraction and reproducible CSV reports. | Already works locally through Python. | Keep as the repo-owned baseline and extend it when the next question needs structured inventories rather than GUI export. |

## Rosetta and x64 notes

Apple documents Rosetta as the compatibility path for Intel-based apps on Apple silicon Macs: <https://support.apple.com/en-us/102527>.

Local checks on this machine showed:

- Current shell architecture: `arm64`
- Rosetta package: installed
- .NET host: installed as `osx-arm64`
- `mono`: not found
- `wine`: not found

That means mac x64 AssetRipper can be tested through Rosetta, but Windows-only tools should not be treated as locally runnable without adding Wine, Mono, a Windows VM, or a separate Windows machine. Since the macOS arm64 AssetRipper export now succeeds, only test the x64 build if a specific arm64-export defect shows up.

## Recommended sequence

1. Use the committed AssetRipper export as the primary Unity reconstruction source.
   - Start with named scenes under `assetripper-export/ExportedProject/Assets/_PROJECT/Scenes`.
   - Map scenes to prefabs, scripts, materials, meshes, textures, and audio.
   - Treat the UnityPy export as the raw extraction cross-check.

2. Re-run AssetRipper locally only when the export needs to be regenerated.
   - Use `--headless --port <port>`, not `--headless true`.
   - POST the unpacked `Payload/domino.app` folder to `/LoadFolder` with form field `path`.
   - POST the output directory to `/Export/UnityProject` with form field `path`.

3. Try one older AssetRipper line only if the current line exposes a concrete defect.
   - Start with `1.2.1`, because its release notes call out embedded web dependencies.
   - If that fails the same way, try `1.1.13` or the last pre-Photino release line only as a GUI/runtime comparison.
   - Keep all downloads and unpacked binaries under a temporary path outside the repository.

4. If AssetRipper remains blocked, extend the UnityPy path instead of chasing GUI tools.
   - Add a structured object relationship report for `GameObject`, `Transform`, `MeshFilter`, `MeshRenderer`, `Material`, `MonoBehaviour`, `Camera`, and `Light`.
   - Add a scene-level CSV keyed by source file and path id.
   - Preserve exact UnityPy failures rather than hiding default-resource read errors.

5. Use Windows-oriented tools only for targeted questions.
   - Use AssetStudio to cross-check exportability or asset previews.
   - Use UABE/UABEA when manual type-tree inspection is needed.
   - Prefer a Windows VM or separate Windows environment over installing broad compatibility tooling into this repo workflow.

## Manual extraction fallback

If no GUI/project reconstructor works, the practical manual path is:

- Treat UnityPy as the authoritative raw extractor.
- Use the decompiled assemblies to identify important scene scripts and data files.
- Build small reports that map Unity path ids to names, component types, and referenced assets.
- Reconstruct only the revival-critical surfaces first: AR marker data, Miku/stage meshes, materials, textures, audio cues, server/API strings, and ordering UI resources.
