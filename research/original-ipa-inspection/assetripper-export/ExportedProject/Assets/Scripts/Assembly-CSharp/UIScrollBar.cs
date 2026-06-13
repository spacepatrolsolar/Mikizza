using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Scroll Bar")]
public class UIScrollBar : MonoBehaviour
{
	public enum Direction
	{
		Horizontal = 0,
		Vertical = 1
	}

	public delegate void OnScrollBarChange(UIScrollBar sb);

	[SerializeField]
	[HideInInspector]
	private UISprite mBG;

	[HideInInspector]
	[SerializeField]
	private UISprite mFG;

	[HideInInspector]
	[SerializeField]
	private Direction mDir;

	[SerializeField]
	[HideInInspector]
	private bool mInverted;

	[SerializeField]
	[HideInInspector]
	private float mScroll;

	[SerializeField]
	[HideInInspector]
	private float mSize;

	private Transform mTrans;

	private bool mIsDirty;

	private Camera mCam;

	private Vector2 mScreenPos;

	public OnScrollBarChange onChange;

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Camera cachedCamera
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public UISprite background
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UISprite foreground
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Direction direction
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool inverted
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public float scrollValue
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public float barSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public float alpha
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void CenterOnPos(Vector2 localPos)
	{
	}

	private void Reposition(Vector2 screenPos)
	{
	}

	private void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	private void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	private void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	private void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ForceUpdate()
	{
	}
}
