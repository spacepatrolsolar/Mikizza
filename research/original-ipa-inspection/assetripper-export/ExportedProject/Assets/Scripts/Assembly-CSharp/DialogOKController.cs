using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DialogOKController : MonoBehaviour
{
	public GameObject _dialog;

	public GameObject _btnClose;

	public GameObject _btnOk;

	public UISprite _title;

	public UISprite _content;

	private bool _isInited;

	private bool _isClosed;

	private static DialogOKController _instance;

	public GameObject _root;

	public static DialogOKController Instance
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

	public event Action onOK
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

	private void HideAllButton()
	{
	}

	public void SetOKDialog()
	{
	}

	private void SetContent(string title, string content)
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnCloseClick()
	{
	}

	private void OnOKClick()
	{
	}

	private void OKAndDestroyScene()
	{
	}

	private void DestroyScene()
	{
	}
}
