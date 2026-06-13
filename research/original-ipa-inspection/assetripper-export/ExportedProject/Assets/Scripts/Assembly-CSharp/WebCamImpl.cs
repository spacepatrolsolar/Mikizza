using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WebCamImpl
{
	private struct BufferedFrame
	{
		public int frameIndex;

		public RenderTexture frame;
	}

	private readonly Camera mARCamera;

	private readonly BGRenderingBehaviour mBgRenderingTexBehaviour;

	private readonly WebCamTexAdaptor mWebCamTexture;

	private CameraDevice.VideoModeData mVideoModeData;

	private QCARRenderer.VideoTextureInfo mVideoTextureInfo;

	private TextureRenderer mTextureRenderer;

	private Texture2D mBufferReadTexture;

	private Rect mReadPixelsRect;

	private readonly WebCamProfile.ProfileData mWebCamProfile;

	private readonly bool mFlipHorizontally;

	private int mLastScreenWidth;

	private int mLastScreenHeight;

	private readonly Queue<BufferedFrame> mBufferedFrames;

	private int mLastFrameIdx;

	private readonly int mRenderTextureLayer;

	public bool DidUpdateThisFrame
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsPlaying
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int ActualWidth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int ActualHeight
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsTextureSizeAvailable
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

	public bool FlipHorizontally
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public QCARRenderer.Vec2I ResampledTextureSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public WebCamImpl(Camera arCamera, Camera backgroundCamera, int renderTextureLayer, string webcamDeviceName, bool flipHorizontally)
	{
	}

	private void RenderFrame(RenderTexture frameToDraw)
	{
	}

	public void StartCamera()
	{
	}

	public void StopCamera()
	{
	}

	public Color32[] GetPixels32AndBufferFrame(int frameIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void SetFrameIndex(int frameIndex)
	{
	}

	public CameraDevice.VideoModeData GetVideoMode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public QCARRenderer.VideoTextureInfo GetVideoTextureInfo()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool IsRendererDirty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
