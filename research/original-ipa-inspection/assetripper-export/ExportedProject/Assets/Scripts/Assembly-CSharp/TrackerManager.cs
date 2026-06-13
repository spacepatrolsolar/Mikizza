public abstract class TrackerManager
{
	private static TrackerManager mInstance;

	public static TrackerManager Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public abstract Tracker GetTracker(Tracker.Type trackerType);

	public abstract Tracker InitTracker(Tracker.Type trackerType);

	public abstract bool DeinitTracker(Tracker.Type trackerType);

	public abstract StateManager GetStateManager();
}
