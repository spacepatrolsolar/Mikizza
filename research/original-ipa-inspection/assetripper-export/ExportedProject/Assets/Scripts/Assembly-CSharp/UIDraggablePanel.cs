using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Draggable Panel")]
[RequireComponent(typeof(UIPanel))]
[ExecuteInEditMode]
public class UIDraggablePanel : IgnoreTimeScale
{
	public enum DragEffect
	{
		None = 0,
		Momentum = 1,
		MomentumAndSpring = 2
	}

	public enum ShowCondition
	{
		Always = 0,
		OnlyIfNeeded = 1,
		WhenDragging = 2
	}

	public delegate void OnDragFinished();

	public bool restrictWithinPanel;

	public bool disableDragIfFits;

	public DragEffect dragEffect;

	public Vector3 scale;

	public float scrollWheelFactor;

	public float momentumAmount;

	public Vector2 relativePositionOnReset;

	public bool repositionClipping;

	public UIScrollBar horizontalScrollBar;

	public UIScrollBar verticalScrollBar;

	public ShowCondition showScrollBars;

	public OnDragFinished onDragFinished;

	private Transform mTrans;

	private UIPanel mPanel;

	private Plane mPlane;

	private Vector3 mLastPos;

	private bool mPressed;

	private Vector3 mMomentum;

	private float mScroll;

	private Bounds mBounds;

	private bool mCalculatedBounds;

	private bool mShouldMove;

	private bool mIgnoreCallbacks;

	private int mDragID;

	public UIPanel panel
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Bounds bounds
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool shouldMoveHorizontally
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool shouldMoveVertically
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private bool shouldMove
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector3 currentMomentum
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public bool RestrictWithinBounds(bool instant)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void DisableSpring()
	{
	}

	public void UpdateScrollbars(bool recalculateBounds)
	{
	}

	public void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	public void ResetPosition()
	{
	}

	private void OnHorizontalBar(UIScrollBar sb)
	{
	}

	private void OnVerticalBar(UIScrollBar sb)
	{
	}

	public void MoveRelative(Vector3 relative)
	{
	}

	public void MoveAbsolute(Vector3 absolute)
	{
	}

	public void Press(bool pressed)
	{
	}

	public void Drag(Vector2 delta)
	{
	}

	public void Scroll(float delta)
	{
	}

	private void LateUpdate()
	{
	}
}
