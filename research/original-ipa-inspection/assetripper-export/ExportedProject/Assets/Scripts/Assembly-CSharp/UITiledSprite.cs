using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Tiled)")]
public class UITiledSprite : UISlicedSprite
{
	public override Vector4 border
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
