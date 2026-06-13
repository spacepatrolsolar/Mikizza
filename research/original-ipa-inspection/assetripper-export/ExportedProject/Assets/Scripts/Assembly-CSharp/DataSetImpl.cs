using System;
using System.Collections.Generic;
using UnityEngine;

public class DataSetImpl : DataSet
{
	private IntPtr mDataSetPtr;

	private string mPath;

	private StorageType mStorageType;

	private readonly Dictionary<int, Trackable> mTrackablesDict;

	public IntPtr DataSetPtr
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override string Path
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override StorageType FileStorageType
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public DataSetImpl(IntPtr dataSetPtr)
	{
	}

	public static bool ExistsImpl(string path, StorageType storageType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Load(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Load(string path, StorageType storageType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override IEnumerable<Trackable> GetTrackables()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, string gameObjectName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, GameObject gameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Destroy(Trackable trackable, bool destroyGameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool HasReachedTrackableLimit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Contains(Trackable trackable)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void DestroyAllTrackables(bool destroyGameObject)
	{
	}

	private void CreateImageTargets()
	{
	}

	private void CreateMultiTargets()
	{
	}
}
