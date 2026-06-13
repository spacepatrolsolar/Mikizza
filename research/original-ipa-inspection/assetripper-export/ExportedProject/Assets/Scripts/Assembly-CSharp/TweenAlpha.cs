using UnityEngine;

[AddComponentMenu("NGUI/Tween/Alpha")]
public class TweenAlpha : UITweener
{
	public float from;

	public float to;

	private Transform mTrans;

	private UIWidget mWidget;

	public float alpha
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

	public static TweenAlpha Begin(GameObject go, float duration, float alpha)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
