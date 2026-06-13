using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Color")]
public class UIButtonColor : MonoBehaviour
{
	public GameObject tweenTarget;

	public Color hover;

	public Color pressed;

	public float duration;

	protected Color mColor;

	protected bool mInitDone;

	protected bool mStarted;

	protected bool mHighlighted;

	public Color defaultColor
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

	private void Start()
	{
	}

	protected virtual void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected void Init()
	{
	}

	protected virtual void OnPress(bool isPressed)
	{
	}

	protected virtual void OnHover(bool isOver)
	{
	}
}
