using UnityEngine;

[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInputSysfontName : UIInputSysfont
{
	public enum LabelType
	{
		Name = 0,
		TeamName = 1,
		TeamMessage = 2
	}

	[SerializeField]
	private LabelType _labelType;

	private void Awake()
	{
	}

	public override void UpdateLabel()
	{
	}

	public override void OnSelect(bool isSelected)
	{
	}

	private string CutText(string processed)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
