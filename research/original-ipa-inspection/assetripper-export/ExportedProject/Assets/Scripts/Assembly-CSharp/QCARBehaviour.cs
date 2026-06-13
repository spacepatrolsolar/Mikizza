using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class QCARBehaviour : MonoBehaviour
{
	public enum WorldCenterMode
	{
		USER = 0,
		AUTO = 1,
		NONE = 2
	}

	private enum CameraState
	{
		UNINITED = 0,
		DEVICE_INITED = 1,
		RENDERING_INITED = 2
	}

	[SerializeField]
	protected CameraDevice.CameraDeviceMode CameraDeviceModeSetting;

	[SerializeField]
	private int MaxSimultaneousImageTargets;

	[SerializeField]
	private bool SynchronousVideo;

	[SerializeField]
	[HideInInspector]
	protected WorldCenterMode mWorldCenterMode;

	[HideInInspector]
	[SerializeField]
	private TrackableBehaviour mWorldCenter;

	[SerializeField]
	protected CameraDevice.CameraDirection CameraDirection;

	[SerializeField]
	private QCARRenderer.VideoBackgroundReflection MirrorVideoBackground;

	private List<ITrackerEventHandler> mTrackerEventHandlers;

	private List<IVideoBackgroundEventHandler> mVideoBgEventHandlers;

	private bool mIsInitialized;

	private CameraState mCameraState;

	private Material mClearMaterial;

	private Rect mViewportRect;

	private int mClearBuffers;

	private bool mHasStartedOnce;

	private ScreenOrientation mProjectionOrientation;

	private bool mCachedDrawVideoBackground;

	private CameraClearFlags mCachedCameraClearFlags;

	private Color mCachedCameraBackgroundColor;

	public WorldCenterMode WorldCenterModeSetting
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public TrackableBehaviour WorldCenter
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool VideoBackGroundMirrored
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

	public void RegisterTrackerEventHandler(ITrackerEventHandler trackerEventHandler)
	{
	}

	public bool UnregisterTrackerEventHandler(ITrackerEventHandler trackerEventHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void RegisterVideoBgEventHandler(IVideoBackgroundEventHandler videoBgEventHandler)
	{
	}

	public bool UnregisterVideoBgEventHandler(IVideoBackgroundEventHandler videoBgEventHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void SetWorldCenterMode(WorldCenterMode value)
	{
	}

	public void SetWorldCenter(TrackableBehaviour value)
	{
	}

	public Rect GetViewportRectangle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public ScreenOrientation GetSurfaceOrientation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ConfigureVideoBackground(bool forceReflectionSetting)
	{
	}

	public void ResetClearBuffers()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnPreRender()
	{
	}

	private void OnPostRender()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void StartQCAR()
	{
	}

	protected virtual void StopQCAR()
	{
	}

	private void ResetCameraClearFlags()
	{
	}

	private void UpdateCameraClearFlags()
	{
	}

	protected void UpdateProjection(ScreenOrientation orientation)
	{
	}
}
