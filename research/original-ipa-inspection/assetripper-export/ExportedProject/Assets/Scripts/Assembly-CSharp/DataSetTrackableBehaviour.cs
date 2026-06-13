using UnityEngine;

public abstract class DataSetTrackableBehaviour : TrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorTrackableBehaviour
{
	[SerializeField]
	[HideInInspector]
	protected string mDataSetPath;

	string IEditorDataSetTrackableBehaviour.DataSetName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	string IEditorDataSetTrackableBehaviour.DataSetPath
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorDataSetTrackableBehaviour.SetDataSetPath(string dataSetPath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
