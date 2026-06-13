using System.Runtime.InteropServices;
using UnityEngine;

public abstract class QCARRenderer
{
	public enum VideoBackgroundReflection
	{
		DEFAULT = 0,
		ON = 1,
		OFF = 2
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct VideoBGCfgData
	{
		public int enabled;

		public int synchronous;

		public Vec2I position;

		public Vec2I size;

		[MarshalAs((UnmanagedType)31)]
		public VideoBackgroundReflection reflection;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct Vec2I
	{
		public int x;

		public int y;

		public Vec2I(int v1, int v2)
		{
		}
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct VideoTextureInfo
	{
		public Vec2I textureSize;

		public Vec2I imageSize;
	}

	private static QCARRenderer sInstance;

	public static QCARRenderer Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public abstract bool DrawVideoBackground { get; set; }

	public abstract VideoBGCfgData GetVideoBackgroundConfig();

	public abstract void ClearVideoBackgroundConfig();

	public abstract void SetVideoBackgroundConfig(VideoBGCfgData config);

	public abstract bool SetVideoBackgroundTexture(Texture2D texture);

	public abstract bool IsVideoBackgroundInfoAvailable();

	public abstract VideoTextureInfo GetVideoTextureInfo();
}
