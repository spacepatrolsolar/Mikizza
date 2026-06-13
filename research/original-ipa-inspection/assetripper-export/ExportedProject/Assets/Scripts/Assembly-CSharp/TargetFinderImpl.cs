using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class TargetFinderImpl : TargetFinder
{
	[StructLayout((LayoutKind)0, Pack = 1)]
	private struct TargetFinderState
	{
		public int IsRequesting;

		[MarshalAs((UnmanagedType)31)]
		public UpdateState UpdateState;

		public int ResultCount;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	private struct InternalTargetSearchResult
	{
		public IntPtr TargetNamePtr;

		public IntPtr UniqueTargetIdPtr;

		public float TargetSize;

		public IntPtr MetaDataPtr;

		public IntPtr TargetSearchResultPtr;

		public byte TrackingRating;
	}

	private IntPtr mTargetFinderStatePtr;

	private TargetFinderState mTargetFinderState;

	private List<TargetSearchResult> mNewResults;

	private Dictionary<int, ImageTarget> mImageTargets;

	~TargetFinderImpl()
	{
	}

	public override bool StartInit(string userAuth, string secretAuth)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override InitState GetInitState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Deinit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool StartRecognition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Stop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void SetUIScanlineColor(Color color)
	{
	}

	public override void SetUIPointColor(Color color)
	{
	}

	public override bool IsRequesting()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override UpdateState Update()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override IEnumerable<TargetSearchResult> GetResults()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override ImageTargetBehaviour EnableTracking(TargetSearchResult result, string gameObjectName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override ImageTargetBehaviour EnableTracking(TargetSearchResult result, GameObject gameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void ClearTrackables(bool destroyGameObjects = true)
	{
	}

	public override IEnumerable<ImageTarget> GetImageTargets()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
