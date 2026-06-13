using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class QCARManagerImpl : QCARManager
{
	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct PoseData
	{
		[MarshalAs((UnmanagedType)30, SizeConst = 3)]
		public Vector3 position;

		[MarshalAs((UnmanagedType)30, SizeConst = 4)]
		public Quaternion orientation;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct TrackableResultData
	{
		public PoseData pose;

		public TrackableBehaviour.Status status;

		public int id;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct VirtualButtonData
	{
		public int id;

		public int isPressed;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	private struct ImageHeaderData
	{
		public int width;

		public int height;

		public int stride;

		public int bufferWidth;

		public int bufferHeight;

		public int format;

		public int reallocate;

		public int updated;

		public IntPtr data;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	private struct FrameState
	{
		public int numTrackableResults;

		public int numVirtualButtonResults;

		public int frameIndex;

		public IntPtr trackableDataArray;

		public IntPtr vbDataArray;
	}

	private QCARBehaviour.WorldCenterMode mWorldCenterMode;

	private TrackableBehaviour mWorldCenter;

	private Camera mARCamera;

	private TrackableResultData[] mTrackableResultDataArray;

	private LinkedList<int> mTrackableFoundQueue;

	private IntPtr mImageHeaderData;

	private int mNumImageHeaders;

	private bool mDrawVideobackground;

	private int mInjectedFrameIdx;

	private IntPtr mLastProcessedFrameStatePtr;

	private bool mInitialized;

	public override QCARBehaviour.WorldCenterMode WorldCenterMode
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override TrackableBehaviour WorldCenter
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override Camera ARCamera
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

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

	public override bool Initialized
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool Init()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Update(ScreenOrientation counterRotation)
	{
	}

	public override void Deinit()
	{
	}

	private void InitializeTrackableContainer(int numTrackableResults)
	{
	}

	private void UpdateTrackers(FrameState frameState)
	{
	}

	private void UpdateTrackablesEditor()
	{
	}

	private void UpdateImageContainer()
	{
	}

	private void UpdateCameraFrame()
	{
	}

	private void InjectCameraFrame()
	{
	}
}
