using UnityEngine;

public abstract class Tracker
{
	public enum Type
	{
		IMAGE_TRACKER = 0,
		MARKER_TRACKER = 1
	}

	public abstract bool Start();

	public abstract void Stop();

	protected void PositionCamera(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}

	protected void PositionTrackable(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}
}
