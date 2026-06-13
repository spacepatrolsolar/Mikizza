using UnityEngine;

public abstract class UIWidget : MonoBehaviour
{
	public enum Pivot
	{
		TopLeft = 0,
		Top = 1,
		TopRight = 2,
		Left = 3,
		Center = 4,
		Right = 5,
		BottomLeft = 6,
		Bottom = 7,
		BottomRight = 8
	}

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[SerializeField]
	[HideInInspector]
	private Texture mTex;

	[SerializeField]
	[HideInInspector]
	private Color mColor;

	[HideInInspector]
	[SerializeField]
	private Pivot mPivot;

	[HideInInspector]
	[SerializeField]
	private int mDepth;

	private Transform mTrans;

	private UIPanel mPanel;

	protected bool mChanged;

	protected bool mPlayMode;

	private Vector3 mDiffPos;

	private Quaternion mDiffRot;

	private Vector3 mDiffScale;

	private int mVisibleFlag;

	private UIGeometry mGeom;

	public Color color
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

	public Pivot pivot
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int depth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual Material material
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public virtual Texture mainTexture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UIPanel panel
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int visibleFlag
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public virtual Vector2 pivotOffset
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual Vector2 relativeSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual bool keepMaterial
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static int CompareFunc(UIWidget left, UIWidget right)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public virtual void MarkAsChanged()
	{
	}

	private void CreatePanel()
	{
	}

	public void CheckLayer()
	{
	}

	public void CheckParent()
	{
	}

	protected virtual void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public bool UpdateGeometry(ref Matrix4x4 worldToPanel, bool parentMoved, bool generateNormals)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	public virtual void MakePixelPerfect()
	{
	}

	protected virtual void OnStart()
	{
	}

	public virtual bool OnUpdate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
