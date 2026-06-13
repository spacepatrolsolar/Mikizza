using UnityEngine;

[AddComponentMenu("NGUI/UI/Label")]
[ExecuteInEditMode]
public class UILabel : UIWidget
{
	public enum Effect
	{
		None = 0,
		Shadow = 1,
		Outline = 2
	}

	[HideInInspector]
	[SerializeField]
	private UIFont mFont;

	[SerializeField]
	[HideInInspector]
	private string mText;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineWidth;

	[SerializeField]
	[HideInInspector]
	private bool mEncoding;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineCount;

	[SerializeField]
	[HideInInspector]
	private bool mPassword;

	[HideInInspector]
	[SerializeField]
	private bool mShowLastChar;

	[SerializeField]
	[HideInInspector]
	private Effect mEffectStyle;

	[SerializeField]
	[HideInInspector]
	private Color mEffectColor;

	[SerializeField]
	[HideInInspector]
	private UIFont.SymbolStyle mSymbols;

	[SerializeField]
	[HideInInspector]
	private Vector2 mEffectDistance;

	[SerializeField]
	[HideInInspector]
	private float mLineWidth;

	[SerializeField]
	[HideInInspector]
	private bool mMultiline;

	private bool mShouldBeProcessed;

	private string mProcessedText;

	private Vector3 mLastScale;

	private string mLastText;

	private int mLastWidth;

	private bool mLastEncoding;

	private int mLastCount;

	private bool mLastPass;

	private bool mLastShow;

	private Effect mLastEffect;

	private Vector3 mSize;

	private bool hasChanged
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UIFont font
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

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

	public bool supportEncoding
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UIFont.SymbolStyle symbolStyle
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int lineWidth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool multiLine
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int maxLineCount
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool password
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool showLastPasswordChar
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Effect effectStyle
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Color effectColor
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Vector2 effectDistance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string processedText
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Material material
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Vector2 relativeSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	protected override void OnStart()
	{
	}

	public override void MarkAsChanged()
	{
	}

	private void ProcessText()
	{
	}

	public void MakePositionPerfect()
	{
	}

	public override void MakePixelPerfect()
	{
	}

	private void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
