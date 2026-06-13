using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Filled)")]
public class UIFilledSprite : UISprite
{
	public enum FillDirection
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4
	}

	[HideInInspector]
	[SerializeField]
	private FillDirection mFillDirection;

	[HideInInspector]
	[SerializeField]
	private float mFillAmount;

	[SerializeField]
	[HideInInspector]
	private bool mInvert;

	public FillDirection fillDirection
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public float fillAmount
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool invert
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private bool AdjustRadial(Vector2[] xy, Vector2[] uv, float fill, bool invert)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Rotate(Vector2[] v, int offset)
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
