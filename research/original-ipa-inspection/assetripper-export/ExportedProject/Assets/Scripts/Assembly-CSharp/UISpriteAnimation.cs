using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UISprite))]
[AddComponentMenu("NGUI/UI/Sprite Animation")]
public class UISpriteAnimation : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private int mFPS;

	[HideInInspector]
	[SerializeField]
	private string mPrefix;

	[SerializeField]
	[HideInInspector]
	private bool mLoop;

	private UISprite mSprite;

	private float mDelta;

	private int mIndex;

	private bool mActive;

	private List<string> mSpriteNames;

	public int frames
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int framesPerSecond
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string namePrefix
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool loop
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool isPlaying
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void RebuildSpriteList()
	{
	}

	public void Reset()
	{
	}
}
