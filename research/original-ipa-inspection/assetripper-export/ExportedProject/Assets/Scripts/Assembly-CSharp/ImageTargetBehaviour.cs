using System.Collections.Generic;
using UnityEngine;

public class ImageTargetBehaviour : DataSetTrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorImageTargetBehaviour, IEditorTrackableBehaviour
{
	[SerializeField]
	[HideInInspector]
	private float mAspectRatio;

	[SerializeField]
	[HideInInspector]
	private ImageTargetType mImageTargetType;

	private ImageTarget mImageTarget;

	private Dictionary<int, VirtualButtonBehaviour> mVirtualButtonBehaviours;

	float IEditorImageTargetBehaviour.AspectRatio
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	ImageTargetType IEditorImageTargetBehaviour.ImageTargetType
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ImageTarget ImageTarget
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorImageTargetBehaviour.SetAspectRatio(float aspectRatio)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorImageTargetBehaviour.SetImageTargetType(ImageTargetType imageTargetType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	void IEditorImageTargetBehaviour.InitializeImageTarget(ImageTarget imageTarget)
	{
	}

	void IEditorImageTargetBehaviour.AssociateExistingVirtualButtonBehaviour(VirtualButtonBehaviour virtualButtonBehaviour)
	{
	}

	void IEditorImageTargetBehaviour.CreateMissingVirtualButtonBehaviours()
	{
	}

	bool IEditorImageTargetBehaviour.TryGetVirtualButtonBehaviourByID(int id, out VirtualButtonBehaviour virtualButtonBehaviour)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override bool CorrectScaleImpl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void InternalUnregisterTrackable()
	{
	}

	public VirtualButtonBehaviour CreateVirtualButton(string vbName, Vector2 position, Vector2 size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static VirtualButtonBehaviour CreateVirtualButton(string vbName, Vector2 localScale, GameObject immediateParent)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public IEnumerable<VirtualButtonBehaviour> GetVirtualButtonBehaviours()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void DestroyVirtualButton(string vbName)
	{
	}

	public Vector2 GetSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void CreateVirtualButtonFromNative(VirtualButton virtualButton)
	{
	}

	private bool CreateNewVirtualButtonFromBehaviour(VirtualButtonBehaviour newVBB)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
