using System;
using System.Collections.Generic;
using UnityEngine;

public class StateManagerImpl : StateManager
{
	private readonly Dictionary<int, TrackableBehaviour> mTrackableBehaviours;

	private readonly List<TrackableBehaviour> mActiveTrackableBehaviours;

	public override IEnumerable<TrackableBehaviour> GetActiveTrackableBehaviours()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override IEnumerable<TrackableBehaviour> GetTrackableBehaviours()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void AssociateMarkerBehaviours()
	{
	}

	public void AssociateTrackableBehavioursForDataSet(DataSet dataSet)
	{
	}

	public void ClearTrackableBehaviours()
	{
	}

	public ImageTargetBehaviour FindOrCreateImageTargetBehaviourForTrackable(ImageTarget trackable, GameObject gameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public ImageTargetBehaviour FindOrCreateImageTargetBehaviourForTrackable(ImageTarget trackable, GameObject gameObject, DataSet dataSet)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public MarkerBehaviour CreateNewMarkerBehaviourForMarker(Marker trackable, string gameObjectName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public MarkerBehaviour CreateNewMarkerBehaviourForMarker(Marker trackable, GameObject gameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void DestroyTrackableBehavioursForTrackable(Trackable trackable, bool destroyGameObjects = true)
	{
	}

	public void SetTrackableBehavioursForTrackableToNotFound(Trackable trackable)
	{
	}

	public void EnableTrackableBehavioursForTrackable(Trackable trackable, bool enabled)
	{
	}

	public void RemoveDisabledTrackablesFromQueue(ref LinkedList<int> trackableIDs)
	{
	}

	public void UpdateCameraPose(Camera arCamera, QCARManagerImpl.TrackableResultData[] trackableResultDataArray, int originTrackableID)
	{
	}

	public void UpdateTrackablePoses(Camera arCamera, QCARManagerImpl.TrackableResultData[] trackableResultDataArray, int originTrackableID)
	{
	}

	public void UpdateVirtualButtons(int numVirtualButtons, IntPtr virtualButtonPtr)
	{
	}

	private void AssociateVirtualButtonBehaviours(VirtualButtonBehaviour[] vbBehaviours, DataSet dataSet)
	{
	}

	private void CreateMissingDataSetTrackableBehaviours(DataSet dataSet)
	{
	}

	private ImageTargetBehaviour CreateImageTargetBehaviour(ImageTarget imageTarget)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private MultiTargetBehaviour CreateMultiTargetBehaviour(MultiTarget multiTarget)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void InitializeMarkerBehaviour(MarkerBehaviour markerBehaviour, Marker marker)
	{
	}

	private void PositionCamera(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}

	private void PositionTrackable(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}
}
