using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Panel")]
public class UIPanel : MonoBehaviour
{
	public enum DebugInfo
	{
		None = 0,
		Gizmos = 1,
		Geometry = 2
	}

	public bool showInPanelTool;

	public bool generateNormals;

	public bool depthPass;

	public bool widgetsAreStatic;

	[SerializeField]
	[HideInInspector]
	private DebugInfo mDebugInfo;

	[SerializeField]
	[HideInInspector]
	private UIDrawCall.Clipping mClipping;

	[SerializeField]
	[HideInInspector]
	private Vector4 mClipRange;

	[SerializeField]
	[HideInInspector]
	private Vector2 mClipSoftness;

	private OrderedDictionary mChildren;

	private BetterList<UIWidget> mWidgets;

	private BetterList<Material> mChanged;

	private BetterList<UIDrawCall> mDrawCalls;

	private BetterList<Vector3> mVerts;

	private BetterList<Vector3> mNorms;

	private BetterList<Vector4> mTans;

	private BetterList<Vector2> mUvs;

	private BetterList<Color32> mCols;

	private Transform mTrans;

	private Camera mCam;

	private int mLayer;

	private bool mDepthChanged;

	private bool mRebuildAll;

	private bool mChangedLastFrame;

	private bool mWidgetsAdded;

	private float mMatrixTime;

	private Matrix4x4 mWorldToLocal;

	private static float[] mTemp;

	private Vector2 mMin;

	private Vector2 mMax;

	private List<Transform> mRemoved;

	private bool mCheckVisibility;

	private float mCullTime;

	private bool mCulled;

	private static BetterList<UINode> mHierarchy;

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool changedLastFrame
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public DebugInfo debugInfo
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UIDrawCall.Clipping clipping
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Vector4 clipRange
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Vector2 clipSoftness
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public BetterList<UIWidget> widgets
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public BetterList<UIDrawCall> drawCalls
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private UINode GetNode(Transform t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool IsVisible(Vector3 worldPos)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool IsVisible(UIWidget w)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void MarkMaterialAsChanged(Material mat, bool sort)
	{
	}

	public bool WatchesTransform(Transform t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private UINode AddTransform(Transform t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void RemoveTransform(Transform t)
	{
	}

	public void AddWidget(UIWidget w)
	{
	}

	public void RemoveWidget(UIWidget w)
	{
	}

	private UIDrawCall GetDrawCall(Material mat, bool createIfMissing)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private int GetChangeFlag(UINode start)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void UpdateTransformMatrix()
	{
	}

	private void UpdateTransforms()
	{
	}

	private void UpdateWidgets()
	{
	}

	public void UpdateDrawcalls()
	{
	}

	private void Fill(Material mat)
	{
	}

	private void LateUpdate()
	{
	}

	public void Refresh()
	{
	}

	public Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static void SetChildLayer(Transform t, int layer)
	{
	}

	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static UIPanel Find(Transform trans)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
