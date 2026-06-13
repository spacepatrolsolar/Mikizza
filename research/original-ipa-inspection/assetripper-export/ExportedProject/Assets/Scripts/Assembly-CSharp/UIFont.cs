using System.Collections.Generic;
using System.Text;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Font")]
[ExecuteInEditMode]
public class UIFont : MonoBehaviour
{
	public enum Alignment
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	public enum SymbolStyle
	{
		None = 0,
		Uncolored = 1,
		Colored = 2
	}

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[SerializeField]
	[HideInInspector]
	private Rect mUVRect;

	[SerializeField]
	[HideInInspector]
	private BMFont mFont;

	[SerializeField]
	[HideInInspector]
	private int mSpacingX;

	[SerializeField]
	[HideInInspector]
	private int mSpacingY;

	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	private UIFont mReplacement;

	private UIAtlas.Sprite mSprite;

	private bool mSpriteSet;

	private List<Color> mColors;

	public BMFont bmFont
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int texWidth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int texHeight
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public UIAtlas atlas
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Material material
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Texture2D texture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Rect uvRect
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
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

	public int horizontalSpacing
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int verticalSpacing
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int size
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public UIAtlas.Sprite sprite
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public UIFont replacement
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Trim()
	{
	}

	private bool References(UIFont font)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void MarkAsDirty()
	{
	}

	public Vector2 CalculatePrintedSize(string text, bool encoding, SymbolStyle symbolStyle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static void EndLine(ref StringBuilder s)
	{
	}

	public string GetEndOfLineThatFits(string text, float maxWidth, bool encoding, SymbolStyle symbolStyle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public string WrapText(string text, float maxWidth, int maxLineCount, bool encoding, SymbolStyle symbolStyle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public string WrapText(string text, float maxWidth, int maxLineCount, bool encoding)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public string WrapText(string text, float maxWidth, int maxLineCount)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Align(BetterList<Vector3> verts, int indexOffset, Alignment alignment, int x, int lineWidth)
	{
	}

	public void Print(string text, Color32 color, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, bool encoding, SymbolStyle symbolStyle, Alignment alignment, int lineWidth)
	{
	}
}
