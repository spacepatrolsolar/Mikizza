using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button")]
public class UIButton : UIButtonColor
{
	public Color disabledColor;

	public bool isEnabled
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected override void OnEnable()
	{
	}

	protected override void OnHover(bool isOver)
	{
	}

	protected override void OnPress(bool isPressed)
	{
	}

	public void UpdateColor(bool shouldBeEnabled, bool immediate)
	{
	}
}
