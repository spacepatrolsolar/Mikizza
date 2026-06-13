using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Checkbox")]
public class UICheckbox : MonoBehaviour
{
	public delegate void OnStateChange(bool state);

	public static UICheckbox current;

	public UISprite checkSprite;

	public Animation checkAnimation;

	public bool startsChecked;

	public Transform radioButtonRoot;

	public bool optionCanBeNone;

	public GameObject eventReceiver;

	public string functionName;

	public OnStateChange onStateChange;

	[SerializeField]
	[HideInInspector]
	private bool option;

	private bool mChecked;

	private bool mStarted;

	private Transform mTrans;

	public bool isChecked
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

	private void OnClick()
	{
	}

	private void Set(bool state)
	{
	}
}
