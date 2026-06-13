using System;
using UnityEngine;

public class NullWebCamTexAdaptor : WebCamTexAdaptor
{
	private const string ERROR_MSG = "No camera connected!\nTo run your application using Play Mode, please connect a webcam to your computer.";

	private readonly Texture2D mTexture;

	private bool mPseudoPlaying;

	private readonly double mMsBetweenFrames;

	private DateTime mLastFrame;

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

	public NullWebCamTexAdaptor(int requestedFPS, QCARRenderer.Vec2I requestedTextureSize)
	{
	}

	public override void Play()
	{
	}

	public override void Stop()
	{
	}
}
