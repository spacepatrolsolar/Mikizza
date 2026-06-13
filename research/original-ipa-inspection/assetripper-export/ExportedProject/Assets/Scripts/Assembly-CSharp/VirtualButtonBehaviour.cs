using System.Collections.Generic;
using UnityEngine;

public class VirtualButtonBehaviour : MonoBehaviour, IEditorVirtualButtonBehaviour
{
	public const float TARGET_OFFSET = 0.001f;

	[SerializeField]
	[HideInInspector]
	private string mName;

	[HideInInspector]
	[SerializeField]
	private VirtualButton.Sensitivity mSensitivity;

	[HideInInspector]
	[SerializeField]
	private bool mHasUpdatedPose;

	[SerializeField]
	[HideInInspector]
	private Matrix4x4 mPrevTransform;

	[HideInInspector]
	[SerializeField]
	private GameObject mPrevParent;

	private bool mSensitivityDirty;

	private bool mPreviouslyEnabled;

	private bool mPressed;

	private List<IVirtualButtonEventHandler> mHandlers;

	private Vector2 mLeftTop;

	private Vector2 mRightBottom;

	private bool mUnregisterOnDestroy;

	private VirtualButton mVirtualButton;

	VirtualButton.Sensitivity IEditorVirtualButtonBehaviour.SensitivitySetting
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	Matrix4x4 IEditorVirtualButtonBehaviour.PreviousTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	GameObject IEditorVirtualButtonBehaviour.PreviousParent
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string VirtualButtonName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool Pressed
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool HasUpdatedPose
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool UnregisterOnDestroy
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public VirtualButton VirtualButton
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	virtual bool IEditorVirtualButtonBehaviour.enabled
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	virtual Transform IEditorVirtualButtonBehaviour.transform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	virtual GameObject IEditorVirtualButtonBehaviour.gameObject
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	virtual Renderer IEditorVirtualButtonBehaviour.renderer
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorVirtualButtonBehaviour.SetVirtualButtonName(string virtualButtonName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorVirtualButtonBehaviour.SetSensitivitySetting(VirtualButton.Sensitivity sensibility)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorVirtualButtonBehaviour.SetPreviousTransform(Matrix4x4 transform)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorVirtualButtonBehaviour.SetPreviousParent(GameObject parent)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	void IEditorVirtualButtonBehaviour.InitializeVirtualButton(VirtualButton virtualButton)
	{
	}

	bool IEditorVirtualButtonBehaviour.SetPosAndScaleFromButtonArea(Vector2 topLeft, Vector2 bottomRight)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void RegisterEventHandler(IVirtualButtonEventHandler eventHandler)
	{
	}

	public bool UnregisterEventHandler(IVirtualButtonEventHandler eventHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool CalculateButtonArea(out Vector2 topLeft, out Vector2 bottomRight)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool UpdateAreaRectangle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool UpdateSensitivity()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private bool UpdateEnabled()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool UpdatePose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void OnTrackerUpdated(bool pressed)
	{
	}

	public ImageTargetBehaviour GetImageTargetBehaviour()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void LateUpdate()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private static bool Equals(Vector2 vec1, Vector2 vec2, float threshold)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
