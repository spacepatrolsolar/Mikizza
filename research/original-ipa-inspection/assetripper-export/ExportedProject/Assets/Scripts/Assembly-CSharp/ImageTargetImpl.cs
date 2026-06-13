using System.Collections.Generic;
using UnityEngine;

public class ImageTargetImpl : TrackableImpl, ImageTarget, Trackable
{
	private Vector2 mSize;

	private readonly DataSetImpl mDataSet;

	private readonly ImageTargetType mImageTargetType;

	private readonly Dictionary<int, VirtualButton> mVirtualButtons;

	public ImageTargetType ImageTargetType
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ImageTargetImpl(string name, int id, ImageTargetType imageTargetType, DataSet dataSet)
	{
	}

	public Vector2 GetSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void SetSize(Vector2 size)
	{
	}

	public VirtualButton CreateVirtualButton(string name, VirtualButton.RectangleData area)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public VirtualButton GetVirtualButtonByName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public IEnumerable<VirtualButton> GetVirtualButtons()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool DestroyVirtualButton(VirtualButton vb)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private VirtualButton CreateNewVirtualButtonInNative(string name, VirtualButton.RectangleData rectangleData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private bool UnregisterVirtualButtonInNative(VirtualButton vb)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void CreateVirtualButtonsFromNative()
	{
	}
}
