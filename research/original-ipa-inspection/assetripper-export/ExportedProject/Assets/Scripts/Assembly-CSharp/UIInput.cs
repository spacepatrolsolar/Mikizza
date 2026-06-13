using UnityEngine;

[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInput : MonoBehaviour
{
	public enum KeyboardType
	{
		Default = 0,
		ASCIICapable = 1,
		NumbersAndPunctuation = 2,
		URL = 3,
		NumberPad = 4,
		PhonePad = 5,
		NamePhonePad = 6,
		EmailAddress = 7
	}

	public delegate char Validator(string currentText, char nextChar);

	public delegate void OnSubmit(string inputString);

	public static UIInput current;

	public UILabel label;

	public int maxChars;

	public string caratChar;

	public Validator validator;

	public KeyboardType type;

	public bool isPassword;

	public Color activeColor;

	public GameObject eventReceiver;

	public string functionName;

	public OnSubmit onSubmit;

	private string mText;

	private string mDefaultText;

	private Color mDefaultColor;

	private UIWidget.Pivot mPivot;

	private float mPosition;

	private TouchScreenKeyboard mKeyboard;

	private bool mDoInit;

	public string text
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool selected
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	private void Update()
	{
	}

	private void OnInput(string input)
	{
	}

	private void UpdateLabel()
	{
	}

	private void RestoreLabel()
	{
	}
}
