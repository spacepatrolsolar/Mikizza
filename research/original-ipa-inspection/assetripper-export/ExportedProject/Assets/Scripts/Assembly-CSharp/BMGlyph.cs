using System;
using System.Collections.Generic;

[Serializable]
public class BMGlyph
{
	public struct Kerning
	{
		public int previousChar;

		public int amount;
	}

	public int index;

	public int x;

	public int y;

	public int width;

	public int height;

	public int offsetX;

	public int offsetY;

	public int advance;

	public int channel;

	public List<Kerning> kerning;

	public int GetKerning(int previousChar)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void SetKerning(int previousChar, int amount)
	{
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}
}
