using UnityEngine;

[RequireComponent(typeof(Camera))]
public class WebCamBehaviour : MonoBehaviour
{
	public Camera BackgroundCameraPrefab;

	public int RenderTextureLayer;

	[HideInInspector]
	[SerializeField]
	private string mDeviceNameSetInEditor;

	[HideInInspector]
	[SerializeField]
	private bool mFlipHorizontally;

	[SerializeField]
	[HideInInspector]
	private bool mTurnOffWebCam;

	private WebCamImpl mWebCamImpl;

	private Camera mBackgroundCameraInstance;

	public string DeviceName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public WebCamImpl ImplementationClass
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool FlipHorizontally
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool TurnOffWebCam
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsPlaying
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public void InitCamera()
	{
	}

	public void StartCamera()
	{
	}

	public void StopCamera()
	{
	}

	public bool CheckNativePluginSupport()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool IsWebCamUsed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
