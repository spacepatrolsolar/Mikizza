using System;
using UnityEngine;

[Serializable]
public class SysFontTexture : ISysFontTexturable
{
	[SerializeField]
	protected string _text;

	[SerializeField]
	protected string _appleFontName;

	[SerializeField]
	protected string _androidFontName;

	[SerializeField]
	protected int _fontSize;

	[SerializeField]
	protected bool _isBold;

	[SerializeField]
	protected bool _isItalic;

	[SerializeField]
	protected SysFont.Alignment _alignment;

	[SerializeField]
	protected bool _isMultiLine;

	[SerializeField]
	protected int _maxWidthPixels;

	[SerializeField]
	protected int _maxHeightPixels;

	protected string _lastText;

	protected string _lastFontName;

	protected int _lastFontSize;

	protected bool _lastIsBold;

	protected bool _lastIsItalic;

	protected SysFont.Alignment _lastAlignment;

	protected bool _lastIsMultiLine;

	protected int _lastMaxWidthPixels;

	protected int _lastMaxHeightPixels;

	protected int _widthPixels;

	protected int _heightPixels;

	protected int _textWidthPixels;

	protected int _textHeightPixels;

	protected Texture _texture;

	public string Text
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string AppleFontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string AndroidFontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string FontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int FontSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsBold
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsItalic
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public SysFont.Alignment Alignment
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsMultiLine
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int MaxWidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int MaxHeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int WidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int HeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int TextWidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int TextHeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Texture Texture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool NeedsRedraw
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public void Update()
	{
	}

	public void Destroy()
	{
	}
}
