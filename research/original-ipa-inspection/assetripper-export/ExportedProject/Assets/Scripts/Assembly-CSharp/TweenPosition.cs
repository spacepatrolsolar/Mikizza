using UnityEngine;

[AddComponentMenu("NGUI/Tween/Position")]
public class TweenPosition : UITweener
{
	public Vector3 from;

	public Vector3 to;

	private Transform mTrans;

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector3 position
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
