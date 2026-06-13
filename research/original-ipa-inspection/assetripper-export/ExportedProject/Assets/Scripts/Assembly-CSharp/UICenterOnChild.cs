using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Center On Child")]
public class UICenterOnChild : MonoBehaviour
{
	public SpringPanel.OnFinished onFinished;

	private UIDraggablePanel mDrag;

	private GameObject mCenteredObject;

	public GameObject centeredObject
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void OnEnable()
	{
	}

	private void OnDragFinished()
	{
	}

	public void Recenter()
	{
	}
}
