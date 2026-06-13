using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PoUIController : MonoBehaviour
{
	private const string IMAGE_NAME = "screenshot.png";

	[SerializeField]
	private GameObject[] djDiskFacePrefab;

	[SerializeField]
	private GameObject[] djDiskPosePrefab;

	public DJDisk.item_change_delegate onFaceItemChange;

	public DJDisk.item_change_delegate onPoseItemChange;

	public PoController _poCtrl;

	public Color normalButtonColor;

	public Color selectButtonColor;

	public Transform _panel1_1;

	public Transform _panel2_1;

	public Transform _shield;

	public UIImageButton _faceButton;

	public UIImageButton _poseButton;

	public DjDiskTop _djDiskFace;

	public DjDiskTop _djDiskPose;

	public GameObject _captureScreen;

	public UIWidget _flash;

	public UISprite _logo;

	public ArNavi _banner;

	public Guide _guide;

	public Aim _aim;

	private DjDiskTop _currentDisk;

	private Texture2D _screenTex;

	private MSpecialPose _specialData;

	private int _curFace;

	public ArNavi _btnNormal;

	public ArNavi _btnNew;

	public event Action onBannerClick
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

	public event Action onArBackClick
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

	public event Action onSwitchClick
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

	public event Action onNewClick
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

	public void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void AddAllDelegates()
	{
	}

	private void RemoveAllDelegates()
	{
	}

	public int GetCurrentFace()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnFaceItemChange(int itemId)
	{
	}

	private void OnPoseItemChange(int itemId)
	{
	}

	public void OnBannerClick()
	{
	}

	public void OnArBackClick()
	{
	}

	public void OnBackClick()
	{
	}

	public void OnHelpClick()
	{
	}

	public void OnCameraClick()
	{
	}

	[DebuggerHidden]
	private IEnumerator RenTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private Texture2D CreateScreenTex()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private Material CreateScreenMat(Texture2D tex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void CreateCaptureObject(Material mat)
	{
	}

	[DebuggerHidden]
	private IEnumerator Flash()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator SaveScreenShot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator CaptureScreen()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnShareClose()
	{
	}

	[DebuggerHidden]
	public IEnumerator ShowHelp()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnHelpClose()
	{
	}

	public void OnFaceClick()
	{
	}

	private void ShowFace()
	{
	}

	public void OnPoseClick()
	{
	}

	private void ShowPose()
	{
	}

	public void OnCloseClick()
	{
	}

	public void OnFaceDiskCloseClick()
	{
	}

	public void OnPoseDiskCloseClick()
	{
	}

	public void Found()
	{
	}

	[DebuggerHidden]
	private IEnumerator IEfound()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ShowAr()
	{
	}

	public void ShowAr(float fadeTime)
	{
	}

	public void HideAr()
	{
	}

	public void HideAr(float fadeTime, string callback)
	{
	}

	public void Show(float fadeTime)
	{
	}

	public void ShowAndWaitSpecialAppear(float fadeTime)
	{
	}

	public void ActiveSpecialText(bool active)
	{
	}

	public void ActiveSpecialText(float time, float delay)
	{
	}

	public void DestroyTweenSpecialText()
	{
	}

	public void Hide()
	{
	}

	public void Hide(float fadeTime, string callback)
	{
	}

	public void StartRotateEffect()
	{
	}

	public void Lock()
	{
	}

	public void Unlock()
	{
	}

	public void UnlockAfter(float delay)
	{
	}

	[DebuggerHidden]
	private IEnumerator IErotatePoseDisk(float delay)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void HidePoseDisk()
	{
	}

	private void ShowPoseDisk(float delay)
	{
	}

	private void HideFaceDisk()
	{
	}

	private void ShowFaceDisk(float delay)
	{
	}

	[DebuggerHidden]
	private IEnumerator Capture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnSwitchNormalClick()
	{
	}

	private void OnSwitchNewClick()
	{
	}

	private void LockSwitchButtons()
	{
	}

	private void UnlockSwitchButtons()
	{
	}

	public void ResetDisks(int version = 0)
	{
	}

	private DjDiskTop MakeDisk(GameObject prefab, GameObject old, Transform pa)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
