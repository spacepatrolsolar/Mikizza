using UnityEngine;

public class WebCamTexAdaptorImpl : WebCamTexAdaptor
{
	private WebCamTexture mWebCamTexture;

	public override bool DidUpdateThisFrame
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool IsPlaying
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Texture Texture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public WebCamTexAdaptorImpl(string deviceName, int requestedFPS, QCARRenderer.Vec2I requestedTextureSize)
	{
	}

	public override void Play()
	{
	}

	public override void Stop()
	{
	}
}
