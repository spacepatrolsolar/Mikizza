using System.Collections.Generic;
using UnityEngine;

public abstract class TrackableBehaviour : MonoBehaviour, IEditorTrackableBehaviour
{
	public enum Status
	{
		NOT_FOUND = -1,
		UNKNOWN = 0,
		UNDEFINED = 1,
		DETECTED = 2,
		TRACKED = 3
	}

	[HideInInspector]
	[SerializeField]
	protected string mTrackableName;

	[SerializeField]
	[HideInInspector]
	protected Vector3 mPreviousScale;

	[SerializeField]
	[HideInInspector]
	protected bool mPreserveChildSize;

	[HideInInspector]
	[SerializeField]
	protected bool mInitializedInEditor;

	protected Status mStatus;

	protected Trackable mTrackable;

	private List<ITrackableEventHandler> mTrackableEventHandlers;

	Vector3 IEditorTrackableBehaviour.PreviousScale
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorTrackableBehaviour.PreserveChildSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorTrackableBehaviour.InitializedInEditor
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Status CurrentStatus
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Trackable Trackable
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string TrackableName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	virtual bool IEditorTrackableBehaviour.enabled
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	virtual Transform IEditorTrackableBehaviour.transform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	virtual GameObject IEditorTrackableBehaviour.gameObject
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	virtual Renderer IEditorTrackableBehaviour.renderer
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorTrackableBehaviour.CorrectScale()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorTrackableBehaviour.SetNameForTrackable(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorTrackableBehaviour.SetPreviousScale(Vector3 previousScale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorTrackableBehaviour.SetPreserveChildSize(bool preserveChildSize)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorTrackableBehaviour.SetInitializedInEditor(bool initializedInEditor)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	void IEditorTrackableBehaviour.UnregisterTrackable()
	{
	}

	public void RegisterTrackableEventHandler(ITrackableEventHandler trackableEventHandler)
	{
	}

	public bool UnregisterTrackableEventHandler(ITrackableEventHandler trackableEventHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void OnTrackerUpdate(Status newStatus)
	{
	}

	protected abstract void InternalUnregisterTrackable();

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual bool CorrectScaleImpl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
