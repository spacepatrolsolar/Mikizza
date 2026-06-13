# AssetRipper Export

This directory contains an AssetRipper `1.3.14` macOS arm64 Unity project export from `source/dominos.ipa`.

Source IPA SHA-256:

```text
3ced9b66e838f93fe125db319b941add6818c50b48528ee1dc6c1aaea80f4012
```

AssetRipper was run from a temporary directory outside the repository. The exported tree was copied here after the export completed.

## Contents

- `ExportedProject`: Unity-project-shaped export.
- `ExportedProject/Assets/_PROJECT/Scenes`: named recovered scenes, including AR, AR2, Common, and Portrait scene groups.
- `ExportedProject/Assets/GameObject`: recovered prefab exports.
- `ExportedProject/Assets/Scripts`: decompiled C# script export.
- `ExportedProject/Assets/Shader`: recovered shader files.
- `AuxiliaryFiles`: copied game assemblies and AssetRipper path id map.

## Counts

- Total files: 1334
- Unity scene files: 26
- Prefab files: 42
- Material files: 36
- Shader files: 120
- PNG texture files: 16
- MP3 audio files: 2
- C# files: 315

## Notes

- `ProjectVersion.txt` records Unity `4.1.5f1`.
- AssetRipper exported two `kasha` MP3 files under `ExportedProject/Assets/AudioClip`, while UnityPy reported no embedded samples for its `AudioClip` object and copied the loose `kasha.mp3`.
- Keep regenerated AssetRipper binaries and unpacked IPA working directories outside the repository.
