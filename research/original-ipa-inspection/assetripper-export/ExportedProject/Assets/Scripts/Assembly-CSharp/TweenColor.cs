using UnityEngine;

[AddComponentMenu("NGUI/Tween/Color")]
public class TweenColor : UITweener
{
	public Color from;

	public Color to;

	private Transform mTrans;

	private UIWidget mWidget;

	private Material mMat;

	private Light mLight;

	public Color color
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
