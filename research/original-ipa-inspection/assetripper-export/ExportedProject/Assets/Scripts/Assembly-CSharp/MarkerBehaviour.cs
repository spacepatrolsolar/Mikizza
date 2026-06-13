using UnityEngine;

public class MarkerBehaviour : TrackableBehaviour, IEditorMarkerBehaviour, IEditorTrackableBehaviour
{
	[HideInInspector]
	[SerializeField]
	private int mMarkerID;

	private Marker mMarker;

	int IEditorMarkerBehaviour.MarkerID
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Marker Marker
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorMarkerBehaviour.SetMarkerID(int markerID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	void IEditorMarkerBehaviour.InitializeMarker(Marker marker)
	{
	}

	protected override void InternalUnregisterTrackable()
	{
	}

	protected override bool CorrectScaleImpl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
