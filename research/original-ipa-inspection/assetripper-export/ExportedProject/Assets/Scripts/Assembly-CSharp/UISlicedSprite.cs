using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Sliced)")]
public class UISlicedSprite : UISprite
{
	[SerializeField]
	[HideInInspector]
	private bool mFillCenter;

	protected Rect mInner;

	protected Rect mInnerUV;

	protected Vector3 mScale;

	public Rect innerUV
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool fillCenter
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override Vector4 border
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Vector2 pivotOffset
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override void UpdateUVs(bool force)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
