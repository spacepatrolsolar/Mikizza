using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Grid")]
public class UIGrid : MonoBehaviour
{
	public enum Arrangement
	{
		Horizontal = 0,
		Vertical = 1
	}

	public Arrangement arrangement;

	public int maxPerLine;

	public float cellWidth;

	public float cellHeight;

	public bool repositionNow;

	public bool sorted;

	public bool hideInactive;

	private bool mStarted;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static int SortByName(Transform a, Transform b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Reposition()
	{
	}
}
