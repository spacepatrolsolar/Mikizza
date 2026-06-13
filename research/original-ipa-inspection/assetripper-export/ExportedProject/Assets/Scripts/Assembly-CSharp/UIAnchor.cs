using UnityEngine;

[AddComponentMenu("NGUI/UI/Anchor")]
[ExecuteInEditMode]
public class UIAnchor : MonoBehaviour
{
	public enum Side
	{
		BottomLeft = 0,
		Left = 1,
		TopLeft = 2,
		Top = 3,
		TopRight = 4,
		Right = 5,
		BottomRight = 6,
		Bottom = 7,
		Center = 8
	}

	private bool mIsWindows;

	public Camera uiCamera;

	public UIWidget widgetContainer;

	public UIPanel panelContainer;

	public Side side;

	public bool halfPixelOffset;

	public float depthOffset;

	public Vector2 relativeOffset;

	private Animation mAnim;

	private UIRoot mRoot;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
