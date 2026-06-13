using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DJDisk : MonoBehaviour
{
	public enum TextRotateMode
	{
		NO_TEXT_ROTATION = 0,
		TEXT_ALWAYS_UP = 1
	}

	public delegate void item_change_delegate(int itemId);

	public item_change_delegate OnItemChange;

	[SerializeField]
	protected Transform rotatePanel;

	[SerializeField]
	protected Transform rotate2Panel;

	[SerializeField]
	protected Transform anchor;

	[SerializeField]
	protected Transform image;

	[SerializeField]
	protected GameObject[] djItemList;

	[SerializeField]
	protected int centerIndex;

	[SerializeField]
	protected float angleDistance;

	[SerializeField]
	protected float rotateSpeed;

	[SerializeField]
	protected Vector2 centRatio;

	[SerializeField]
	protected TextRotateMode textRotateMode;

	[SerializeField]
	protected Color selectedColor;

	[SerializeField]
	protected Color unSelectedColor;

	[SerializeField]
	protected int maxPart;

	[SerializeField]
	protected float offsetRadius;

	protected Vector2 prev;

	protected Vector2 cent;

	protected float radius;

	protected float circle;

	protected int curCenter;

	protected int prevCenter;

	protected bool isClose;

	protected bool isInited;

	protected bool isAutoRotateEffect;

	protected float curDelta;

	protected float maxTime;

	protected int checkIndex;

	protected float checkRotation;

	public event Action onRotationFinish
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Init()
	{
	}

	public GameObject GetItem(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void AddItemToDjList(string[] items)
	{
	}

	public void SetCenterIndex(int centerIdx)
	{
	}

	public void SetCenterIndex(string centerItem)
	{
	}

	private void Update()
	{
	}

	private void ResetItemRotation()
	{
	}

	private void HideAllItem()
	{
	}

	private void MoveAwayAllItem()
	{
	}

	private void OnWheelPress()
	{
	}

	public void ChangeImage(int index, string spriteName)
	{
	}

	public void ForceWheelPress(bool close)
	{
	}

	private void OnPress(bool pressed)
	{
	}

	public void ForceItemWithoutCallback(int i)
	{
	}

	protected void AutoRotate(bool useTween)
	{
	}

	public void StartAutoRotateEffect(float _maxTime, int _checkIndex)
	{
	}

	public void StopAutoRotateEffect()
	{
	}

	protected virtual float AngleToCenter(float angle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void AfterTouchRelease()
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void SetBoxCollider()
	{
	}

	private void SetProp()
	{
	}

	private void SetFirstPosition()
	{
	}

	protected virtual void SetFirstPositionOfCenterIndex()
	{
	}

	private void SetFirstPositionOf(int fromIndex, int toIndex)
	{
	}

	protected virtual void SetItemRotation(int index, float angle)
	{
	}

	protected virtual bool HideItemCondition(float x, float y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected virtual float XfromAlpha(float a, int step)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected virtual float YfromAlpha(float a, int step)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected virtual float ClampAngle(float angle, float direction)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void RotateImage(float angle, float time)
	{
	}

	private void RotateImage(Transform _rotatePanel, float angle, float time, bool _isUseCallback)
	{
	}

	private void OnAutoRotating()
	{
	}

	private void RotateImage(float angle)
	{
	}

	private void RotateItems(float angle, float time)
	{
	}

	private void RotateItems(float angle)
	{
	}

	protected virtual void GetCenter(float angle)
	{
	}

	private void SetItemsVisible()
	{
	}

	private void SetItemsVisibleOfCenterIndex()
	{
	}

	private void SetItemsVisibleOf(int fromIndex, int toIndex)
	{
	}

	protected float GetAngleOf(GameObject item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private bool IsLeft(Vector2 a, Vector2 b, Vector2 c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void ChangeItemAlpha(GameObject go, float alpha)
	{
	}

	protected bool isHideItem(GameObject go)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void HideItem(GameObject go)
	{
	}

	private void ShowItem(GameObject go)
	{
	}

	private void DeactiveAllItemTween()
	{
	}

	private void SetItemColor(GameObject go, Color col)
	{
	}

	protected virtual void SetCenterItemColor()
	{
	}

	public virtual void SetAllItemWhite()
	{
	}

	public int GetCurrentIndex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
