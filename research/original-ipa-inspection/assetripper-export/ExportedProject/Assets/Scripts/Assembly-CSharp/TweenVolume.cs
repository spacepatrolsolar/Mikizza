using UnityEngine;

[AddComponentMenu("NGUI/Tween/Volume")]
public class TweenVolume : UITweener
{
	public float from;

	public float to;

	private AudioSource mSource;

	public AudioSource audioSource
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float volume
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

	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
