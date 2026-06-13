using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BMFont
{
	[HideInInspector]
	[SerializeField]
	private BMGlyph[] mGlyphs;

	[SerializeField]
	[HideInInspector]
	private int mSize;

	[SerializeField]
	[HideInInspector]
	private int mBase;

	[HideInInspector]
	[SerializeField]
	private int mWidth;

	[SerializeField]
	[HideInInspector]
	private int mHeight;

	[SerializeField]
	[HideInInspector]
	private string mSpriteName;

	[SerializeField]
	[HideInInspector]
	private List<BMGlyph> mSaved;

	[HideInInspector]
	[SerializeField]
	private List<BMSymbol> mSymbols;

	private Dictionary<int, BMGlyph> mDict;

	public bool isValid
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int charSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int baseOffset
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int texWidth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int texHeight
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int glyphCount
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string spriteName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public List<BMSymbol> symbols
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool LegacyCheck()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private int GetArraySize(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public BMGlyph GetGlyph(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Clear()
	{
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}
}
