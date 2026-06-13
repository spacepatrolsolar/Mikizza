using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HelpController : MonoBehaviour
{
	public GameObject _root;

	private bool _isInited;

	private bool _isClosed;

	private static HelpController _instance;

	public static HelpController Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public event Action onClose
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

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnCloseClick()
	{
	}

	private void DestroyScene()
	{
	}
}
