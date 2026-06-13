using System.Runtime.CompilerServices;
using UnityEngine;

public class QCARRendererImpl : QCARRenderer
{
	private VideoBGCfgData mVideoBGConfig;

	private bool mVideoBGConfigSet;

	public override bool DrawVideoBackground
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Texture2D VideoBackgroundForEmulator
	{
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override VideoBGCfgData GetVideoBackgroundConfig()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void ClearVideoBackgroundConfig()
	{
	}

	public override void SetVideoBackgroundConfig(VideoBGCfgData config)
	{
	}

	public override bool SetVideoBackgroundTexture(Texture2D texture)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool IsVideoBackgroundInfoAvailable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override VideoTextureInfo GetVideoTextureInfo()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
