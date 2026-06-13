using System.Collections.Generic;
using UnityEngine;

public class CloudRecoBehaviour : MonoBehaviour, ITrackerEventHandler
{
	private ImageTracker mImageTracker;

	private bool mCurrentlyInitializing;

	private bool mInitSuccess;

	private bool mCloudRecoStarted;

	private bool mOnInitializedCalled;

	private readonly List<ICloudRecoEventHandler> mHandlers;

	public string AccessKey;

	public string SecretKey;

	public Color ScanlineColor;

	public Color FeaturePointColor;

	public bool CloudRecoEnabled
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool CloudRecoInitialized
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void Initialize()
	{
	}

	private void Deinitialize()
	{
	}

	private void CheckInitialization()
	{
	}

	private void StartCloudReco()
	{
	}

	private void StopCloudReco()
	{
	}

	public void RegisterEventHandler(ICloudRecoEventHandler eventHandler)
	{
	}

	public bool UnregisterEventHandler(ICloudRecoEventHandler eventHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnInitialized()
	{
	}

	public void OnTrackablesUpdated()
	{
	}
}
