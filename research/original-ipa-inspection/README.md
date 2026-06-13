# Dominos IPA Inspection

Source IPA:

- `dominos.ipa`, unpacked from a local working copy outside this repository.
- SHA-256: `3ced9b66e838f93fe125db319b941add6818c50b48528ee1dc6c1aaea80f4012`

App metadata:

- Display name: `Dominos Miku`
- Bundle id: `jp.dominos.dominosxmiku`
- App version: `1.15`
- Unity version: `4.1.5f1`
- Native executable: ARMv7 Mach-O at `Payload/domino.app/domino`

Tools used:

- AssetRipper `1.3.14` was downloaded and verified against the release SHA-256.
- AssetRipper headless startup works on macOS arm64 when boolean flags are passed as switches, for example `--headless --port 51999`. Passing `--headless true` fails because the CLI treats `true` as an extra argument.
- UnityPy `1.25.0` was used for the scriptable asset extraction fallback. Shader source was exported directly from each shader object's `m_Script` field because UnityPy's generic shader exporter fails on this Unity 4.1.5f1 asset shape.
- ILSpy `ilspycmd` `10.1.0.8386` was used for .NET/Mono decompilation.

What was exported:

- `unitypy-export/meshes`: 39 OBJ mesh files from Unity level files.
- `unitypy-export/textures`: 51 PNG textures from Unity asset files.
- `unitypy-export/shaders`: 96 Unity shader source files.
- `unitypy-export/text-assets`: 15 Unity text assets.
- `unitypy-export/loose`: 367 loose app resources copied from the bundle, including PNGs, audio, video, plists, strings, nibs, QCAR/Vuforia AR data, and the SQLite database.
- `assetripper-export`: AssetRipper Unity project export from the same app bundle, including reconstructed Unity scenes, prefabs, materials, meshes, shaders, scripts, project settings, and auxiliary game assemblies.
- `decompiled-csharp`: decompiled `Assembly-CSharp.dll`.
- `decompiled-firstpass`: decompiled `Assembly-CSharp-firstpass.dll`.
- `decompiled-unityscript`: decompiled `Assembly-UnityScript.dll`.

What did not export cleanly:

- 9 built-in/default Unity mesh objects failed to read from `unity default resources`.
- 1 font texture had no image payload.
- 1 embedded Unity `AudioClip` named `kasha` exposed no samples through UnityPy. The app also ships loose audio files separately, and those were copied under `unitypy-export/loose`.

Useful report files:

- `unitypy-export/summary.txt`: Unity object type counts and totals.
- `unitypy-export/object-inventory.csv`: every Unity object seen by file, path id, type, and name when readable.
- `unitypy-export/exports.csv`: every exported Unity object and output path.
- `unitypy-export/failures.csv`: read/export failures and their exact error text.
- `unitypy-export/loose-assets.csv`: loose bundle resources copied into the output.
- `assetripper-export/ExportedProject/Assets/_PROJECT/Scenes`: named Unity scene exports such as `Release/Ar/Ar.unity`, `Release/Ar2/Ar2.unity`, and `Release/Portrait/Portrait.unity`.
- `source/dominos.ipa`: local source IPA copy matching the SHA-256 above.

Next pass:

- Use the AssetRipper export to map scene names, prefabs, scripts, and assets back to the revival-critical AR and portrait flows. See `tooling-next-pass.md` for the follow-up extraction plan, including Rosetta/x64 considerations, alternative Unity asset tools, and manual extraction options.
