using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DialogController : ShareComposerController
{
	private const string IMAGE_NAME = "screenshot.png";

	public GameObject _dialog;

	public GameObject _btnClose;

	public GameObject _btnFb;

	public GameObject _btnTw;

	public GameObject _btnAr;

	public GameObject _btnOk;

	public GameObject _imgLogo;

	public UISprite _title;

	public UISprite _content;

	public TextAsset fbiText;

	public TextAsset twiText;

	private bool _isInited;

	private bool _isClosed;

	private static DialogController _instance;

	public GameObject _root;

	public static DialogController Instance
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

	public event Action onGoAr
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

	public void SetSpecialDialog()
	{
	}

	public void SetOKDialog()
	{
	}

	public void SetShareDialog()
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

	protected override void PostFb()
	{
	}

	protected override void PostTw()
	{
	}

	private void OnFacebookClick()
	{
	}

	private void OnTwitterClick()
	{
	}

	private void OnCloseClick()
	{
	}

	private void OnGoArClick()
	{
	}

	private void OnOKClick()
	{
	}

	private void GoArAndDestroyScene()
	{
	}

	private void OKAndDestroyScene()
	{
	}

	private void DestroyScene()
	{
	}
}
