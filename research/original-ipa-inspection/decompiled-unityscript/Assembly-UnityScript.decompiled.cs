using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[AddComponentMenu("Kayac/Components/Touch To Mouse Converter")]
public class TouchToMouseConverter : MonoBehaviour
{
	[Serializable]
	private enum TouchToMouseState
	{
		Down,
		Drag,
		Up,
		Pinching,
		PinchEnd
	}

	public bool isOn;

	private TouchToMouseState touchState;

	private RaycastHit hit;

	private Transform beforeTransform;

	private float DRAGGING_DISTANSE;

	[NonSerialized]
	private static TouchToMouseConverter instance;

	public Camera cam;

	private float _touchesDistance;

	private Touch _pre_a;

	private Touch _pre_b;

	public static Vector3 GetMousePosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static TouchToMouseConverter GetInstance()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void SetCamera(Camera c)
	{
	}

	public virtual void Awake()
	{
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	private void singleTouch()
	{
	}

	private void multiTouch()
	{
	}

	private void noTouch()
	{
	}

	private void toDown()
	{
	}

	private void toDrag()
	{
	}

	private void toUp()
	{
	}

	private void toOldDrag()
	{
	}

	private void toOldUp()
	{
	}

	private void toPinchStart()
	{
	}

	private void toPinch(float rate)
	{
	}

	private void toPinchEnd()
	{
	}

	public virtual void Main()
	{
	}
}
