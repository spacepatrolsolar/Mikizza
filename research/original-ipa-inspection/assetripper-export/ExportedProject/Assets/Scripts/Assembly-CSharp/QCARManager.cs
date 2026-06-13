using UnityEngine;

public abstract class QCARManager
{
	private static QCARManager sInstance;

	public static QCARManager Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public abstract QCARBehaviour.WorldCenterMode WorldCenterMode { get; set; }

	public abstract TrackableBehaviour WorldCenter { get; set; }

	public abstract Camera ARCamera { get; set; }

	public abstract bool DrawVideoBackground { get; set; }

	public abstract bool Initialized { get; }

	public abstract bool Init();

	public abstract void Deinit();
}
