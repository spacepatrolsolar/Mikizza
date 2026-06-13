using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Table")]
[ExecuteInEditMode]
public class UITable : MonoBehaviour
{
	public enum Direction
	{
		Down = 0,
		Up = 1
	}

	public delegate void OnReposition();

	public int columns;

	public Direction direction;

	public Vector2 padding;

	public bool sorted;

	public bool hideInactive;

	public bool repositionNow;

	public bool keepWithinPanel;

	public OnReposition onReposition;

	private UIPanel mPanel;

	private UIDraggablePanel mDrag;

	private bool mStarted;

	private List<Transform> mChildren;

	public List<Transform> children
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static int SortByName(Transform a, Transform b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void RepositionVariableSize(List<Transform> children)
	{
	}

	public void Reposition()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
