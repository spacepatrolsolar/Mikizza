using AnimationOrTween;
using UnityEngine;

public abstract class UITweener : IgnoreTimeScale
{
	public enum Method
	{
		Linear = 0,
		EaseIn = 1,
		EaseOut = 2,
		EaseInOut = 3,
		BounceIn = 4,
		BounceOut = 5
	}

	public enum Style
	{
		Once = 0,
		Loop = 1,
		PingPong = 2
	}

	public delegate void OnFinished(UITweener tween);

	public OnFinished onFinished;

	public Method method;

	public Style style;

	public bool ignoreTimeScale;

	public float delay;

	public float duration;

	public bool steeperCurves;

	public int tweenGroup;

	public GameObject eventReceiver;

	public string callWhenFinished;

	private float mStartTime;

	private float mDuration;

	private float mAmountPerDelta;

	private float mFactor;

	public float amountPerDelta
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float tweenFactor
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Direction direction
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	protected override void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Sample(float factor, bool isFinished)
	{
	}

	private float BounceLogic(float val)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Play(bool forward)
	{
	}

	public void Reset()
	{
	}

	public void Toggle()
	{
	}

	protected abstract void OnUpdate(float factor, bool isFinished);

	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
