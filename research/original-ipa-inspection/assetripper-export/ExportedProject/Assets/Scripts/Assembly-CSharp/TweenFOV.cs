using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Tween/Field of View")]
public class TweenFOV : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float fov
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

	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
