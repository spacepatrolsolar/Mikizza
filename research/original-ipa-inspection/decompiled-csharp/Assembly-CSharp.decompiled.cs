using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using AnimationOrTween;
using UnityEngine;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyVersion("0.0.0.0")]
public class ASoundManager : MonoBehaviour
{
	protected virtual void Awake()
	{
	}

	protected virtual void OnMute()
	{
	}

	protected virtual void OnUnmute()
	{
	}
}
public class SoundContainer : MonoBehaviour
{
	public List<AudioClip> audioClips;

	public Dictionary<string, AudioClip> audioDict;

	private static SoundContainer instance;

	public static SoundContainer Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void Awake()
	{
	}

	public void Add(AudioClip audioClip)
	{
	}

	public void Refresh()
	{
	}
}
public class SoundTools
{
	private static AudioListener mListener;

	private static bool mLoaded;

	private static float mGlobalVolume;

	public static float soundVolume
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public static AudioSource PlaySound(AudioClip clip)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static AudioSource PlayBGM(AudioClip clip, bool loop)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static AudioSource PlayBGM(AudioClip clip, float volume, bool loop)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static AudioSource PlayBGM(AudioClip clip, float volume, float pitch, bool loop)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void StopBGM()
	{
	}

	public static void PauseBGM()
	{
	}

	public static void ResumeBGM()
	{
	}

	public static bool isPlaying()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float Percent()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float TimePlay()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float Seek(float percent)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float Length()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class SoundManager : ASoundManager
{
	public AudioClip[] commonAudioClips;

	private Dictionary<string, AudioClip> audioDict;

	private static bool isMuteDevice;

	private static bool isMuteInGame;

	private static string currentBGM;

	private static SoundManager instance;

	public static SoundManager Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	protected override void Awake()
	{
	}

	public void Play(string name)
	{
	}

	public void PlayBGM(string name)
	{
	}

	public void PlayBGMNoLoop(string name)
	{
	}

	public void PlayBGMCommon(string name)
	{
	}

	public void StopBGM()
	{
	}

	public bool IsPlaying()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void OnMute()
	{
	}

	protected override void OnUnmute()
	{
	}

	public void SetMuteInGame()
	{
	}

	public void SetUnmuteInGame()
	{
	}
}
public class GirlLoader : MonoBehaviour
{
	private string url;

	public GUIText gText;

	private GameObject girl;

	[DebuggerHidden]
	private IEnumerator Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateByName(int i, Vector3 scale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Update()
	{
	}
}
public class ManyLoader : MonoBehaviour
{
	public GUIText gText;

	private GameObject car;

	private GameObject girl;

	private string[] downloadList;

	[DebuggerHidden]
	private IEnumerator Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateByName(string item, Vector3 scale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Update()
	{
	}
}
public class CarLoader : MonoBehaviour
{
	public GUIText gText;

	private GameObject car;

	[DebuggerHidden]
	private IEnumerator Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateByName(string item, Vector3 scale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Update()
	{
	}
}
public class ABManager : MonoBehaviour
{
	public enum ABServer
	{
		RELEASE,
		DEV,
		DEV_PREVIEW,
		DOMINO_TEST
	}

	public static bool UseAssetBundleCache;

	public ABServer aBServer;

	public int assetVersion;

	public string domain;

	public string domainTest;

	public string domainDevPreview;

	public string domainDev;

	private Dictionary<string, AssetBundle> assetBundleList;

	private static ABManager instance;

	private AssetBundle assetBundle;

	private WWW downloadWWW;

	private string url;

	private int countLoaded;

	private int totalLoad;

	private bool downloading;

	private string currentDomain;

	public static ABManager Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool Downloading
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected void Init()
	{
	}

	protected void SetServer()
	{
	}

	private void SetTotal(int total)
	{
	}

	public float GetProgress()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public string GetStringProgress()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool ContainsItem(string item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public UnityEngine.Object GetItem(string item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public UnityEngine.Object GetItemChild(string item, string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	public IEnumerator Download(List<string> stringList)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	public IEnumerator Download(string[] stringList)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	public IEnumerator Download(string str)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	public IEnumerator DownloadAbsolutely(string str)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void FreeAllAssets()
	{
	}

	public void FreeAsset(string item)
	{
	}

	public void FreeAssets(List<string> items)
	{
	}

	public void FreeAssets(string[] items)
	{
	}

	public bool IsDownloaded(string str)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void SetUrl(string str)
	{
	}

	private void LoadItemsBegin(string str)
	{
	}

	private void LoadItemsEnd(string str)
	{
	}
}
[RequireComponent(typeof(UIPopupList))]
[AddComponentMenu("NGUI/Interaction/Language Selection")]
public class LanguageSelection : MonoBehaviour
{
	private UIPopupList mList;

	private void Start()
	{
	}

	private void UpdateList()
	{
	}

	private void OnLanguageSelection(string language)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button")]
public class UIButton : UIButtonColor
{
	public Color disabledColor;

	public bool isEnabled
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected override void OnEnable()
	{
	}

	protected override void OnHover(bool isOver)
	{
	}

	protected override void OnPress(bool isPressed)
	{
	}

	public void UpdateColor(bool shouldBeEnabled, bool immediate)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button Activate")]
public class UIButtonActivate : MonoBehaviour
{
	public GameObject target;

	public bool state;

	private void OnClick()
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button Color")]
public class UIButtonColor : MonoBehaviour
{
	public GameObject tweenTarget;

	public Color hover;

	public Color pressed;

	public float duration;

	protected Color mColor;

	protected bool mInitDone;

	protected bool mStarted;

	protected bool mHighlighted;

	public Color defaultColor
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected virtual void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected void Init()
	{
	}

	protected virtual void OnPress(bool isPressed)
	{
	}

	protected virtual void OnHover(bool isOver)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button Keys")]
[RequireComponent(typeof(Collider))]
public class UIButtonKeys : MonoBehaviour
{
	public bool startsSelected;

	public UIButtonKeys selectOnClick;

	public UIButtonKeys selectOnUp;

	public UIButtonKeys selectOnDown;

	public UIButtonKeys selectOnLeft;

	public UIButtonKeys selectOnRight;

	private void Start()
	{
	}

	private void OnKey(KeyCode key)
	{
	}

	private void OnClick()
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button Message")]
public class UIButtonMessage : MonoBehaviour
{
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease,
		OnDoubleClick
	}

	public GameObject target;

	public string functionName;

	public Trigger trigger;

	public bool includeChildren;

	private bool mStarted;

	private bool mHighlighted;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void Send()
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button Offset")]
public class UIButtonOffset : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	private Vector3 mPos;

	private bool mInitDone;

	private bool mStarted;

	private bool mHighlighted;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Init()
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnHover(bool isOver)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button Play Animation")]
public class UIButtonPlayAnimation : MonoBehaviour
{
	public Animation target;

	public string clipName;

	public Trigger trigger;

	public Direction playDirection;

	public bool resetOnPlay;

	public bool clearSelection;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public GameObject eventReceiver;

	public string callWhenFinished;

	public ActiveAnimation.OnFinished onFinished;

	private bool mStarted;

	private bool mHighlighted;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	private void OnActivate(bool isActive)
	{
	}

	private void Play(bool forward)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button Rotation")]
public class UIButtonRotation : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	private Quaternion mRot;

	private bool mInitDone;

	private bool mStarted;

	private bool mHighlighted;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Init()
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnHover(bool isOver)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button Scale")]
public class UIButtonScale : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	private Vector3 mScale;

	private bool mInitDone;

	private bool mStarted;

	private bool mHighlighted;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Init()
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnHover(bool isOver)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button Sound")]
public class UIButtonSound : MonoBehaviour
{
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease
	}

	public AudioClip audioClip;

	public Trigger trigger;

	public float volume;

	public float pitch;

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnClick()
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Button Tween")]
public class UIButtonTween : MonoBehaviour
{
	public GameObject tweenTarget;

	public int tweenGroup;

	public Trigger trigger;

	public Direction playDirection;

	public bool resetOnPlay;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public bool includeChildren;

	public GameObject eventReceiver;

	public string callWhenFinished;

	public UITweener.OnFinished onFinished;

	private UITweener[] mTweens;

	private bool mStarted;

	private bool mHighlighted;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	private void OnActivate(bool isActive)
	{
	}

	private void Update()
	{
	}

	public void Play(bool forward)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Center On Child")]
public class UICenterOnChild : MonoBehaviour
{
	public SpringPanel.OnFinished onFinished;

	private UIDraggablePanel mDrag;

	private GameObject mCenteredObject;

	public GameObject centeredObject
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void OnEnable()
	{
	}

	private void OnDragFinished()
	{
	}

	public void Recenter()
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Checkbox")]
public class UICheckbox : MonoBehaviour
{
	public delegate void OnStateChange(bool state);

	public static UICheckbox current;

	public UISprite checkSprite;

	public Animation checkAnimation;

	public bool startsChecked;

	public Transform radioButtonRoot;

	public bool optionCanBeNone;

	public GameObject eventReceiver;

	public string functionName;

	public OnStateChange onStateChange;

	[SerializeField]
	[HideInInspector]
	private bool option;

	private bool mChecked;

	private bool mStarted;

	private Transform mTrans;

	public bool isChecked
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnClick()
	{
	}

	private void Set(bool state)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Checkbox Controlled Component")]
public class UICheckboxControlledComponent : MonoBehaviour
{
	public MonoBehaviour target;

	public bool inverse;

	private bool mUsingDelegates;

	private void Start()
	{
	}

	private void OnActivateDelegate(bool isActive)
	{
	}

	private void OnActivate(bool isActive)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Checkbox Controlled Object")]
public class UICheckboxControlledObject : MonoBehaviour
{
	public GameObject target;

	public bool inverse;

	private void OnEnable()
	{
	}

	private void OnActivate(bool isActive)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Drag Camera")]
[ExecuteInEditMode]
public class UIDragCamera : IgnoreTimeScale
{
	public UIDraggableCamera draggableCamera;

	[HideInInspector]
	[SerializeField]
	private Component target;

	private void Awake()
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnScroll(float delta)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Drag Object")]
public class UIDragObject : IgnoreTimeScale
{
	public enum DragEffect
	{
		None,
		Momentum,
		MomentumAndSpring
	}

	public Transform target;

	public Vector3 scale;

	public float scrollWheelFactor;

	public bool restrictWithinPanel;

	public DragEffect dragEffect;

	public float momentumAmount;

	private Plane mPlane;

	private Vector3 mLastPos;

	private UIPanel mPanel;

	private bool mPressed;

	private Vector3 mMomentum;

	private float mScroll;

	private Bounds mBounds;

	private void FindPanel()
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void LateUpdate()
	{
	}

	private void OnScroll(float delta)
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Drag Panel Contents")]
public class UIDragPanelContents : MonoBehaviour
{
	public UIDraggablePanel draggablePanel;

	[SerializeField]
	[HideInInspector]
	private UIPanel panel;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnScroll(float delta)
	{
	}
}
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Interaction/Draggable Camera")]
public class UIDraggableCamera : IgnoreTimeScale
{
	public Transform rootForBounds;

	public Vector2 scale;

	public float scrollWheelFactor;

	public UIDragObject.DragEffect dragEffect;

	public float momentumAmount;

	private Camera mCam;

	private Transform mTrans;

	private bool mPressed;

	private Vector2 mMomentum;

	private Bounds mBounds;

	private float mScroll;

	private UIRoot mRoot;

	public Vector2 currentMomentum
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private Vector3 CalculateConstrainOffset()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool ConstrainToBounds(bool immediate)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Press(bool isPressed)
	{
	}

	public void Drag(Vector2 delta)
	{
	}

	public void Scroll(float delta)
	{
	}

	private void Update()
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Draggable Panel")]
[RequireComponent(typeof(UIPanel))]
[ExecuteInEditMode]
public class UIDraggablePanel : IgnoreTimeScale
{
	public enum DragEffect
	{
		None,
		Momentum,
		MomentumAndSpring
	}

	public enum ShowCondition
	{
		Always,
		OnlyIfNeeded,
		WhenDragging
	}

	public delegate void OnDragFinished();

	public bool restrictWithinPanel;

	public bool disableDragIfFits;

	public DragEffect dragEffect;

	public Vector3 scale;

	public float scrollWheelFactor;

	public float momentumAmount;

	public Vector2 relativePositionOnReset;

	public bool repositionClipping;

	public UIScrollBar horizontalScrollBar;

	public UIScrollBar verticalScrollBar;

	public ShowCondition showScrollBars;

	public OnDragFinished onDragFinished;

	private Transform mTrans;

	private UIPanel mPanel;

	private Plane mPlane;

	private Vector3 mLastPos;

	private bool mPressed;

	private Vector3 mMomentum;

	private float mScroll;

	private Bounds mBounds;

	private bool mCalculatedBounds;

	private bool mShouldMove;

	private bool mIgnoreCallbacks;

	private int mDragID;

	public UIPanel panel
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Bounds bounds
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool shouldMoveHorizontally
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool shouldMoveVertically
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private bool shouldMove
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector3 currentMomentum
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public bool RestrictWithinBounds(bool instant)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void DisableSpring()
	{
	}

	public void UpdateScrollbars(bool recalculateBounds)
	{
	}

	public void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	public void ResetPosition()
	{
	}

	private void OnHorizontalBar(UIScrollBar sb)
	{
	}

	private void OnVerticalBar(UIScrollBar sb)
	{
	}

	public void MoveRelative(Vector3 relative)
	{
	}

	public void MoveAbsolute(Vector3 absolute)
	{
	}

	public void Press(bool pressed)
	{
	}

	public void Drag(Vector2 delta)
	{
	}

	public void Scroll(float delta)
	{
	}

	private void LateUpdate()
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Forward Events")]
public class UIForwardEvents : MonoBehaviour
{
	public GameObject target;

	public bool onHover;

	public bool onPress;

	public bool onClick;

	public bool onDoubleClick;

	public bool onSelect;

	public bool onDrag;

	public bool onDrop;

	public bool onInput;

	public bool onSubmit;

	public bool onScroll;

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnSelect(bool selected)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnDrop(GameObject go)
	{
	}

	private void OnInput(string text)
	{
	}

	private void OnSubmit()
	{
	}

	private void OnScroll(float delta)
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Grid")]
public class UIGrid : MonoBehaviour
{
	public enum Arrangement
	{
		Horizontal,
		Vertical
	}

	public Arrangement arrangement;

	public int maxPerLine;

	public float cellWidth;

	public float cellHeight;

	public bool repositionNow;

	public bool sorted;

	public bool hideInactive;

	private bool mStarted;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static int SortByName(Transform a, Transform b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Reposition()
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Image Button")]
public class UIImageButton : MonoBehaviour
{
	public UISprite target;

	public string normalSprite;

	public string hoverSprite;

	public string pressedSprite;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool pressed)
	{
	}
}
[RequireComponent(typeof(UIInput))]
[AddComponentMenu("NGUI/Interaction/Input Validator")]
public class UIInputValidator : MonoBehaviour
{
	public enum Validation
	{
		None,
		Integer,
		Float,
		Alphanumeric,
		Username,
		Name
	}

	public Validation logic;

	private void Start()
	{
	}

	private char Validate(string text, char ch)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Interaction/Panel Alpha")]
public class UIPanelAlpha : MonoBehaviour
{
	public float alpha;

	private Collider[] mColliders;

	private UIWidget[] mWidgets;

	private float[] mAlpha;

	private float mLastAlpha;

	private int mLevel;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateAlpha()
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Popup List")]
[ExecuteInEditMode]
public class UIPopupList : MonoBehaviour
{
	public enum Position
	{
		Auto,
		Above,
		Below
	}

	public delegate void OnSelectionChange(string item);

	private const float animSpeed = 0.15f;

	public static UIPopupList current;

	public UIAtlas atlas;

	public UIFont font;

	public UILabel textLabel;

	public string backgroundSprite;

	public string highlightSprite;

	public Position position;

	public List<string> items;

	public Vector2 padding;

	public float textScale;

	public Color textColor;

	public Color backgroundColor;

	public Color highlightColor;

	public bool isAnimated;

	public bool isLocalized;

	public GameObject eventReceiver;

	public string functionName;

	public OnSelectionChange onSelectionChange;

	[HideInInspector]
	[SerializeField]
	private string mSelectedItem;

	private UIPanel mPanel;

	private GameObject mChild;

	private UISprite mBackground;

	private UISprite mHighlight;

	private UILabel mHighlightedLabel;

	private List<UILabel> mLabelList;

	private float mBgBorder;

	public bool isOpen
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string selection
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private bool handleEvents
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnLocalize(Localization loc)
	{
	}

	private void Highlight(UILabel lbl, bool instant)
	{
	}

	private void OnItemHover(GameObject go, bool isOver)
	{
	}

	private void Select(UILabel lbl, bool instant)
	{
	}

	private void OnItemPress(GameObject go, bool isPressed)
	{
	}

	private void OnKey(KeyCode key)
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	private void AnimateColor(UIWidget widget)
	{
	}

	private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	private void OnClick()
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Saved Option")]
public class UISavedOption : MonoBehaviour
{
	public string keyName;

	private UIPopupList mList;

	private UICheckbox mCheck;

	private string key
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SaveSelection(string selection)
	{
	}

	private void SaveState(bool state)
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Scroll Bar")]
public class UIScrollBar : MonoBehaviour
{
	public enum Direction
	{
		Horizontal,
		Vertical
	}

	public delegate void OnScrollBarChange(UIScrollBar sb);

	[SerializeField]
	[HideInInspector]
	private UISprite mBG;

	[HideInInspector]
	[SerializeField]
	private UISprite mFG;

	[HideInInspector]
	[SerializeField]
	private Direction mDir;

	[SerializeField]
	[HideInInspector]
	private bool mInverted;

	[SerializeField]
	[HideInInspector]
	private float mScroll;

	[SerializeField]
	[HideInInspector]
	private float mSize;

	private Transform mTrans;

	private bool mIsDirty;

	private Camera mCam;

	private Vector2 mScreenPos;

	public OnScrollBarChange onChange;

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Camera cachedCamera
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public UISprite background
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UISprite foreground
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Direction direction
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool inverted
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public float scrollValue
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public float barSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public float alpha
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void CenterOnPos(Vector2 localPos)
	{
	}

	private void Reposition(Vector2 screenPos)
	{
	}

	private void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	private void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	private void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	private void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ForceUpdate()
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Slider")]
public class UISlider : IgnoreTimeScale
{
	public enum Direction
	{
		Horizontal,
		Vertical
	}

	public delegate void OnValueChange(float val);

	public static UISlider current;

	public Transform foreground;

	public Transform thumb;

	public Direction direction;

	public Vector2 fullSize;

	public GameObject eventReceiver;

	public string functionName;

	public OnValueChange onValueChange;

	public int numberOfSteps;

	[SerializeField]
	[HideInInspector]
	private float rawValue;

	private float mStepValue;

	private BoxCollider mCol;

	private Transform mTrans;

	private Transform mFGTrans;

	private UIWidget mFGWidget;

	private UIFilledSprite mFGFilled;

	private bool mInitDone;

	public float sliderValue
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Init()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnPressThumb(GameObject go, bool pressed)
	{
	}

	private void OnDragThumb(GameObject go, Vector2 delta)
	{
	}

	private void OnKey(KeyCode key)
	{
	}

	private void UpdateDrag()
	{
	}

	private void Set(float input, bool force)
	{
	}

	public void ForceUpdate()
	{
	}
}
[ExecuteInEditMode]
[RequireComponent(typeof(UISlider))]
[AddComponentMenu("NGUI/Examples/Slider Colors")]
public class UISliderColors : MonoBehaviour
{
	public UISprite sprite;

	public Color[] colors;

	private UISlider mSlider;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Sound Volume")]
[RequireComponent(typeof(UISlider))]
public class UISoundVolume : MonoBehaviour
{
	private UISlider mSlider;

	private void Awake()
	{
	}

	private void OnSliderChange(float val)
	{
	}
}
[AddComponentMenu("NGUI/Interaction/Table")]
[ExecuteInEditMode]
public class UITable : MonoBehaviour
{
	public enum Direction
	{
		Down,
		Up
	}

	public delegate void OnReposition();

	public int columns;

	public Direction direction;

	public Vector2 padding;

	public bool sorted;

	public bool hideInactive;

	public bool repositionNow;

	public bool keepWithinPanel;

	public OnReposition onReposition;

	private UIPanel mPanel;

	private UIDraggablePanel mDrag;

	private bool mStarted;

	private List<Transform> mChildren;

	public List<Transform> children
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static int SortByName(Transform a, Transform b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void RepositionVariableSize(List<Transform> children)
	{
	}

	public void Reposition()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
[RequireComponent(typeof(Animation))]
[AddComponentMenu("NGUI/Internal/Active Animation")]
public class ActiveAnimation : IgnoreTimeScale
{
	public delegate void OnFinished(ActiveAnimation anim);

	public OnFinished onFinished;

	public GameObject eventReceiver;

	public string callWhenFinished;

	private Animation mAnim;

	private Direction mLastDirection;

	private Direction mDisableDirection;

	private bool mNotify;

	public void Reset()
	{
	}

	private void Update()
	{
	}

	private void Play(string clipName, Direction playDirection)
	{
	}

	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
namespace AnimationOrTween;

public enum Trigger
{
	OnClick,
	OnHover,
	OnPress,
	OnHoverTrue,
	OnHoverFalse,
	OnPressTrue,
	OnPressFalse,
	OnActivate,
	OnActivateTrue,
	OnActivateFalse,
	OnDoubleClick,
	OnSelect,
	OnSelectTrue,
	OnSelectFalse
}
public enum Direction
{
	Reverse = -1,
	Toggle,
	Forward
}
public enum EnableCondition
{
	DoNothing,
	EnableThenPlay
}
public enum DisableCondition
{
	DisableAfterReverse = -1,
	DoNotDisable,
	DisableAfterForward
}
[Serializable]
public class BMFont
{
	[HideInInspector]
	[SerializeField]
	private BMGlyph[] mGlyphs;

	[SerializeField]
	[HideInInspector]
	private int mSize;

	[SerializeField]
	[HideInInspector]
	private int mBase;

	[HideInInspector]
	[SerializeField]
	private int mWidth;

	[SerializeField]
	[HideInInspector]
	private int mHeight;

	[SerializeField]
	[HideInInspector]
	private string mSpriteName;

	[SerializeField]
	[HideInInspector]
	private List<BMGlyph> mSaved;

	[HideInInspector]
	[SerializeField]
	private List<BMSymbol> mSymbols;

	private Dictionary<int, BMGlyph> mDict;

	public bool isValid
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int charSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int baseOffset
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int texWidth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int texHeight
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int glyphCount
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string spriteName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public List<BMSymbol> symbols
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool LegacyCheck()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private int GetArraySize(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public BMGlyph GetGlyph(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Clear()
	{
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}
}
[Serializable]
public class BMGlyph
{
	public struct Kerning
	{
		public int previousChar;

		public int amount;
	}

	public int index;

	public int x;

	public int y;

	public int width;

	public int height;

	public int offsetX;

	public int offsetY;

	public int advance;

	public int channel;

	public List<Kerning> kerning;

	public int GetKerning(int previousChar)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void SetKerning(int previousChar, int amount)
	{
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}
}
[Serializable]
public class BMSymbol
{
	public string sequence;

	public int x;

	public int y;

	public int width;

	public int height;

	private int mLength;

	public int length
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}
}
public class BetterList<T>
{
	public T[] buffer;

	public int size;

	public T this[int i]
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	[DebuggerHidden]
	public IEnumerator<T> GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void AllocateMore()
	{
	}

	private void Trim()
	{
	}

	public void Clear()
	{
	}

	public void Release()
	{
	}

	public void Add(T item)
	{
	}

	public void Insert(int index, T item)
	{
	}

	public bool Contains(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool Remove(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void RemoveAt(int index)
	{
	}

	public T[] ToArray()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Sort(Comparison<T> comparer)
	{
	}
}
public class ByteReader
{
	private byte[] mBuffer;

	private int mOffset;

	public bool canRead
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ByteReader(byte[] bytes)
	{
	}

	public ByteReader(TextAsset asset)
	{
	}

	private static string ReadLine(byte[] buffer, int start, int count)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public string ReadLine()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Dictionary<string, string> ReadDictionary()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Internal/Ignore TimeScale Behaviour")]
public class IgnoreTimeScale : MonoBehaviour
{
	private float mTimeStart;

	private float mTimeDelta;

	private float mActual;

	private bool mTimeStarted;

	public float realTimeDelta
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	protected virtual void OnEnable()
	{
	}

	protected float UpdateRealTimeDelta()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Internal/Localization")]
public class Localization : MonoBehaviour
{
	private static Localization mInst;

	public string startingLanguage;

	public TextAsset[] languages;

	private Dictionary<string, string> mDictionary;

	private string mLanguage;

	public static Localization instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string currentLanguage
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Load(TextAsset asset)
	{
	}

	public string Get(string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Internal/Debug")]
public class NGUIDebug : MonoBehaviour
{
	private static List<string> mLines;

	private static NGUIDebug mInstance;

	public static void Log(string text)
	{
	}

	public static void DrawBounds(Bounds b)
	{
	}

	private void OnGUI()
	{
	}
}
public static class NGUIMath
{
	public static float Lerp(float from, float to, float factor)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int ClampIndex(int val, int max)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int RepeatIndex(int val, int max)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float WrapAngle(float angle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float Wrap01(float val)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int HexToDecimal(char ch)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static char DecimalToHexChar(int num)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static string DecimalToHex(int num)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int ColorToInt(Color c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Color IntToColor(int val)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static string IntToBinary(int val, int bits)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Color HexToColor(uint val)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Rect MakePixelPerfect(Rect rect)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Vector3 ApplyHalfPixelOffset(Vector3 pos)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Vector3 ApplyHalfPixelOffset(Vector3 pos, Vector3 scale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform root, Transform child)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Bounds CalculateRelativeInnerBounds(Transform root, UISlicedSprite sprite)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Bounds CalculateRelativeInnerBounds(Transform root, UISprite sprite)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float SpringLerp(float strength, float deltaTime)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float RotateTowards(float from, float to, float maxAngle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public static class NGUITools
{
	private static AudioListener mListener;

	private static bool mLoaded;

	private static float mGlobalVolume;

	public static float soundVolume
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public static bool fileAccess
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static AudioSource PlaySound(AudioClip clip)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static WWW OpenURL(string url)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static WWW OpenURL(string url, WWWForm form)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int RandomRange(int min, int max)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static string GetHierarchy(GameObject obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Color ParseColor(string text, int offset)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static string EncodeColor(Color c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int ParseSymbol(string text, int index, List<Color> colors)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static string StripSymbols(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static T[] FindActive<T>() where T : Component
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Camera FindCameraForLayer(int layer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static BoxCollider AddWidgetCollider(GameObject go)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static string GetName<T>() where T : Component
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static GameObject AddChild(GameObject parent)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static GameObject AddChild(GameObject parent, GameObject prefab)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int CalculateNextDepth(GameObject go)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static T AddChild<T>(GameObject parent) where T : Component
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static T AddWidget<T>(GameObject go) where T : UIWidget
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static T FindInParents<T>(GameObject go) where T : Component
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void Destroy(UnityEngine.Object obj)
	{
	}

	public static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	public static void Broadcast(string funcName)
	{
	}

	public static void Broadcast(string funcName, object param)
	{
	}

	public static bool IsChild(Transform parent, Transform child)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static void Activate(Transform t)
	{
	}

	private static void Deactivate(Transform t)
	{
	}

	public static void SetActive(GameObject go, bool state)
	{
	}

	public static void SetActiveChildren(GameObject go, bool state)
	{
	}

	public static bool GetActive(GameObject go)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void SetActiveSelf(GameObject go, bool state)
	{
	}

	public static void SetLayer(GameObject go, int layer)
	{
	}

	public static Vector3 Round(Vector3 v)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void MakePixelPerfect(Transform t)
	{
	}

	public static bool Save(string fileName, byte[] bytes)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static byte[] Load(string fileName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[RequireComponent(typeof(UIPanel))]
[AddComponentMenu("NGUI/Internal/Spring Panel")]
public class SpringPanel : IgnoreTimeScale
{
	public delegate void OnFinished();

	public Vector3 target;

	public float strength;

	public OnFinished onFinished;

	private UIPanel mPanel;

	private Transform mTrans;

	private float mThreshold;

	private UIDraggablePanel mDrag;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Internal/Draw Call")]
[ExecuteInEditMode]
public class UIDrawCall : MonoBehaviour
{
	public enum Clipping
	{
		None,
		HardClip,
		AlphaClip,
		SoftClip
	}

	private Transform mTrans;

	private Material mSharedMat;

	private Mesh mMesh0;

	private Mesh mMesh1;

	private MeshFilter mFilter;

	private MeshRenderer mRen;

	private Clipping mClipping;

	private Vector4 mClipRange;

	private Vector2 mClipSoft;

	private Material mClippedMat;

	private Material mDepthMat;

	private int[] mIndices;

	private bool mDepthPass;

	private bool mReset;

	private bool mEven;

	public bool depthPass
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Material material
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int triangles
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Clipping clipping
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Vector4 clipRange
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Vector2 clipSoftness
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private Mesh GetMesh(ref bool rebuildIndices, int vertexCount)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void UpdateMaterials()
	{
	}

	public void Set(BetterList<Vector3> verts, BetterList<Vector3> norms, BetterList<Vector4> tans, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	private void OnWillRenderObject()
	{
	}

	private void OnDestroy()
	{
	}
}
[AddComponentMenu("NGUI/Internal/Event Listener")]
public class UIEventListener : MonoBehaviour
{
	public delegate void VoidDelegate(GameObject go);

	public delegate void BoolDelegate(GameObject go, bool state);

	public delegate void FloatDelegate(GameObject go, float delta);

	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	public delegate void StringDelegate(GameObject go, string text);

	public delegate void ObjectDelegate(GameObject go, GameObject draggedObject);

	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	public object parameter;

	public VoidDelegate onSubmit;

	public VoidDelegate onClick;

	public VoidDelegate onDoubleClick;

	public BoolDelegate onHover;

	public BoolDelegate onPress;

	public BoolDelegate onSelect;

	public FloatDelegate onScroll;

	public VectorDelegate onDrag;

	public ObjectDelegate onDrop;

	public StringDelegate onInput;

	public KeyCodeDelegate onKey;

	private void OnSubmit()
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnSelect(bool selected)
	{
	}

	private void OnScroll(float delta)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnDrop(GameObject go)
	{
	}

	private void OnInput(string text)
	{
	}

	private void OnKey(KeyCode key)
	{
	}

	public static UIEventListener Get(GameObject go)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class UIGeometry
{
	public BetterList<Vector3> verts;

	public BetterList<Vector2> uvs;

	public BetterList<Color32> cols;

	private BetterList<Vector3> mRtpVerts;

	private Vector3 mRtpNormal;

	private Vector4 mRtpTan;

	public bool hasVertices
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool hasTransformed
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public void Clear()
	{
	}

	public void ApplyOffset(Vector3 pivotOffset)
	{
	}

	public void ApplyTransform(Matrix4x4 widgetToPanel, bool normals)
	{
	}

	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}
}
public class UINode
{
	private int mVisibleFlag;

	public Transform trans;

	public UIWidget widget;

	public bool lastActive;

	public Vector3 lastPos;

	public Quaternion lastRot;

	public Vector3 lastScale;

	public int changeFlag;

	private GameObject mGo;

	public int visibleFlag
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UINode(Transform t)
	{
	}

	public bool HasChanged()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public abstract class UIWidget : MonoBehaviour
{
	public enum Pivot
	{
		TopLeft,
		Top,
		TopRight,
		Left,
		Center,
		Right,
		BottomLeft,
		Bottom,
		BottomRight
	}

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[SerializeField]
	[HideInInspector]
	private Texture mTex;

	[SerializeField]
	[HideInInspector]
	private Color mColor;

	[HideInInspector]
	[SerializeField]
	private Pivot mPivot;

	[HideInInspector]
	[SerializeField]
	private int mDepth;

	private Transform mTrans;

	private UIPanel mPanel;

	protected bool mChanged;

	protected bool mPlayMode;

	private Vector3 mDiffPos;

	private Quaternion mDiffRot;

	private Vector3 mDiffScale;

	private int mVisibleFlag;

	private UIGeometry mGeom;

	public Color color
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public float alpha
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Pivot pivot
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int depth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual Material material
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public virtual Texture mainTexture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UIPanel panel
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int visibleFlag
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public virtual Vector2 pivotOffset
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual Vector2 relativeSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual bool keepMaterial
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static int CompareFunc(UIWidget left, UIWidget right)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public virtual void MarkAsChanged()
	{
	}

	private void CreatePanel()
	{
	}

	public void CheckLayer()
	{
	}

	public void CheckParent()
	{
	}

	protected virtual void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public bool UpdateGeometry(ref Matrix4x4 worldToPanel, bool parentMoved, bool generateNormals)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	public virtual void MakePixelPerfect()
	{
	}

	protected virtual void OnStart()
	{
	}

	public virtual bool OnUpdate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Internal/Update Manager")]
public class UpdateManager : MonoBehaviour
{
	public class UpdateEntry
	{
		public int index;

		public OnUpdate func;

		public MonoBehaviour mb;

		public bool isMonoBehaviour;
	}

	public class DestroyEntry
	{
		public UnityEngine.Object obj;

		public float time;
	}

	public delegate void OnUpdate(float delta);

	private static UpdateManager mInst;

	private List<UpdateEntry> mOnUpdate;

	private List<UpdateEntry> mOnLate;

	private List<UpdateEntry> mOnCoro;

	private BetterList<DestroyEntry> mDest;

	private float mTime;

	private static int Compare(UpdateEntry a, UpdateEntry b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static void CreateInstance()
	{
	}

	private void UpdateList(List<UpdateEntry> list, float delta)
	{
	}

	private void Start()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private bool CoroutineUpdate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator CoroutineFunction()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Add(MonoBehaviour mb, int updateOrder, OnUpdate func, List<UpdateEntry> list)
	{
	}

	public static void AddUpdate(MonoBehaviour mb, int updateOrder, OnUpdate func)
	{
	}

	public static void AddLateUpdate(MonoBehaviour mb, int updateOrder, OnUpdate func)
	{
	}

	public static void AddCoroutine(MonoBehaviour mb, int updateOrder, OnUpdate func)
	{
	}

	public static void AddDestroy(UnityEngine.Object obj, float delay)
	{
	}
}
[AddComponentMenu("NGUI/Tween/Spring Position")]
public class SpringPosition : IgnoreTimeScale
{
	public delegate void OnFinished(SpringPosition spring);

	public Vector3 target;

	public float strength;

	public bool worldSpace;

	public bool ignoreTimeScale;

	public GameObject eventReceiver;

	public string callWhenFinished;

	public OnFinished onFinished;

	private Transform mTrans;

	private float mThreshold;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Tween/Alpha")]
public class TweenAlpha : UITweener
{
	public float from;

	public float to;

	private Transform mTrans;

	private UIWidget mWidget;

	public float alpha
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenAlpha Begin(GameObject go, float duration, float alpha)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Tween/Color")]
public class TweenColor : UITweener
{
	public Color from;

	public Color to;

	private Transform mTrans;

	private UIWidget mWidget;

	private Material mMat;

	private Light mLight;

	public Color color
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Tween/Field of View")]
public class TweenFOV : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float fov
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Tween/Position")]
public class TweenPosition : UITweener
{
	public Vector3 from;

	public Vector3 to;

	private Transform mTrans;

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector3 position
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Tween/Rotation")]
public class TweenRotation : UITweener
{
	public Vector3 from;

	public Vector3 to;

	private Transform mTrans;

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Quaternion rotation
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Tween/Scale")]
public class TweenScale : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool updateTable;

	private Transform mTrans;

	private UITable mTable;

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector3 scale
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Tween/Transform")]
public class TweenTransform : UITweener
{
	public Transform from;

	public Transform to;

	public bool parentWhenFinished;

	private Transform mTrans;

	private Vector3 mPos;

	private Quaternion mRot;

	private Vector3 mScale;

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenTransform Begin(GameObject go, float duration, Transform to)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/Tween/Volume")]
public class TweenVolume : UITweener
{
	public float from;

	public float to;

	private AudioSource mSource;

	public AudioSource audioSource
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float volume
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public abstract class UITweener : IgnoreTimeScale
{
	public enum Method
	{
		Linear,
		EaseIn,
		EaseOut,
		EaseInOut,
		BounceIn,
		BounceOut
	}

	public enum Style
	{
		Once,
		Loop,
		PingPong
	}

	public delegate void OnFinished(UITweener tween);

	public OnFinished onFinished;

	public Method method;

	public Style style;

	public bool ignoreTimeScale;

	public float delay;

	public float duration;

	public bool steeperCurves;

	public int tweenGroup;

	public GameObject eventReceiver;

	public string callWhenFinished;

	private float mStartTime;

	private float mDuration;

	private float mAmountPerDelta;

	private float mFactor;

	public float amountPerDelta
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float tweenFactor
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Direction direction
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	protected override void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Sample(float factor, bool isFinished)
	{
	}

	private float BounceLogic(float val)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Play(bool forward)
	{
	}

	public void Reset()
	{
	}

	public void Toggle()
	{
	}

	protected abstract void OnUpdate(float factor, bool isFinished);

	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[AddComponentMenu("NGUI/UI/Anchor")]
[ExecuteInEditMode]
public class UIAnchor : MonoBehaviour
{
	public enum Side
	{
		BottomLeft,
		Left,
		TopLeft,
		Top,
		TopRight,
		Right,
		BottomRight,
		Bottom,
		Center
	}

	private bool mIsWindows;

	public Camera uiCamera;

	public UIWidget widgetContainer;

	public UIPanel panelContainer;

	public Side side;

	public bool halfPixelOffset;

	public float depthOffset;

	public Vector2 relativeOffset;

	private Animation mAnim;

	private UIRoot mRoot;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
[AddComponentMenu("NGUI/UI/Atlas")]
public class UIAtlas : MonoBehaviour
{
	[Serializable]
	public class Sprite
	{
		public string name;

		public Rect outer;

		public Rect inner;

		public float paddingLeft;

		public float paddingRight;

		public float paddingTop;

		public float paddingBottom;

		public bool hasPadding
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}
	}

	public enum Coordinates
	{
		Pixels,
		TexCoords
	}

	[HideInInspector]
	[SerializeField]
	private Material material;

	[HideInInspector]
	[SerializeField]
	private List<Sprite> sprites;

	[SerializeField]
	[HideInInspector]
	private Coordinates mCoordinates;

	[SerializeField]
	[HideInInspector]
	private float mPixelSize;

	[SerializeField]
	[HideInInspector]
	private UIAtlas mReplacement;

	public Material spriteMaterial
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public List<Sprite> spriteList
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Texture texture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Coordinates coordinates
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public float pixelSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UIAtlas replacement
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Sprite GetSprite(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static int CompareString(string a, string b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public BetterList<string> GetListOfSprites()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public BetterList<string> GetListOfSprites(string match)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private bool References(UIAtlas atlas)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void MarkAsDirty()
	{
	}
}
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Camera")]
public class UICamera : MonoBehaviour
{
	public enum ClickNotification
	{
		None,
		Always,
		BasedOnDelta
	}

	public class MouseOrTouch
	{
		public Vector2 pos;

		public Vector2 delta;

		public Vector2 totalDelta;

		public Camera pressedCam;

		public GameObject current;

		public GameObject pressed;

		public float clickTime;

		public ClickNotification clickNotification;

		public bool touchBegan;

		public bool dragStarted;
	}

	private class Highlighted
	{
		public GameObject go;

		public int counter;
	}

	public bool useMouse;

	public bool useTouch;

	public bool allowMultiTouch;

	public bool useKeyboard;

	public bool useController;

	public LayerMask eventReceiverMask;

	public bool clipRaycasts;

	public float tooltipDelay;

	public bool stickyTooltip;

	public float mouseDragThreshold;

	public float mouseClickThreshold;

	public float touchDragThreshold;

	public float touchClickThreshold;

	public float rangeDistance;

	public string scrollAxisName;

	public string verticalAxisName;

	public string horizontalAxisName;

	public KeyCode submitKey0;

	public KeyCode submitKey1;

	public KeyCode cancelKey0;

	public KeyCode cancelKey1;

	public static bool showTooltips;

	public static Vector2 lastTouchPosition;

	public static RaycastHit lastHit;

	public static UICamera current;

	public static Camera currentCamera;

	public static int currentTouchID;

	public static MouseOrTouch currentTouch;

	public static bool inputHasFocus;

	public static GameObject genericEventHandler;

	public static GameObject fallThrough;

	private static List<UICamera> mList;

	private static List<Highlighted> mHighlighted;

	private static GameObject mSel;

	private static MouseOrTouch[] mMouse;

	private static GameObject mHover;

	private static MouseOrTouch mController;

	private static float mNextEvent;

	private Dictionary<int, MouseOrTouch> mTouches;

	private GameObject mTooltip;

	private Camera mCam;

	private LayerMask mLayerMask;

	private float mTooltipTime;

	private bool mIsEditor;

	private bool handlesEvents
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Camera cachedCamera
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static GameObject hoveredObject
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static GameObject selectedObject
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public static Camera mainCamera
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static UICamera eventHandler
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void OnApplicationQuit()
	{
	}

	private static int CompareFunc(UICamera a, UICamera b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static bool Raycast(Vector3 inPos, ref RaycastHit hit)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static bool IsVisible(ref RaycastHit hit)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static UICamera FindCameraForLayer(int layer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static int GetDirection(KeyCode up, KeyCode down)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static int GetDirection(string axis)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool IsHighlighted(GameObject go)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static void Highlight(GameObject go, bool highlighted)
	{
	}

	private static void Notify(GameObject go, string funcName, object obj)
	{
	}

	private MouseOrTouch GetTouch(int id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void RemoveTouch(int id)
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void ProcessMouse()
	{
	}

	private void ProcessTouches()
	{
	}

	private void ProcessOthers()
	{
	}

	private void ProcessTouch(bool pressed, bool unpressed)
	{
	}

	public void ShowTooltip(bool val)
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Filled)")]
public class UIFilledSprite : UISprite
{
	public enum FillDirection
	{
		Horizontal,
		Vertical,
		Radial90,
		Radial180,
		Radial360
	}

	[HideInInspector]
	[SerializeField]
	private FillDirection mFillDirection;

	[HideInInspector]
	[SerializeField]
	private float mFillAmount;

	[SerializeField]
	[HideInInspector]
	private bool mInvert;

	public FillDirection fillDirection
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public float fillAmount
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool invert
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private bool AdjustRadial(Vector2[] xy, Vector2[] uv, float fill, bool invert)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Rotate(Vector2[] v, int offset)
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
[AddComponentMenu("NGUI/UI/Font")]
[ExecuteInEditMode]
public class UIFont : MonoBehaviour
{
	public enum Alignment
	{
		Left,
		Center,
		Right
	}

	public enum SymbolStyle
	{
		None,
		Uncolored,
		Colored
	}

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[SerializeField]
	[HideInInspector]
	private Rect mUVRect;

	[SerializeField]
	[HideInInspector]
	private BMFont mFont;

	[SerializeField]
	[HideInInspector]
	private int mSpacingX;

	[SerializeField]
	[HideInInspector]
	private int mSpacingY;

	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	private UIFont mReplacement;

	private UIAtlas.Sprite mSprite;

	private bool mSpriteSet;

	private List<Color> mColors;

	public BMFont bmFont
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int texWidth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int texHeight
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public UIAtlas atlas
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Material material
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Texture2D texture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Rect uvRect
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string spriteName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int horizontalSpacing
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int verticalSpacing
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int size
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public UIAtlas.Sprite sprite
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public UIFont replacement
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Trim()
	{
	}

	private bool References(UIFont font)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void MarkAsDirty()
	{
	}

	public Vector2 CalculatePrintedSize(string text, bool encoding, SymbolStyle symbolStyle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static void EndLine(ref StringBuilder s)
	{
	}

	public string GetEndOfLineThatFits(string text, float maxWidth, bool encoding, SymbolStyle symbolStyle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public string WrapText(string text, float maxWidth, int maxLineCount, bool encoding, SymbolStyle symbolStyle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public string WrapText(string text, float maxWidth, int maxLineCount, bool encoding)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public string WrapText(string text, float maxWidth, int maxLineCount)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Align(BetterList<Vector3> verts, int indexOffset, Alignment alignment, int x, int lineWidth)
	{
	}

	public void Print(string text, Color32 color, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, bool encoding, SymbolStyle symbolStyle, Alignment alignment, int lineWidth)
	{
	}
}
[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInput : MonoBehaviour
{
	public enum KeyboardType
	{
		Default,
		ASCIICapable,
		NumbersAndPunctuation,
		URL,
		NumberPad,
		PhonePad,
		NamePhonePad,
		EmailAddress
	}

	public delegate char Validator(string currentText, char nextChar);

	public delegate void OnSubmit(string inputString);

	public static UIInput current;

	public UILabel label;

	public int maxChars;

	public string caratChar;

	public Validator validator;

	public KeyboardType type;

	public bool isPassword;

	public Color activeColor;

	public GameObject eventReceiver;

	public string functionName;

	public OnSubmit onSubmit;

	private string mText;

	private string mDefaultText;

	private Color mDefaultColor;

	private UIWidget.Pivot mPivot;

	private float mPosition;

	private TouchScreenKeyboard mKeyboard;

	private bool mDoInit;

	public string text
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool selected
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	private void Update()
	{
	}

	private void OnInput(string input)
	{
	}

	private void UpdateLabel()
	{
	}

	private void RestoreLabel()
	{
	}
}
[AddComponentMenu("NGUI/UI/Input (Saved)")]
public class UIInputSaved : UIInput
{
	public string playerPrefsField;

	private void Start()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
[AddComponentMenu("NGUI/UI/Label")]
[ExecuteInEditMode]
public class UILabel : UIWidget
{
	public enum Effect
	{
		None,
		Shadow,
		Outline
	}

	[HideInInspector]
	[SerializeField]
	private UIFont mFont;

	[SerializeField]
	[HideInInspector]
	private string mText;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineWidth;

	[SerializeField]
	[HideInInspector]
	private bool mEncoding;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineCount;

	[SerializeField]
	[HideInInspector]
	private bool mPassword;

	[HideInInspector]
	[SerializeField]
	private bool mShowLastChar;

	[SerializeField]
	[HideInInspector]
	private Effect mEffectStyle;

	[SerializeField]
	[HideInInspector]
	private Color mEffectColor;

	[SerializeField]
	[HideInInspector]
	private UIFont.SymbolStyle mSymbols;

	[SerializeField]
	[HideInInspector]
	private Vector2 mEffectDistance;

	[SerializeField]
	[HideInInspector]
	private float mLineWidth;

	[SerializeField]
	[HideInInspector]
	private bool mMultiline;

	private bool mShouldBeProcessed;

	private string mProcessedText;

	private Vector3 mLastScale;

	private string mLastText;

	private int mLastWidth;

	private bool mLastEncoding;

	private int mLastCount;

	private bool mLastPass;

	private bool mLastShow;

	private Effect mLastEffect;

	private Vector3 mSize;

	private bool hasChanged
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UIFont font
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string text
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool supportEncoding
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UIFont.SymbolStyle symbolStyle
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int lineWidth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool multiLine
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int maxLineCount
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool password
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool showLastPasswordChar
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Effect effectStyle
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Color effectColor
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Vector2 effectDistance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string processedText
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Material material
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Vector2 relativeSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	protected override void OnStart()
	{
	}

	public override void MarkAsChanged()
	{
	}

	private void ProcessText()
	{
	}

	public void MakePositionPerfect()
	{
	}

	public override void MakePixelPerfect()
	{
	}

	private void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/UI/Localize")]
public class UILocalize : MonoBehaviour
{
	public string key;

	private string mLanguage;

	private bool mStarted;

	private void OnLocalize(Localization loc)
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void Localize()
	{
	}
}
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Orthographic Camera")]
public class UIOrthoCamera : MonoBehaviour
{
	private Camera mCam;

	private Transform mTrans;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Panel")]
public class UIPanel : MonoBehaviour
{
	public enum DebugInfo
	{
		None,
		Gizmos,
		Geometry
	}

	public bool showInPanelTool;

	public bool generateNormals;

	public bool depthPass;

	public bool widgetsAreStatic;

	[SerializeField]
	[HideInInspector]
	private DebugInfo mDebugInfo;

	[SerializeField]
	[HideInInspector]
	private UIDrawCall.Clipping mClipping;

	[SerializeField]
	[HideInInspector]
	private Vector4 mClipRange;

	[SerializeField]
	[HideInInspector]
	private Vector2 mClipSoftness;

	private OrderedDictionary mChildren;

	private BetterList<UIWidget> mWidgets;

	private BetterList<Material> mChanged;

	private BetterList<UIDrawCall> mDrawCalls;

	private BetterList<Vector3> mVerts;

	private BetterList<Vector3> mNorms;

	private BetterList<Vector4> mTans;

	private BetterList<Vector2> mUvs;

	private BetterList<Color32> mCols;

	private Transform mTrans;

	private Camera mCam;

	private int mLayer;

	private bool mDepthChanged;

	private bool mRebuildAll;

	private bool mChangedLastFrame;

	private bool mWidgetsAdded;

	private float mMatrixTime;

	private Matrix4x4 mWorldToLocal;

	private static float[] mTemp;

	private Vector2 mMin;

	private Vector2 mMax;

	private List<Transform> mRemoved;

	private bool mCheckVisibility;

	private float mCullTime;

	private bool mCulled;

	private static BetterList<UINode> mHierarchy;

	public Transform cachedTransform
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool changedLastFrame
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public DebugInfo debugInfo
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UIDrawCall.Clipping clipping
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Vector4 clipRange
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Vector2 clipSoftness
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public BetterList<UIWidget> widgets
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public BetterList<UIDrawCall> drawCalls
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private UINode GetNode(Transform t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool IsVisible(Vector3 worldPos)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool IsVisible(UIWidget w)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void MarkMaterialAsChanged(Material mat, bool sort)
	{
	}

	public bool WatchesTransform(Transform t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private UINode AddTransform(Transform t)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void RemoveTransform(Transform t)
	{
	}

	public void AddWidget(UIWidget w)
	{
	}

	public void RemoveWidget(UIWidget w)
	{
	}

	private UIDrawCall GetDrawCall(Material mat, bool createIfMissing)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private int GetChangeFlag(UINode start)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void UpdateTransformMatrix()
	{
	}

	private void UpdateTransforms()
	{
	}

	private void UpdateWidgets()
	{
	}

	public void UpdateDrawcalls()
	{
	}

	private void Fill(Material mat)
	{
	}

	private void LateUpdate()
	{
	}

	public void Refresh()
	{
	}

	public Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private static void SetChildLayer(Transform t, int layer)
	{
	}

	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static UIPanel Find(Transform trans)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Root")]
public class UIRoot : MonoBehaviour
{
	private static List<UIRoot> mRoots;

	private Transform mTrans;

	public bool automatic;

	public int manualHeight;

	public int minimumHeight;

	public int maximumHeight;

	public static List<UIRoot> list
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int activeHeight
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float pixelSizeAdjustment
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static void Broadcast(string funcName)
	{
	}

	public static void Broadcast(string funcName, object param)
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Sliced)")]
public class UISlicedSprite : UISprite
{
	[SerializeField]
	[HideInInspector]
	private bool mFillCenter;

	protected Rect mInner;

	protected Rect mInnerUV;

	protected Vector3 mScale;

	public Rect innerUV
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool fillCenter
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override Vector4 border
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Vector2 pivotOffset
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override void UpdateUVs(bool force)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Basic)")]
public class UISprite : UIWidget
{
	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	protected UIAtlas.Sprite mSprite;

	protected Rect mOuter;

	protected Rect mOuterUV;

	private bool mSpriteSet;

	private string mLastName;

	public Rect outerUV
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public UIAtlas atlas
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string spriteName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public UIAtlas.Sprite sprite
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override Vector2 pivotOffset
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Material material
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual Vector4 border
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual void UpdateUVs(bool force)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	protected override void OnStart()
	{
	}

	public override bool OnUpdate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
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
[AddComponentMenu("NGUI/UI/Stretch")]
[ExecuteInEditMode]
public class UIStretch : MonoBehaviour
{
	public enum Style
	{
		None,
		Horizontal,
		Vertical,
		Both,
		BasedOnHeight
	}

	public Camera uiCamera;

	public UIWidget widgetContainer;

	public UIPanel panelContainer;

	public Style style;

	public Vector2 relativeSize;

	private Transform mTrans;

	private UIRoot mRoot;

	private Animation mAnim;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
[AddComponentMenu("NGUI/UI/Text List")]
public class UITextList : MonoBehaviour
{
	public enum Style
	{
		Text,
		Chat
	}

	protected class Paragraph
	{
		public string text;

		public string[] lines;
	}

	public Style style;

	public UILabel textLabel;

	public float maxWidth;

	public float maxHeight;

	public int maxEntries;

	public bool supportScrollWheel;

	protected char[] mSeparator;

	protected List<Paragraph> mParagraphs;

	protected float mScroll;

	protected bool mSelected;

	protected int mTotalLines;

	public void Clear()
	{
	}

	public void Add(string text)
	{
	}

	protected void Add(string text, bool updateVisible)
	{
	}

	private void Awake()
	{
	}

	private void OnSelect(bool selected)
	{
	}

	protected void UpdateVisibleText()
	{
	}

	private void OnScroll(float val)
	{
	}
}
[AddComponentMenu("NGUI/UI/Texture")]
[ExecuteInEditMode]
public class UITexture : UIWidget
{
	[SerializeField]
	[HideInInspector]
	private Rect mRect;

	[SerializeField]
	[HideInInspector]
	private Shader mShader;

	[HideInInspector]
	[SerializeField]
	private Texture mTexture;

	private Material mDynamicMat;

	private bool mCreatingMat;

	public Rect uvRect
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Shader shader
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool hasDynamicMaterial
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool keepMaterial
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Material material
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override Texture mainTexture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void OnDestroy()
	{
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Tiled)")]
public class UITiledSprite : UISlicedSprite
{
	public override Vector4 border
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
[AddComponentMenu("NGUI/UI/Tooltip")]
public class UITooltip : MonoBehaviour
{
	private static UITooltip mInstance;

	public Camera uiCamera;

	public UILabel text;

	public UISlicedSprite background;

	public float appearSpeed;

	public bool scalingTransitions;

	private Transform mTrans;

	private float mTarget;

	private float mCurrent;

	private Vector3 mPos;

	private Vector3 mSize;

	private UIWidget[] mWidgets;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetAlpha(float val)
	{
	}

	private void SetText(string tooltipText)
	{
	}

	public static void ShowText(string tooltipText)
	{
	}
}
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Viewport Camera")]
public class UIViewport : MonoBehaviour
{
	public Camera sourceCamera;

	public Transform topLeft;

	public Transform bottomRight;

	public float fullSize;

	private Camera mCam;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
public abstract class CameraDevice
{
	public enum CameraDeviceMode
	{
		MODE_DEFAULT = -1,
		MODE_OPTIMIZE_SPEED = -2,
		MODE_OPTIMIZE_QUALITY = -3
	}

	public enum FocusMode
	{
		FOCUS_MODE_NORMAL,
		FOCUS_MODE_TRIGGERAUTO,
		FOCUS_MODE_CONTINUOUSAUTO,
		FOCUS_MODE_INFINITY,
		FOCUS_MODE_MACRO
	}

	public enum CameraDirection
	{
		CAMERA_DEFAULT,
		CAMERA_BACK,
		CAMERA_FRONT
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct VideoModeData
	{
		public int width;

		public int height;

		public float frameRate;
	}

	private static CameraDevice mInstance;

	public static CameraDevice Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public abstract bool Init(CameraDirection cameraDirection);

	public abstract bool Deinit();

	public abstract bool Start();

	public abstract bool Stop();

	public abstract VideoModeData GetVideoMode(CameraDeviceMode mode);

	public abstract bool SelectVideoMode(CameraDeviceMode mode);

	public abstract bool SetFlashTorchMode(bool on);

	public abstract bool SetFocusMode(FocusMode mode);

	public abstract bool SetFrameFormat(Image.PIXEL_FORMAT format, bool enabled);

	public abstract Image GetCameraImage(Image.PIXEL_FORMAT format);
}
public class CloudRecoBehaviour : MonoBehaviour, ITrackerEventHandler
{
	private ImageTracker mImageTracker;

	private bool mCurrentlyInitializing;

	private bool mInitSuccess;

	private bool mCloudRecoStarted;

	private bool mOnInitializedCalled;

	private readonly List<ICloudRecoEventHandler> mHandlers;

	public string AccessKey;

	public string SecretKey;

	public Color ScanlineColor;

	public Color FeaturePointColor;

	public bool CloudRecoEnabled
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool CloudRecoInitialized
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void Initialize()
	{
	}

	private void Deinitialize()
	{
	}

	private void CheckInitialization()
	{
	}

	private void StartCloudReco()
	{
	}

	private void StopCloudReco()
	{
	}

	public void RegisterEventHandler(ICloudRecoEventHandler eventHandler)
	{
	}

	public bool UnregisterEventHandler(ICloudRecoEventHandler eventHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnInitialized()
	{
	}

	public void OnTrackablesUpdated()
	{
	}
}
public abstract class DataSet
{
	public enum StorageType
	{
		STORAGE_APP,
		STORAGE_APPRESOURCE,
		STORAGE_ABSOLUTE
	}

	public abstract string Path { get; }

	public abstract StorageType FileStorageType { get; }

	public static bool Exists(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool Exists(string path, StorageType storageType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public abstract bool Load(string name);

	public abstract bool Load(string path, StorageType storageType);

	public abstract IEnumerable<Trackable> GetTrackables();

	public abstract DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, string gameObjectName);

	public abstract DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, GameObject gameObject);

	public abstract bool Destroy(Trackable trackable, bool destroyGameObject);

	public abstract bool HasReachedTrackableLimit();

	public abstract bool Contains(Trackable trackable);

	public abstract void DestroyAllTrackables(bool destroyGameObject);
}
public class DataSetLoadBehaviour : MonoBehaviour
{
	[SerializeField]
	[HideInInspector]
	public List<string> mDataSetsToActivate;

	[SerializeField]
	[HideInInspector]
	public List<string> mDataSetsToLoad;

	private void Awake()
	{
	}
}
public abstract class DataSetTrackableBehaviour : TrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorTrackableBehaviour
{
	[SerializeField]
	[HideInInspector]
	protected string mDataSetPath;

	string IEditorDataSetTrackableBehaviour.DataSetName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	string IEditorDataSetTrackableBehaviour.DataSetPath
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorDataSetTrackableBehaviour.SetDataSetPath(string dataSetPath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class DefaultInitializationErrorHandler : MonoBehaviour
{
	private const string WINDOW_TITLE = "QCAR Initialization Error";

	private string mErrorText;

	private bool mErrorOccurred;

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	private void DrawWindowContent(int id)
	{
	}

	private void SetErrorCode(QCARUnity.InitError errorCode)
	{
	}

	private void SetErrorOccurred(bool errorOccurred)
	{
	}
}
public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
	private TrackableBehaviour mTrackableBehaviour;

	private void Start()
	{
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	private void OnTrackingFound()
	{
	}

	private void OnTrackingLost()
	{
	}
}
public class GLErrorHandler : MonoBehaviour
{
	private const string WINDOW_TITLE = "Sample Error";

	private static string mErrorText;

	private static bool mErrorOccurred;

	public static void SetError(string errorText)
	{
	}

	private void OnGUI()
	{
	}

	private void DrawWindowContent(int id)
	{
	}
}
public interface ICloudRecoEventHandler
{
	void OnInitialized();

	void OnInitError(TargetFinder.InitState initError);

	void OnUpdateError(TargetFinder.UpdateState updateError);

	void OnStateChanged(bool scanning);

	void OnNewSearchResult(TargetFinder.TargetSearchResult targetSearchResult);
}
public interface ITrackableEventHandler
{
	void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus);
}
public interface ITrackerEventHandler
{
	void OnInitialized();

	void OnTrackablesUpdated();
}
public interface IUserDefinedTargetEventHandler
{
	void OnInitialized();

	void OnFrameQualityChanged(ImageTargetBuilder.FrameQuality frameQuality);

	void OnNewTrackableSource(TrackableSource trackableSource);
}
public interface IVideoBackgroundEventHandler
{
	void OnVideoBackgroundConfigChanged();
}
public interface IVirtualButtonEventHandler
{
	void OnButtonPressed(VirtualButtonBehaviour vb);

	void OnButtonReleased(VirtualButtonBehaviour vb);
}
public abstract class Image
{
	public enum PIXEL_FORMAT
	{
		UNKNOWN_FORMAT = 0,
		RGB565 = 1,
		RGB888 = 2,
		GRAYSCALE = 4,
		YUV = 8,
		RGBA8888 = 0x10
	}

	public abstract int Width { get; set; }

	public abstract int Height { get; set; }

	public abstract int Stride { get; set; }

	public abstract int BufferWidth { get; set; }

	public abstract int BufferHeight { get; set; }

	public abstract PIXEL_FORMAT PixelFormat { get; set; }

	public abstract byte[] Pixels { get; set; }

	public abstract bool IsValid();
}
public enum ImageTargetType
{
	PREDEFINED,
	USER_DEFINED,
	CLOUD_RECO
}
[StructLayout((LayoutKind)0, Pack = 1)]
public struct ImageTargetData
{
	public int id;

	[MarshalAs((UnmanagedType)30, SizeConst = 2)]
	public Vector2 size;
}
public interface ImageTarget : Trackable
{
	ImageTargetType ImageTargetType { get; }

	Vector2 GetSize();

	void SetSize(Vector2 size);

	VirtualButton CreateVirtualButton(string name, VirtualButton.RectangleData area);

	VirtualButton GetVirtualButtonByName(string name);

	IEnumerable<VirtualButton> GetVirtualButtons();

	bool DestroyVirtualButton(VirtualButton vb);
}
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
public abstract class ImageTargetBuilder
{
	public enum FrameQuality
	{
		FRAME_QUALITY_NONE = -1,
		FRAME_QUALITY_LOW,
		FRAME_QUALITY_MEDIUM,
		FRAME_QUALITY_HIGH
	}

	public abstract bool Build(string targetName, float sceenSizeWidth);

	public abstract void StartScan();

	public abstract void StopScan();

	public abstract FrameQuality GetFrameQuality();

	public abstract TrackableSource GetTrackableSource();
}
public abstract class ImageTracker : Tracker
{
	public abstract ImageTargetBuilder ImageTargetBuilder { get; }

	public abstract TargetFinder TargetFinder { get; }

	public abstract DataSet CreateDataSet();

	public abstract bool DestroyDataSet(DataSet dataSet, bool destroyTrackables);

	public abstract bool ActivateDataSet(DataSet dataSet);

	public abstract bool DeactivateDataSet(DataSet dataSet);

	public abstract IEnumerable<DataSet> GetActiveDataSets();

	public abstract IEnumerable<DataSet> GetDataSets();

	public abstract void DestroyAllDataSets(bool destroyTrackables);
}
public class BGRenderingBehaviour : MonoBehaviour
{
	public Camera Camera;

	private QCARRenderer.VideoTextureInfo mTextureInfo;

	private ScreenOrientation mScreenOrientation;

	private int mScreenWidth;

	private int mScreenHeight;

	private bool mFlipHorizontally;

	public void CheckAndSetActive(bool isActive)
	{
	}

	public void SetTexture(Texture texture)
	{
	}

	public void SetFlipHorizontally(bool flip)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private Mesh CreateVideoMesh()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void PositionVideoMesh()
	{
	}

	private bool ShouldFitWidth()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class CameraDeviceImpl : CameraDevice
{
	private Dictionary<Image.PIXEL_FORMAT, Image> mCameraImages;

	private static WebCamImpl mWebCam;

	private bool mCameraReady;

	private bool mIsDirty;

	public WebCamImpl WebCam
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool CameraReady
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool Init(CameraDirection cameraDirection)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Deinit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Stop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override VideoModeData GetVideoMode(CameraDeviceMode mode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool SelectVideoMode(CameraDeviceMode mode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool SetFlashTorchMode(bool on)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool SetFocusMode(FocusMode mode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool SetFrameFormat(Image.PIXEL_FORMAT format, bool enabled)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override Image GetCameraImage(Image.PIXEL_FORMAT format)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Dictionary<Image.PIXEL_FORMAT, Image> GetAllImages()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool IsDirty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ResetDirtyFlag()
	{
	}

	private int InitCameraDevice(int camera)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private int DeinitCameraDevice()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private int StartCameraDevice()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private int StopCameraDevice()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class CloudRecoImageTargetImpl : TrackableImpl, ImageTarget, Trackable
{
	private readonly Vector2 mSize;

	public ImageTargetType ImageTargetType
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public CloudRecoImageTargetImpl(string name, int id, Vector2 size)
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
}
public class DataSetImpl : DataSet
{
	private IntPtr mDataSetPtr;

	private string mPath;

	private StorageType mStorageType;

	private readonly Dictionary<int, Trackable> mTrackablesDict;

	public IntPtr DataSetPtr
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override string Path
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override StorageType FileStorageType
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public DataSetImpl(IntPtr dataSetPtr)
	{
	}

	public static bool ExistsImpl(string path, StorageType storageType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Load(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Load(string path, StorageType storageType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override IEnumerable<Trackable> GetTrackables()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, string gameObjectName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, GameObject gameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Destroy(Trackable trackable, bool destroyGameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool HasReachedTrackableLimit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Contains(Trackable trackable)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void DestroyAllTrackables(bool destroyGameObject)
	{
	}

	private void CreateImageTargets()
	{
	}

	private void CreateMultiTargets()
	{
	}
}
public interface IEditorDataSetTrackableBehaviour : IEditorTrackableBehaviour
{
	string DataSetName { get; }

	string DataSetPath { get; }

	bool SetDataSetPath(string dataSetPath);
}
public interface IEditorImageTargetBehaviour : IEditorDataSetTrackableBehaviour, IEditorTrackableBehaviour
{
	float AspectRatio { get; }

	ImageTargetType ImageTargetType { get; }

	bool SetAspectRatio(float aspectRatio);

	bool SetImageTargetType(ImageTargetType imageTargetType);

	Vector2 GetSize();

	void InitializeImageTarget(ImageTarget imageTarget);

	void CreateMissingVirtualButtonBehaviours();

	bool TryGetVirtualButtonBehaviourByID(int id, out VirtualButtonBehaviour virtualButtonBehaviour);

	void AssociateExistingVirtualButtonBehaviour(VirtualButtonBehaviour virtualButtonBehaviour);
}
public interface IEditorMarkerBehaviour : IEditorTrackableBehaviour
{
	int MarkerID { get; }

	bool SetMarkerID(int markerID);

	void InitializeMarker(Marker marker);
}
public interface IEditorMultiTargetBehaviour : IEditorDataSetTrackableBehaviour, IEditorTrackableBehaviour
{
	void InitializeMultiTarget(MultiTarget multiTarget);
}
public interface IEditorTrackableBehaviour
{
	string TrackableName { get; }

	Trackable Trackable { get; }

	Vector3 PreviousScale { get; }

	bool PreserveChildSize { get; }

	bool InitializedInEditor { get; }

	bool enabled { get; set; }

	Transform transform { get; }

	GameObject gameObject { get; }

	Renderer renderer { get; }

	bool CorrectScale();

	bool SetNameForTrackable(string name);

	bool SetPreviousScale(Vector3 previousScale);

	bool SetPreserveChildSize(bool preserveChildSize);

	bool SetInitializedInEditor(bool initializedInEditor);

	void UnregisterTrackable();
}
public interface IEditorVirtualButtonBehaviour
{
	string VirtualButtonName { get; }

	VirtualButton.Sensitivity SensitivitySetting { get; }

	Matrix4x4 PreviousTransform { get; }

	GameObject PreviousParent { get; }

	bool UnregisterOnDestroy { get; set; }

	bool HasUpdatedPose { get; }

	bool enabled { get; set; }

	Transform transform { get; }

	GameObject gameObject { get; }

	Renderer renderer { get; }

	bool SetVirtualButtonName(string virtualButtonName);

	bool SetSensitivitySetting(VirtualButton.Sensitivity sensibility);

	bool SetPreviousTransform(Matrix4x4 transform);

	bool SetPreviousParent(GameObject parent);

	void InitializeVirtualButton(VirtualButton virtualButton);

	bool SetPosAndScaleFromButtonArea(Vector2 topLeft, Vector2 bottomRight);

	bool UpdatePose();
}
public class ImageImpl : Image
{
	private int mWidth;

	private int mHeight;

	private int mStride;

	private int mBufferWidth;

	private int mBufferHeight;

	private PIXEL_FORMAT mPixelFormat;

	private byte[] mData;

	private IntPtr mUnmanagedData;

	private bool mDataSet;

	public override int Width
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override int Height
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override int Stride
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override int BufferWidth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override int BufferHeight
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override PIXEL_FORMAT PixelFormat
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override byte[] Pixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public IntPtr UnmanagedData
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	~ImageImpl()
	{
	}

	public override bool IsValid()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void CopyPixelsFromUnmanagedBuffer()
	{
	}
}
public class ImageTargetBuilderImpl : ImageTargetBuilder
{
	private TrackableSource mTrackableSource;

	public override bool Build(string targetName, float sceenSizeWidth)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void StartScan()
	{
	}

	public override void StopScan()
	{
	}

	public override FrameQuality GetFrameQuality()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override TrackableSource GetTrackableSource()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
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
public class ImageTrackerImpl : ImageTracker
{
	private List<DataSetImpl> mActiveDataSets;

	private List<DataSet> mDataSets;

	private ImageTargetBuilder mImageTargetBuilder;

	private TargetFinder mTargetFinder;

	public override ImageTargetBuilder ImageTargetBuilder
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override TargetFinder TargetFinder
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void Stop()
	{
	}

	public override DataSet CreateDataSet()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool DestroyDataSet(DataSet dataSet, bool destroyTrackables)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool ActivateDataSet(DataSet dataSet)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool DeactivateDataSet(DataSet dataSet)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override IEnumerable<DataSet> GetActiveDataSets()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override IEnumerable<DataSet> GetDataSets()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void DestroyAllDataSets(bool destroyTrackables)
	{
	}
}
public class MarkerImpl : TrackableImpl, Marker, Trackable
{
	private readonly float mSize;

	public int MarkerID
	{
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public MarkerImpl(string name, int id, float size, int markerID)
	{
	}

	public float GetSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class MarkerTrackerImpl : MarkerTracker
{
	private readonly Dictionary<int, Marker> mMarkerDict;

	public override bool Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void Stop()
	{
	}

	public override MarkerBehaviour CreateMarker(int markerID, string trackableName, float size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool DestroyMarker(Marker marker, bool destroyGameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override IEnumerable<Marker> GetMarkers()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override Marker GetMarkerByMarkerID(int markerID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Marker InternalCreateMarker(int markerID, string name, float size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void DestroyAllMarkers(bool destroyGameObject)
	{
	}

	private int RegisterMarker(int markerID, string trackableName, float size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class MultiTargetImpl : TrackableImpl, MultiTarget, Trackable
{
	public MultiTargetImpl(string name, int id)
	{
	}
}
public class NullWebCamTexAdaptor : WebCamTexAdaptor
{
	private const string ERROR_MSG = "No camera connected!\nTo run your application using Play Mode, please connect a webcam to your computer.";

	private readonly Texture2D mTexture;

	private bool mPseudoPlaying;

	private readonly double mMsBetweenFrames;

	private DateTime mLastFrame;

	public override bool DidUpdateThisFrame
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool IsPlaying
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Texture Texture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public NullWebCamTexAdaptor(int requestedFPS, QCARRenderer.Vec2I requestedTextureSize)
	{
	}

	public override void Play()
	{
	}

	public override void Stop()
	{
	}
}
internal struct QCARMacros
{
	public const string PLATFORM_DLL = "__Internal";
}
public class QCARManagerImpl : QCARManager
{
	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct PoseData
	{
		[MarshalAs((UnmanagedType)30, SizeConst = 3)]
		public Vector3 position;

		[MarshalAs((UnmanagedType)30, SizeConst = 4)]
		public Quaternion orientation;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct TrackableResultData
	{
		public PoseData pose;

		public TrackableBehaviour.Status status;

		public int id;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct VirtualButtonData
	{
		public int id;

		public int isPressed;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	private struct ImageHeaderData
	{
		public int width;

		public int height;

		public int stride;

		public int bufferWidth;

		public int bufferHeight;

		public int format;

		public int reallocate;

		public int updated;

		public IntPtr data;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	private struct FrameState
	{
		public int numTrackableResults;

		public int numVirtualButtonResults;

		public int frameIndex;

		public IntPtr trackableDataArray;

		public IntPtr vbDataArray;
	}

	private QCARBehaviour.WorldCenterMode mWorldCenterMode;

	private TrackableBehaviour mWorldCenter;

	private Camera mARCamera;

	private TrackableResultData[] mTrackableResultDataArray;

	private LinkedList<int> mTrackableFoundQueue;

	private IntPtr mImageHeaderData;

	private int mNumImageHeaders;

	private bool mDrawVideobackground;

	private int mInjectedFrameIdx;

	private IntPtr mLastProcessedFrameStatePtr;

	private bool mInitialized;

	public override QCARBehaviour.WorldCenterMode WorldCenterMode
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override TrackableBehaviour WorldCenter
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override Camera ARCamera
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override bool DrawVideoBackground
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public override bool Initialized
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool Init()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Update(ScreenOrientation counterRotation)
	{
	}

	public override void Deinit()
	{
	}

	private void InitializeTrackableContainer(int numTrackableResults)
	{
	}

	private void UpdateTrackers(FrameState frameState)
	{
	}

	private void UpdateTrackablesEditor()
	{
	}

	private void UpdateImageContainer()
	{
	}

	private void UpdateCameraFrame()
	{
	}

	private void InjectCameraFrame()
	{
	}
}
public class QCARRendererImpl : QCARRenderer
{
	private VideoBGCfgData mVideoBGConfig;

	private bool mVideoBGConfigSet;

	public override bool DrawVideoBackground
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public Texture2D VideoBackgroundForEmulator
	{
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override VideoBGCfgData GetVideoBackgroundConfig()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void ClearVideoBackgroundConfig()
	{
	}

	public override void SetVideoBackgroundConfig(VideoBGCfgData config)
	{
	}

	public override bool SetVideoBackgroundTexture(Texture2D texture)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool IsVideoBackgroundInfoAvailable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override VideoTextureInfo GetVideoTextureInfo()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public static class QCARUnityImpl
{
	public static QCARUnity.InitError CheckInitializationError()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool IsRendererDirty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool SetHint(QCARUnity.QCARHint hint, int value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool RequiresAlpha()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Matrix4x4 GetProjectionGL(float nearPlane, float farPlane, ScreenOrientation screenOrientation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void SetUnityVersion(string path, bool setNative = false)
	{
	}
}
public class StateManagerImpl : StateManager
{
	private readonly Dictionary<int, TrackableBehaviour> mTrackableBehaviours;

	private readonly List<TrackableBehaviour> mActiveTrackableBehaviours;

	public override IEnumerable<TrackableBehaviour> GetActiveTrackableBehaviours()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override IEnumerable<TrackableBehaviour> GetTrackableBehaviours()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void AssociateMarkerBehaviours()
	{
	}

	public void AssociateTrackableBehavioursForDataSet(DataSet dataSet)
	{
	}

	public void ClearTrackableBehaviours()
	{
	}

	public ImageTargetBehaviour FindOrCreateImageTargetBehaviourForTrackable(ImageTarget trackable, GameObject gameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public ImageTargetBehaviour FindOrCreateImageTargetBehaviourForTrackable(ImageTarget trackable, GameObject gameObject, DataSet dataSet)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public MarkerBehaviour CreateNewMarkerBehaviourForMarker(Marker trackable, string gameObjectName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public MarkerBehaviour CreateNewMarkerBehaviourForMarker(Marker trackable, GameObject gameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void DestroyTrackableBehavioursForTrackable(Trackable trackable, bool destroyGameObjects = true)
	{
	}

	public void SetTrackableBehavioursForTrackableToNotFound(Trackable trackable)
	{
	}

	public void EnableTrackableBehavioursForTrackable(Trackable trackable, bool enabled)
	{
	}

	public void RemoveDisabledTrackablesFromQueue(ref LinkedList<int> trackableIDs)
	{
	}

	public void UpdateCameraPose(Camera arCamera, QCARManagerImpl.TrackableResultData[] trackableResultDataArray, int originTrackableID)
	{
	}

	public void UpdateTrackablePoses(Camera arCamera, QCARManagerImpl.TrackableResultData[] trackableResultDataArray, int originTrackableID)
	{
	}

	public void UpdateVirtualButtons(int numVirtualButtons, IntPtr virtualButtonPtr)
	{
	}

	private void AssociateVirtualButtonBehaviours(VirtualButtonBehaviour[] vbBehaviours, DataSet dataSet)
	{
	}

	private void CreateMissingDataSetTrackableBehaviours(DataSet dataSet)
	{
	}

	private ImageTargetBehaviour CreateImageTargetBehaviour(ImageTarget imageTarget)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private MultiTargetBehaviour CreateMultiTargetBehaviour(MultiTarget multiTarget)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void InitializeMarkerBehaviour(MarkerBehaviour markerBehaviour, Marker marker)
	{
	}

	private void PositionCamera(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}

	private void PositionTrackable(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}
}
public class TargetFinderImpl : TargetFinder
{
	[StructLayout((LayoutKind)0, Pack = 1)]
	private struct TargetFinderState
	{
		public int IsRequesting;

		[MarshalAs((UnmanagedType)31)]
		public UpdateState UpdateState;

		public int ResultCount;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	private struct InternalTargetSearchResult
	{
		public IntPtr TargetNamePtr;

		public IntPtr UniqueTargetIdPtr;

		public float TargetSize;

		public IntPtr MetaDataPtr;

		public IntPtr TargetSearchResultPtr;

		public byte TrackingRating;
	}

	private IntPtr mTargetFinderStatePtr;

	private TargetFinderState mTargetFinderState;

	private List<TargetSearchResult> mNewResults;

	private Dictionary<int, ImageTarget> mImageTargets;

	~TargetFinderImpl()
	{
	}

	public override bool StartInit(string userAuth, string secretAuth)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override InitState GetInitState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Deinit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool StartRecognition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool Stop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void SetUIScanlineColor(Color color)
	{
	}

	public override void SetUIPointColor(Color color)
	{
	}

	public override bool IsRequesting()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override UpdateState Update()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override IEnumerable<TargetSearchResult> GetResults()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override ImageTargetBehaviour EnableTracking(TargetSearchResult result, string gameObjectName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override ImageTargetBehaviour EnableTracking(TargetSearchResult result, GameObject gameObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void ClearTrackables(bool destroyGameObjects = true)
	{
	}

	public override IEnumerable<ImageTarget> GetImageTargets()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class TextureRenderer
{
	private Camera mTextureBufferCamera;

	private int mTextureWidth;

	private int mTextureHeight;

	public int Width
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int Height
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public TextureRenderer(Texture textureToRender, int renderTextureLayer, QCARRenderer.Vec2I requestedTextureSize)
	{
	}

	public RenderTexture Render()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Destroy()
	{
	}
}
public abstract class TrackableImpl : Trackable
{
	public TrackableType Type
	{
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public int ID
	{
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	protected TrackableImpl(string name, int id)
	{
	}
}
public class TrackableSourceImpl : TrackableSource
{
	public IntPtr TrackableSourcePtr
	{
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public TrackableSourceImpl(IntPtr trackableSourcePtr)
	{
	}
}
public class TrackerManagerImpl : TrackerManager
{
	private ImageTracker mImageTracker;

	private MarkerTracker mMarkerTracker;

	private StateManager mStateManager;

	public override Tracker GetTracker(Tracker.Type trackerType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override Tracker InitTracker(Tracker.Type trackerType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool DeinitTracker(Tracker.Type trackerType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override StateManager GetStateManager()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class VirtualButtonImpl : VirtualButton
{
	private string mName;

	private int mID;

	private RectangleData mArea;

	private bool mIsEnabled;

	private ImageTarget mParentImageTarget;

	private DataSetImpl mParentDataSet;

	public override string Name
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override int ID
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool Enabled
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override RectangleData Area
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public VirtualButtonImpl(string name, int id, RectangleData area, ImageTarget imageTarget, DataSet dataSet)
	{
	}

	public override bool SetArea(RectangleData area)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool SetSensitivity(Sensitivity sensitivity)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override bool SetEnabled(bool enabled)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class WebCamImpl
{
	private struct BufferedFrame
	{
		public int frameIndex;

		public RenderTexture frame;
	}

	private readonly Camera mARCamera;

	private readonly BGRenderingBehaviour mBgRenderingTexBehaviour;

	private readonly WebCamTexAdaptor mWebCamTexture;

	private CameraDevice.VideoModeData mVideoModeData;

	private QCARRenderer.VideoTextureInfo mVideoTextureInfo;

	private TextureRenderer mTextureRenderer;

	private Texture2D mBufferReadTexture;

	private Rect mReadPixelsRect;

	private readonly WebCamProfile.ProfileData mWebCamProfile;

	private readonly bool mFlipHorizontally;

	private int mLastScreenWidth;

	private int mLastScreenHeight;

	private readonly Queue<BufferedFrame> mBufferedFrames;

	private int mLastFrameIdx;

	private readonly int mRenderTextureLayer;

	public bool DidUpdateThisFrame
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsPlaying
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int ActualWidth
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int ActualHeight
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsTextureSizeAvailable
	{
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool FlipHorizontally
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public QCARRenderer.Vec2I ResampledTextureSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public WebCamImpl(Camera arCamera, Camera backgroundCamera, int renderTextureLayer, string webcamDeviceName, bool flipHorizontally)
	{
	}

	private void RenderFrame(RenderTexture frameToDraw)
	{
	}

	public void StartCamera()
	{
	}

	public void StopCamera()
	{
	}

	public Color32[] GetPixels32AndBufferFrame(int frameIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void SetFrameIndex(int frameIndex)
	{
	}

	public CameraDevice.VideoModeData GetVideoMode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public QCARRenderer.VideoTextureInfo GetVideoTextureInfo()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool IsRendererDirty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class WebCamProfile
{
	public struct ProfileData
	{
		public QCARRenderer.Vec2I RequestedTextureSize;

		public QCARRenderer.Vec2I ResampledTextureSize;

		public int RequestedFPS;
	}

	private ProfileData mDefaultProfile;

	private readonly Dictionary<string, ProfileData> mProfiles;

	public ProfileData Default
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ProfileData GetProfile(string webcamName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool ProfileAvailable(string webcamName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void LoadAndParseProfiles()
	{
	}
}
public abstract class WebCamTexAdaptor
{
	public abstract bool DidUpdateThisFrame { get; }

	public abstract bool IsPlaying { get; }

	public abstract Texture Texture { get; }

	public abstract void Play();

	public abstract void Stop();
}
public class WebCamTexAdaptorImpl : WebCamTexAdaptor
{
	private WebCamTexture mWebCamTexture;

	public override bool DidUpdateThisFrame
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool IsPlaying
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override Texture Texture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public WebCamTexAdaptorImpl(string deviceName, int requestedFPS, QCARRenderer.Vec2I requestedTextureSize)
	{
	}

	public override void Play()
	{
	}

	public override void Stop()
	{
	}
}
public interface IQCARWrapper
{
	int CameraDeviceInitCamera(int camera);

	int CameraDeviceDeinitCamera();

	int CameraDeviceStartCamera();

	int CameraDeviceStopCamera();

	int CameraDeviceGetNumVideoModes();

	void CameraDeviceGetVideoMode(int idx, [In][Out] IntPtr videoMode);

	int CameraDeviceSelectVideoMode(int idx);

	int CameraDeviceSetFlashTorchMode(int on);

	int CameraDeviceSetFocusMode(int focusMode);

	int CameraDeviceSetCameraConfiguration(int width, int height);

	int QcarSetFrameFormat(int format, int enabled);

	int DataSetExists(string relativePath, int storageType);

	int DataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr);

	int DataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr);

	int DataSetGetTrackablesOfType(int trackableType, [In][Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr);

	int DataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength);

	int DataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In][Out] IntPtr trackableData);

	int DataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId);

	int DataSetHasReachedTrackableLimit(IntPtr dataSetPtr);

	int ImageTargetBuilderBuild(string targetName, float sceenSizeWidth);

	void ImageTargetBuilderStartScan();

	void ImageTargetBuilderStopScan();

	int ImageTargetBuilderGetFrameQuality();

	IntPtr ImageTargetBuilderGetTrackableSource();

	int ImageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData);

	int ImageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName);

	int VirtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName);

	int ImageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName);

	int ImageTargetGetVirtualButtons([In][Out] IntPtr virtualButtonDataArray, [In][Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName);

	int ImageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength);

	int ImageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size);

	int ImageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size);

	int ImageTrackerStart();

	void ImageTrackerStop();

	IntPtr ImageTrackerCreateDataSet();

	int ImageTrackerDestroyDataSet(IntPtr dataSetPtr);

	int ImageTrackerActivateDataSet(IntPtr dataSetPtr);

	int ImageTrackerDeactivateDataSet(IntPtr dataSetPtr);

	int MarkerTrackerStart();

	void MarkerTrackerStop();

	int MarkerTrackerCreateMarker(int id, string trackableName, float size);

	int MarkerTrackerDestroyMarker(int trackableId);

	void InitFrameState([In][Out] IntPtr frameIndex);

	void DeinitFrameState([In][Out] IntPtr frameIndex);

	void UpdateQCAR([In][Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In][Out] IntPtr frameIndex, int screenOrientation);

	int QcarGetBufferSize(int width, int height, int format);

	void QcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally);

	void RendererSetVideoBackgroundCfg([In][Out] IntPtr bgCfg);

	void RendererGetVideoBackgroundCfg([In][Out] IntPtr bgCfg);

	void RendererGetVideoBackgroundTextureInfo([In][Out] IntPtr texInfo);

	int RendererSetVideoBackgroundTextureID(int textureID);

	int RendererIsVideoBackgroundTextureInfoAvailable();

	int GetInitErrorCode();

	int IsRendererDirty();

	int QcarSetHint(int hint, int value);

	int QcarRequiresAlpha();

	int GetProjectionGL(float nearClip, float farClip, [In][Out] IntPtr projMatrix, int screenOrientation);

	void SetUnityVersion(int major, int minor, int change);

	int TargetFinderStartInit(string userKey, string secretKey);

	int TargetFinderGetInitState();

	int TargetFinderDeinit();

	int TargetFinderStartRecognition();

	int TargetFinderStop();

	void TargetFinderSetUIScanlineColor(float r, float g, float b);

	void TargetFinderSetUIPointColor(float r, float g, float b);

	void TargetFinderUpdate([In][Out] IntPtr targetFinderState);

	int TargetFinderGetResults([In][Out] IntPtr searchResultArray, int searchResultArrayLength);

	int TargetFinderEnableTracking(IntPtr searchResult, [In][Out] IntPtr trackableData);

	void TargetFinderGetImageTargets([In][Out] IntPtr trackableIdArray, int trackableIdArrayLength);

	void TargetFinderClearTrackables();

	int TrackerManagerInitTracker(int trackerType);

	int TrackerManagerDeinitTracker(int trackerType);

	int VirtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled);

	int VirtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity);

	int VirtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData);

	int GetSurfaceOrientation();

	int QcarDeinit();
}
public class QCARNativeWrapper : IQCARWrapper
{
	public int CameraDeviceInitCamera(int camera)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceDeinitCamera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceStartCamera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceStopCamera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceGetNumVideoModes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void CameraDeviceGetVideoMode(int idx, [In][Out] IntPtr videoMode)
	{
	}

	public int CameraDeviceSelectVideoMode(int idx)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceSetFlashTorchMode(int on)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceSetFocusMode(int focusMode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceSetCameraConfiguration(int width, int height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarSetFrameFormat(int format, int enabled)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetExists(string relativePath, int storageType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetGetTrackablesOfType(int trackableType, [In][Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In][Out] IntPtr trackableData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetHasReachedTrackableLimit(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetBuilderBuild(string targetName, float sceenSizeWidth)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ImageTargetBuilderStartScan()
	{
	}

	public void ImageTargetBuilderStopScan()
	{
	}

	public int ImageTargetBuilderGetFrameQuality()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public IntPtr ImageTargetBuilderGetTrackableSource()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetVirtualButtons([In][Out] IntPtr virtualButtonDataArray, [In][Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerStart()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ImageTrackerStop()
	{
	}

	public IntPtr ImageTrackerCreateDataSet()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerDestroyDataSet(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerActivateDataSet(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerDeactivateDataSet(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int MarkerTrackerStart()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void MarkerTrackerStop()
	{
	}

	public int MarkerTrackerCreateMarker(int id, string trackableName, float size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int MarkerTrackerDestroyMarker(int trackableId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void InitFrameState([In][Out] IntPtr frameIndex)
	{
	}

	public void DeinitFrameState([In][Out] IntPtr frameIndex)
	{
	}

	public void UpdateQCAR([In][Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In][Out] IntPtr frameIndex, int screenOrientation)
	{
	}

	public int QcarGetBufferSize(int width, int height, int format)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void QcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally)
	{
	}

	public void RendererSetVideoBackgroundCfg([In][Out] IntPtr bgCfg)
	{
	}

	public void RendererGetVideoBackgroundCfg([In][Out] IntPtr bgCfg)
	{
	}

	public void RendererGetVideoBackgroundTextureInfo([In][Out] IntPtr texInfo)
	{
	}

	public int RendererSetVideoBackgroundTextureID(int textureID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int RendererIsVideoBackgroundTextureInfoAvailable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int GetInitErrorCode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int IsRendererDirty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarSetHint(int hint, int value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarRequiresAlpha()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int GetProjectionGL(float nearClip, float farClip, [In][Out] IntPtr projMatrix, int screenOrientation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void SetUnityVersion(int major, int minor, int change)
	{
	}

	public int TargetFinderStartInit(string userKey, string secretKey)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderGetInitState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderDeinit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderStartRecognition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderStop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void TargetFinderSetUIScanlineColor(float r, float g, float b)
	{
	}

	public void TargetFinderSetUIPointColor(float r, float g, float b)
	{
	}

	public void TargetFinderUpdate([In][Out] IntPtr targetFinderState)
	{
	}

	public int TargetFinderGetResults([In][Out] IntPtr searchResultArray, int searchResultArrayLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderEnableTracking(IntPtr searchResult, [In][Out] IntPtr trackableData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void TargetFinderGetImageTargets([In][Out] IntPtr trackableIdArray, int trackableIdArrayLength)
	{
	}

	public void TargetFinderClearTrackables()
	{
	}

	public int TrackerManagerInitTracker(int trackerType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TrackerManagerDeinitTracker(int trackerType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int GetSurfaceOrientation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarDeinit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern int cameraDeviceInitCamera(int camera);

	[DllImport("__Internal")]
	private static extern int cameraDeviceDeinitCamera();

	[DllImport("__Internal")]
	private static extern int cameraDeviceStartCamera();

	[DllImport("__Internal")]
	private static extern int cameraDeviceStopCamera();

	[DllImport("__Internal")]
	private static extern int cameraDeviceGetNumVideoModes();

	[DllImport("__Internal")]
	private static extern void cameraDeviceGetVideoMode(int idx, [In][Out] IntPtr videoMode);

	[DllImport("__Internal")]
	private static extern int cameraDeviceSelectVideoMode(int idx);

	[DllImport("__Internal")]
	private static extern int cameraDeviceSetFlashTorchMode(int on);

	[DllImport("__Internal")]
	private static extern int cameraDeviceSetFocusMode(int focusMode);

	[DllImport("__Internal")]
	private static extern int qcarSetFrameFormat(int format, int enabled);

	[DllImport("__Internal")]
	private static extern int dataSetExists(string relativePath, int storageType);

	[DllImport("__Internal")]
	private static extern int dataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int dataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int dataSetGetTrackablesOfType(int trackableType, [In][Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int dataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength);

	[DllImport("__Internal")]
	private static extern int dataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In][Out] IntPtr trackableData);

	[DllImport("__Internal")]
	private static extern int dataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId);

	[DllImport("__Internal")]
	private static extern int dataSetHasReachedTrackableLimit(IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int imageTargetBuilderBuild(string targetName, float sceenSizeWidth);

	[DllImport("__Internal")]
	private static extern void imageTargetBuilderStartScan();

	[DllImport("__Internal")]
	private static extern void imageTargetBuilderStopScan();

	[DllImport("__Internal")]
	private static extern int imageTargetBuilderGetFrameQuality();

	[DllImport("__Internal")]
	private static extern IntPtr imageTargetBuilderGetTrackableSource();

	[DllImport("__Internal")]
	private static extern int imageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData);

	[DllImport("__Internal")]
	private static extern int imageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName);

	[DllImport("__Internal")]
	private static extern int virtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName);

	[DllImport("__Internal")]
	private static extern int imageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName);

	[DllImport("__Internal")]
	private static extern int imageTargetGetVirtualButtons([In][Out] IntPtr virtualButtonDataArray, [In][Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName);

	[DllImport("__Internal")]
	private static extern int imageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength);

	[DllImport("__Internal")]
	private static extern int imageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size);

	[DllImport("__Internal")]
	private static extern int imageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size);

	[DllImport("__Internal")]
	private static extern int imageTrackerStart();

	[DllImport("__Internal")]
	private static extern void imageTrackerStop();

	[DllImport("__Internal")]
	private static extern IntPtr imageTrackerCreateDataSet();

	[DllImport("__Internal")]
	private static extern int imageTrackerDestroyDataSet(IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int imageTrackerActivateDataSet(IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int imageTrackerDeactivateDataSet(IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int markerTrackerStart();

	[DllImport("__Internal")]
	private static extern void markerTrackerStop();

	[DllImport("__Internal")]
	private static extern int markerTrackerCreateMarker(int id, string trackableName, float size);

	[DllImport("__Internal")]
	private static extern int markerTrackerDestroyMarker(int trackableId);

	[DllImport("__Internal")]
	private static extern void initFrameState([In][Out] IntPtr frameIndex);

	[DllImport("__Internal")]
	private static extern void deinitFrameState([In][Out] IntPtr frameIndex);

	[DllImport("__Internal")]
	private static extern void updateQCAR([In][Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In][Out] IntPtr frameIndex, int screenOrientation);

	[DllImport("__Internal")]
	private static extern int qcarGetBufferSize(int width, int height, int format);

	private static void qcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally)
	{
	}

	[DllImport("__Internal")]
	private static extern void rendererSetVideoBackgroundCfg([In][Out] IntPtr bgCfg);

	[DllImport("__Internal")]
	private static extern void rendererGetVideoBackgroundCfg([In][Out] IntPtr bgCfg);

	[DllImport("__Internal")]
	private static extern void rendererGetVideoBackgroundTextureInfo([In][Out] IntPtr texInfo);

	[DllImport("__Internal")]
	private static extern int rendererSetVideoBackgroundTextureID(int textureID);

	[DllImport("__Internal")]
	private static extern int rendererIsVideoBackgroundTextureInfoAvailable();

	[DllImport("__Internal")]
	private static extern int getInitErrorCode();

	[DllImport("__Internal")]
	private static extern int isRendererDirty();

	[DllImport("__Internal")]
	private static extern int qcarSetHint(int hint, int value);

	[DllImport("__Internal")]
	private static extern int qcarRequiresAlpha();

	[DllImport("__Internal")]
	private static extern int getProjectionGL(float nearClip, float farClip, [In][Out] IntPtr projMatrix, int screenOrientation);

	[DllImport("__Internal")]
	private static extern void setUnityVersion(int major, int minor, int change);

	[DllImport("__Internal")]
	private static extern int targetFinderStartInit(string userKey, string secretKey);

	[DllImport("__Internal")]
	private static extern int targetFinderGetInitState();

	[DllImport("__Internal")]
	private static extern int targetFinderDeinit();

	[DllImport("__Internal")]
	private static extern int targetFinderStartRecognition();

	[DllImport("__Internal")]
	private static extern int targetFinderStop();

	[DllImport("__Internal")]
	private static extern void targetFinderSetUIScanlineColor(float r, float g, float b);

	[DllImport("__Internal")]
	private static extern void targetFinderSetUIPointColor(float r, float g, float b);

	[DllImport("__Internal")]
	private static extern void targetFinderUpdate([In][Out] IntPtr targetFinderState);

	[DllImport("__Internal")]
	private static extern int targetFinderGetResults([In][Out] IntPtr searchResultArray, int searchResultArrayLength);

	[DllImport("__Internal")]
	private static extern int targetFinderEnableTracking(IntPtr searchResult, [In][Out] IntPtr trackableData);

	[DllImport("__Internal")]
	private static extern void targetFinderGetImageTargets([In][Out] IntPtr trackableIdArray, int trackableIdArrayLength);

	[DllImport("__Internal")]
	private static extern void targetFinderClearTrackables();

	[DllImport("__Internal")]
	private static extern int trackerManagerInitTracker(int trackerType);

	[DllImport("__Internal")]
	private static extern int trackerManagerDeinitTracker(int trackerType);

	[DllImport("__Internal")]
	private static extern int virtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled);

	[DllImport("__Internal")]
	private static extern int virtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity);

	[DllImport("__Internal")]
	private static extern int virtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData);

	[DllImport("__Internal")]
	private static extern int getSurfaceOrientation();

	[DllImport("__Internal")]
	private static extern int qcarDeinit();
}
public class QCARNullWrapper : IQCARWrapper
{
	public int CameraDeviceInitCamera(int camera)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceDeinitCamera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceStartCamera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceStopCamera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceGetNumVideoModes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void CameraDeviceGetVideoMode(int idx, [In][Out] IntPtr videoMode)
	{
	}

	public int CameraDeviceSelectVideoMode(int idx)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceSetFlashTorchMode(int on)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceSetFocusMode(int focusMode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceSetCameraConfiguration(int width, int height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarSetFrameFormat(int format, int enabled)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetExists(string relativePath, int storageType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetGetTrackablesOfType(int trackableType, [In][Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In][Out] IntPtr trackableData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetHasReachedTrackableLimit(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetBuilderBuild(string targetName, float sceenSizeWidth)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ImageTargetBuilderStartScan()
	{
	}

	public void ImageTargetBuilderStopScan()
	{
	}

	public int ImageTargetBuilderGetFrameQuality()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public IntPtr ImageTargetBuilderGetTrackableSource()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetVirtualButtons([In][Out] IntPtr virtualButtonDataArray, [In][Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerStart()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ImageTrackerStop()
	{
	}

	public IntPtr ImageTrackerCreateDataSet()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerDestroyDataSet(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerActivateDataSet(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerDeactivateDataSet(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int MarkerTrackerStart()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void MarkerTrackerStop()
	{
	}

	public int MarkerTrackerCreateMarker(int id, string trackableName, float size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int MarkerTrackerDestroyMarker(int trackableId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void InitFrameState([In][Out] IntPtr frameIndex)
	{
	}

	public void DeinitFrameState([In][Out] IntPtr frameIndex)
	{
	}

	public void UpdateQCAR([In][Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In][Out] IntPtr frameIndex, int screenOrientation)
	{
	}

	public int QcarGetBufferSize(int width, int height, int format)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void QcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally)
	{
	}

	public void RendererSetVideoBackgroundCfg([In][Out] IntPtr bgCfg)
	{
	}

	public void RendererGetVideoBackgroundCfg([In][Out] IntPtr bgCfg)
	{
	}

	public void RendererGetVideoBackgroundTextureInfo([In][Out] IntPtr texInfo)
	{
	}

	public int RendererSetVideoBackgroundTextureID(int textureID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int RendererIsVideoBackgroundTextureInfoAvailable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int GetInitErrorCode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int IsRendererDirty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarSetHint(int hint, int value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarRequiresAlpha()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int GetProjectionGL(float nearClip, float farClip, [In][Out] IntPtr projMatrix, int screenOrientation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void SetUnityVersion(int major, int minor, int change)
	{
	}

	public int TargetFinderStartInit(string userKey, string secretKey)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderGetInitState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderDeinit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderStartRecognition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderStop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void TargetFinderSetUIScanlineColor(float r, float g, float b)
	{
	}

	public void TargetFinderSetUIPointColor(float r, float g, float b)
	{
	}

	public void TargetFinderUpdate([In][Out] IntPtr targetFinderState)
	{
	}

	public int TargetFinderGetResults([In][Out] IntPtr searchResultArray, int searchResultArrayLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderEnableTracking(IntPtr searchResult, [In][Out] IntPtr trackableData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void TargetFinderGetImageTargets([In][Out] IntPtr trackableIdArray, int trackableIdArrayLength)
	{
	}

	public void TargetFinderClearTrackables()
	{
	}

	public int TrackerManagerInitTracker(int trackerType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TrackerManagerDeinitTracker(int trackerType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int GetSurfaceOrientation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarDeinit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public static class QCARWrapper
{
	private static IQCARWrapper sWrapper;

	public static IQCARWrapper Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static void Create()
	{
	}
}
public interface Marker : Trackable
{
	int MarkerID { get; }

	float GetSize();
}
public class MarkerBehaviour : TrackableBehaviour, IEditorMarkerBehaviour, IEditorTrackableBehaviour
{
	[HideInInspector]
	[SerializeField]
	private int mMarkerID;

	private Marker mMarker;

	int IEditorMarkerBehaviour.MarkerID
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Marker Marker
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorMarkerBehaviour.SetMarkerID(int markerID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	void IEditorMarkerBehaviour.InitializeMarker(Marker marker)
	{
	}

	protected override void InternalUnregisterTrackable()
	{
	}

	protected override bool CorrectScaleImpl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public abstract class MarkerTracker : Tracker
{
	public abstract MarkerBehaviour CreateMarker(int markerID, string trackableName, float size);

	public abstract bool DestroyMarker(Marker marker, bool destroyGameObject);

	public abstract IEnumerable<Marker> GetMarkers();

	public abstract Marker GetMarkerByMarkerID(int markerID);

	public abstract void DestroyAllMarkers(bool destroyGameObject);
}
public class MaskOutBehaviour : MonoBehaviour
{
	public Material maskMaterial;

	private void Start()
	{
	}
}
public interface MultiTarget : Trackable
{
}
public class MultiTargetBehaviour : DataSetTrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorMultiTargetBehaviour, IEditorTrackableBehaviour
{
	private MultiTarget mMultiTarget;

	public MultiTarget MultiTarget
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	void IEditorMultiTargetBehaviour.InitializeMultiTarget(MultiTarget multiTarget)
	{
	}

	protected override void InternalUnregisterTrackable()
	{
	}
}
[RequireComponent(typeof(Camera))]
public class QCARBehaviour : MonoBehaviour
{
	public enum WorldCenterMode
	{
		USER,
		AUTO,
		NONE
	}

	private enum CameraState
	{
		UNINITED,
		DEVICE_INITED,
		RENDERING_INITED
	}

	[SerializeField]
	protected CameraDevice.CameraDeviceMode CameraDeviceModeSetting;

	[SerializeField]
	private int MaxSimultaneousImageTargets;

	[SerializeField]
	private bool SynchronousVideo;

	[SerializeField]
	[HideInInspector]
	protected WorldCenterMode mWorldCenterMode;

	[HideInInspector]
	[SerializeField]
	private TrackableBehaviour mWorldCenter;

	[SerializeField]
	protected CameraDevice.CameraDirection CameraDirection;

	[SerializeField]
	private QCARRenderer.VideoBackgroundReflection MirrorVideoBackground;

	private List<ITrackerEventHandler> mTrackerEventHandlers;

	private List<IVideoBackgroundEventHandler> mVideoBgEventHandlers;

	private bool mIsInitialized;

	private CameraState mCameraState;

	private Material mClearMaterial;

	private Rect mViewportRect;

	private int mClearBuffers;

	private bool mHasStartedOnce;

	private ScreenOrientation mProjectionOrientation;

	private bool mCachedDrawVideoBackground;

	private CameraClearFlags mCachedCameraClearFlags;

	private Color mCachedCameraBackgroundColor;

	public WorldCenterMode WorldCenterModeSetting
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public TrackableBehaviour WorldCenter
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool VideoBackGroundMirrored
	{
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void RegisterTrackerEventHandler(ITrackerEventHandler trackerEventHandler)
	{
	}

	public bool UnregisterTrackerEventHandler(ITrackerEventHandler trackerEventHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void RegisterVideoBgEventHandler(IVideoBackgroundEventHandler videoBgEventHandler)
	{
	}

	public bool UnregisterVideoBgEventHandler(IVideoBackgroundEventHandler videoBgEventHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void SetWorldCenterMode(WorldCenterMode value)
	{
	}

	public void SetWorldCenter(TrackableBehaviour value)
	{
	}

	public Rect GetViewportRectangle()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public ScreenOrientation GetSurfaceOrientation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ConfigureVideoBackground(bool forceReflectionSetting)
	{
	}

	public void ResetClearBuffers()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnPreRender()
	{
	}

	private void OnPostRender()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void StartQCAR()
	{
	}

	protected virtual void StopQCAR()
	{
	}

	private void ResetCameraClearFlags()
	{
	}

	private void UpdateCameraClearFlags()
	{
	}

	protected void UpdateProjection(ScreenOrientation orientation)
	{
	}
}
public abstract class QCARManager
{
	private static QCARManager sInstance;

	public static QCARManager Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public abstract QCARBehaviour.WorldCenterMode WorldCenterMode { get; set; }

	public abstract TrackableBehaviour WorldCenter { get; set; }

	public abstract Camera ARCamera { get; set; }

	public abstract bool DrawVideoBackground { get; set; }

	public abstract bool Initialized { get; }

	public abstract bool Init();

	public abstract void Deinit();
}
public abstract class QCARRenderer
{
	public enum VideoBackgroundReflection
	{
		DEFAULT,
		ON,
		OFF
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct VideoBGCfgData
	{
		public int enabled;

		public int synchronous;

		public Vec2I position;

		public Vec2I size;

		[MarshalAs((UnmanagedType)31)]
		public VideoBackgroundReflection reflection;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct Vec2I
	{
		public int x;

		public int y;

		public Vec2I(int v1, int v2)
		{
		}
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct VideoTextureInfo
	{
		public Vec2I textureSize;

		public Vec2I imageSize;
	}

	private static QCARRenderer sInstance;

	public static QCARRenderer Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public abstract bool DrawVideoBackground { get; set; }

	public abstract VideoBGCfgData GetVideoBackgroundConfig();

	public abstract void ClearVideoBackgroundConfig();

	public abstract void SetVideoBackgroundConfig(VideoBGCfgData config);

	public abstract bool SetVideoBackgroundTexture(Texture2D texture);

	public abstract bool IsVideoBackgroundInfoAvailable();

	public abstract VideoTextureInfo GetVideoTextureInfo();
}
public class QCARRuntimeUtilities
{
	private enum WebCamUsed
	{
		UNKNOWN,
		TRUE,
		FALSE
	}

	private static ScreenOrientation sScreenOrientation;

	public static ScreenOrientation ScreenOrientation
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsLandscapeOrientation
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool IsPortraitOrientation
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static string StripFileNameFromPath(string fullPath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static string StripExtensionFromPath(string fullPath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void CacheSurfaceOrientation(ScreenOrientation surfaceOrientation)
	{
	}

	public static void ForceDisableTrackables()
	{
	}

	public static bool IsPlayMode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool IsQCAREnabled()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void RestartPlayMode()
	{
	}
}
public static class QCARUnity
{
	public enum InitError
	{
		INIT_DEVICE_NOT_SUPPORTED = -2,
		INIT_ERROR,
		INIT_SUCCESS
	}

	public enum QCARHint
	{
		HINT_MAX_SIMULTANEOUS_IMAGE_TARGETS
	}

	public static InitError CheckInitializationError()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool IsRendererDirty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool SetHint(QCARHint hint, int value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool RequiresAlpha()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static Matrix4x4 GetProjectionGL(float nearPlane, float farPlane, ScreenOrientation screenOrientation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[RequireComponent(typeof(Camera))]
public class SetBGCameraLayerBehaviour : MonoBehaviour
{
	public int CameraLayer;

	private void Awake()
	{
	}

	private void ApplyCameraLayerRecursive(GameObject go)
	{
	}
}
public abstract class StateManager
{
	public abstract IEnumerable<TrackableBehaviour> GetActiveTrackableBehaviours();

	public abstract IEnumerable<TrackableBehaviour> GetTrackableBehaviours();
}
public abstract class TargetFinder
{
	public enum InitState
	{
		INIT_DEFAULT = 0,
		INIT_RUNNING = 1,
		INIT_SUCCESS = 2,
		INIT_ERROR_NO_NETWORK_CONNECTION = -1,
		INIT_ERROR_SERVICE_NOT_AVAILABLE = -2
	}

	public enum UpdateState
	{
		UPDATE_NO_MATCH = 0,
		UPDATE_NO_REQUEST = 1,
		UPDATE_RESULTS_AVAILABLE = 2,
		UPDATE_ERROR_AUTHORIZATION_FAILED = -1,
		UPDATE_ERROR_PROJECT_SUSPENDED = -2,
		UPDATE_ERROR_NO_NETWORK_CONNECTION = -3,
		UPDATE_ERROR_SERVICE_NOT_AVAILABLE = -4,
		UPDATE_ERROR_BAD_FRAME_QUALITY = -5,
		UPDATE_ERROR_UPDATE_SDK = -6,
		UPDATE_ERROR_TIMESTAMP_OUT_OF_RANGE = -7,
		UPDATE_ERROR_REQUEST_TIMEOUT = -8
	}

	public struct TargetSearchResult
	{
		public string TargetName;

		public string UniqueTargetId;

		public float TargetSize;

		public string MetaData;

		public byte TrackingRating;

		public IntPtr TargetSearchResultPtr;
	}

	public abstract bool StartInit(string userAuth, string secretAuth);

	public abstract InitState GetInitState();

	public abstract bool Deinit();

	public abstract bool StartRecognition();

	public abstract bool Stop();

	public abstract void SetUIScanlineColor(Color color);

	public abstract void SetUIPointColor(Color color);

	public abstract bool IsRequesting();

	public abstract UpdateState Update();

	public abstract IEnumerable<TargetSearchResult> GetResults();

	public abstract ImageTargetBehaviour EnableTracking(TargetSearchResult result, string gameObjectName);

	public abstract ImageTargetBehaviour EnableTracking(TargetSearchResult result, GameObject gameObject);

	public abstract void ClearTrackables(bool destroyGameObjects = true);

	public abstract IEnumerable<ImageTarget> GetImageTargets();
}
public enum TrackableType
{
	UNKNOWN_TYPE,
	IMAGE_TARGET,
	MULTI_TARGET,
	MARKER
}
[StructLayout((LayoutKind)0, Pack = 1)]
public struct SimpleTargetData
{
	public int id;
}
public interface Trackable
{
	TrackableType Type { get; }

	string Name { get; }

	int ID { get; }
}
public abstract class TrackableBehaviour : MonoBehaviour, IEditorTrackableBehaviour
{
	public enum Status
	{
		NOT_FOUND = -1,
		UNKNOWN,
		UNDEFINED,
		DETECTED,
		TRACKED
	}

	[HideInInspector]
	[SerializeField]
	protected string mTrackableName;

	[SerializeField]
	[HideInInspector]
	protected Vector3 mPreviousScale;

	[SerializeField]
	[HideInInspector]
	protected bool mPreserveChildSize;

	[HideInInspector]
	[SerializeField]
	protected bool mInitializedInEditor;

	protected Status mStatus;

	protected Trackable mTrackable;

	private List<ITrackableEventHandler> mTrackableEventHandlers;

	Vector3 IEditorTrackableBehaviour.PreviousScale
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorTrackableBehaviour.PreserveChildSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorTrackableBehaviour.InitializedInEditor
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Status CurrentStatus
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Trackable Trackable
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string TrackableName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	bool IEditorTrackableBehaviour.CorrectScale()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorTrackableBehaviour.SetNameForTrackable(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorTrackableBehaviour.SetPreviousScale(Vector3 previousScale)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorTrackableBehaviour.SetPreserveChildSize(bool preserveChildSize)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	bool IEditorTrackableBehaviour.SetInitializedInEditor(bool initializedInEditor)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	void IEditorTrackableBehaviour.UnregisterTrackable()
	{
	}

	public void RegisterTrackableEventHandler(ITrackableEventHandler trackableEventHandler)
	{
	}

	public bool UnregisterTrackableEventHandler(ITrackableEventHandler trackableEventHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void OnTrackerUpdate(Status newStatus)
	{
	}

	protected abstract void InternalUnregisterTrackable();

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual bool CorrectScaleImpl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	virtual bool IEditorTrackableBehaviour.get_enabled()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	virtual void IEditorTrackableBehaviour.set_enabled(bool value)
	{
	}

	virtual Transform IEditorTrackableBehaviour.get_transform()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	virtual GameObject IEditorTrackableBehaviour.get_gameObject()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	virtual Renderer IEditorTrackableBehaviour.get_renderer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public abstract class TrackableSource
{
}
public abstract class Tracker
{
	public enum Type
	{
		IMAGE_TRACKER,
		MARKER_TRACKER
	}

	public abstract bool Start();

	public abstract void Stop();

	protected void PositionCamera(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}

	protected void PositionTrackable(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}
}
public abstract class TrackerManager
{
	private static TrackerManager mInstance;

	public static TrackerManager Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public abstract Tracker GetTracker(Tracker.Type trackerType);

	public abstract Tracker InitTracker(Tracker.Type trackerType);

	public abstract bool DeinitTracker(Tracker.Type trackerType);

	public abstract StateManager GetStateManager();
}
public class TurnOffBehaviour : MonoBehaviour
{
	private void Awake()
	{
	}
}
public class UserDefinedTargetBuildingBehaviour : MonoBehaviour, ITrackerEventHandler
{
	private ImageTracker mImageTracker;

	private ImageTargetBuilder.FrameQuality mLastFrameQuality;

	private bool mCurrentlyScanning;

	private bool mWasScanningBeforeDisable;

	private bool mCurrentlyBuilding;

	private bool mWasBuildingBeforeDisable;

	private bool mOnInitializedCalled;

	private readonly List<IUserDefinedTargetEventHandler> mHandlers;

	public bool StopTrackerWhileScanning;

	public bool StartScanningAutomatically;

	public bool StopScanningWhenFinshedBuilding;

	public void RegisterEventHandler(IUserDefinedTargetEventHandler eventHandler)
	{
	}

	public bool UnregisterEventHandler(IUserDefinedTargetEventHandler eventHandler)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void StartScanning()
	{
	}

	public void BuildNewTarget(string targetName, float sceenSizeWidth)
	{
	}

	public void StopScanning()
	{
	}

	private void SetFrameQuality(ImageTargetBuilder.FrameQuality frameQuality)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnInitialized()
	{
	}

	public void OnTrackablesUpdated()
	{
	}
}
public abstract class VirtualButton
{
	public enum Sensitivity
	{
		HIGH,
		MEDIUM,
		LOW
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct RectangleData
	{
		public float leftTopX;

		public float leftTopY;

		public float rightBottomX;

		public float rightBottomY;
	}

	public const Sensitivity DEFAULT_SENSITIVITY = Sensitivity.LOW;

	public abstract string Name { get; }

	public abstract int ID { get; }

	public abstract bool Enabled { get; }

	public abstract RectangleData Area { get; }

	public abstract bool SetArea(RectangleData area);

	public abstract bool SetSensitivity(Sensitivity sensitivity);

	public abstract bool SetEnabled(bool enabled);
}
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

	virtual bool IEditorVirtualButtonBehaviour.get_enabled()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	virtual void IEditorVirtualButtonBehaviour.set_enabled(bool value)
	{
	}

	virtual Transform IEditorVirtualButtonBehaviour.get_transform()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	virtual GameObject IEditorVirtualButtonBehaviour.get_gameObject()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	virtual Renderer IEditorVirtualButtonBehaviour.get_renderer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[RequireComponent(typeof(Camera))]
public class WebCamBehaviour : MonoBehaviour
{
	public Camera BackgroundCameraPrefab;

	public int RenderTextureLayer;

	[HideInInspector]
	[SerializeField]
	private string mDeviceNameSetInEditor;

	[HideInInspector]
	[SerializeField]
	private bool mFlipHorizontally;

	[SerializeField]
	[HideInInspector]
	private bool mTurnOffWebCam;

	private WebCamImpl mWebCamImpl;

	private Camera mBackgroundCameraInstance;

	public string DeviceName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public WebCamImpl ImplementationClass
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool FlipHorizontally
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool TurnOffWebCam
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsPlaying
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public void InitCamera()
	{
	}

	public void StartCamera()
	{
	}

	public void StopCamera()
	{
	}

	public bool CheckNativePluginSupport()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool IsWebCamUsed()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class Popup
{
	public delegate void ListCallBack();

	private static int popupListHash;

	public static bool List(Rect position, ref bool showList, ref int listEntry, GUIContent buttonContent, object[] list, GUIStyle listStyle, ListCallBack callBack)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool List(Rect position, ref bool showList, ref int listEntry, GUIContent buttonContent, object[] list, GUIStyle buttonStyle, GUIStyle boxStyle, GUIStyle listStyle, ListCallBack callBack)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class WidthScaler : MonoBehaviour
{
	public float baseWidth;

	public float baseHeight;

	private void Update()
	{
	}
}
public class NGUITools2
{
	public static void FadeIn(GameObject go, float time)
	{
	}

	public static void FadeOut(GameObject go, float time)
	{
	}

	public static void FadeIn(GameObject go, float time, GameObject eventReceiver, string callWhenFinished)
	{
	}

	public static void FadeOut(GameObject go, float time, GameObject eventReceiver, string callWhenFinished)
	{
	}

	public static void Visible(GameObject go)
	{
	}

	public static void Invisible(GameObject go)
	{
	}
}
public class TweenAlpha2 : TweenAlpha
{
	public static TweenAlpha2 Begin(GameObject go, float duration, float from, float to)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static TweenAlpha2 Begin(GameObject go, float duration, float delay, float from, float to)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static TweenAlpha2 Begin(GameObject go, float duration, float from, float to, GameObject eventReceiver, string callWhenFinished)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class TweenPosition2 : TweenPosition
{
	public static TweenPosition Begin(GameObject go, float duration, Vector3 from, Vector3 to)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static TweenPosition Begin(GameObject go, float duration, float delay, Vector3 from, Vector3 to)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void DestroyTween(GameObject go)
	{
	}
}
public class TweenRotation2 : TweenRotation
{
	public string updateFunction;

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenRotation Begin(GameObject go, float duration, Vector3 eulerAngles)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static TweenRotation Begin(GameObject go, float duration, Vector3 eulerAngles, GameObject eventReceiver, string updateFunction)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class TweenScale2 : TweenScale
{
	public static TweenScale2 Begin(GameObject go, float duration, Method method, Vector3 from, Vector3 to)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static TweenScale2 Begin(GameObject go, float duration, Method method, Vector3 from, Vector3 to, GameObject eventReceiver, string callWhenFinished)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static TweenScale2 Begin(GameObject go, float duration, float delay, Method method, Vector3 from, Vector3 to)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class EtceteraBinding2
{
	[DebuggerHidden]
	public static IEnumerator takeScreenShot(string filename)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class QCARBehaviour2 : QCARBehaviour
{
	protected override void StartQCAR()
	{
	}

	public void TrackerStart()
	{
	}

	protected override void StopQCAR()
	{
	}

	public void TrackerStop()
	{
	}
}
public class QCARBehaviour3 : QCARBehaviour
{
	protected override void StartQCAR()
	{
	}

	public void TrackerStart()
	{
	}

	public void TrackerStop()
	{
	}
}
[AddComponentMenu("Camera-Control/3dsMax Camera Style")]
public class MaxCamera : MonoBehaviour
{
	private const float xSpeed = 10f;

	private const float ySpeed = 10f;

	public Transform realTarget;

	public Transform target;

	public Vector3 targetOffset;

	public float distance;

	public float maxDistance;

	public float minDistance;

	public int yMinLimit;

	public int yMaxLimit;

	public int zoomRate;

	public float panSpeed;

	public float zoomDampening;

	private float currentDistance;

	private float desiredDistance;

	private Quaternion rotation;

	private Vector3 position;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Init()
	{
	}

	public void Reset()
	{
	}

	public void OnZoom(float deltaY)
	{
	}

	public void OnOrbit(float deltaX, float deltaY)
	{
	}

	public void OnPan(float deltaX, float deltaY)
	{
	}

	public void OnZoom()
	{
	}

	public void OnOrbit()
	{
	}

	public void OnPan()
	{
	}

	private void LateUpdate()
	{
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class TouchScriptForMaxCam : MonoBehaviour
{
	public MaxCamera maxCam;

	private bool _isActive;

	private Quaternion targetRot;

	private float mouseXNow;

	private float mouseXPre;

	private float mouseYNow;

	private float mouseYPre;

	private float curRotY;

	private float curRotX;

	private float prePinch;

	private bool isPinchReset;

	private float curX;

	private float curY;

	private Quaternion zeroRot;

	private Vector3 zeroPos;

	public bool isActive
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void destroy()
	{
	}

	public void Reset()
	{
	}

	private void Update()
	{
	}

	private void OnMouseDown2()
	{
	}

	private void OnMouseDrag()
	{
	}

	private void OnMouseDrag2()
	{
	}

	private void OnMouseUp()
	{
	}

	private void OnPinchStart()
	{
	}

	private void OnPinch(float rate)
	{
	}

	private void OnPinch2()
	{
	}

	private void doZoomWithMouse()
	{
	}

	private void doZoomWithTouch(float rate)
	{
	}

	private void doRotation()
	{
	}

	private void doPan()
	{
	}
}
public class TextureLoader
{
	public static void MakeNew(GameObject go, Material matRes)
	{
	}
}
public class AKeyboard : MonoBehaviour
{
	public TouchScreenKeyboard keyboard;

	public static AKeyboard instance;

	private string onKeyboardDoneFunc;

	private GameObject receiver;

	public static void Open(string defautText, MonoBehaviour receiver)
	{
	}

	private void Update()
	{
	}

	private static void DestroyKeyboard()
	{
	}
}
public class HUDFPS : MonoBehaviour
{
	public float updateInterval;

	private float accum;

	private int frames;

	private float timeleft;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
public class MainScript : MonoBehaviour
{
	private RenderTexture texture_;

	private Texture2D tex2d_;

	private Rect rect_;

	private int count_;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
public class FacebookComposer
{
	[DllImport("__Internal")]
	private static extern void showDEFbComposer_(string text, string imagePath);

	public static void showDialog(string text, string imagePath)
	{
	}

	public static void showDialog(string text)
	{
	}
}
public class ColorAnimationHelper : MonoBehaviour
{
	[SerializeField]
	private string paramName;

	[SerializeField]
	private Color color;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void assign()
	{
	}
}
public class FrameManager : MonoBehaviour
{
	[SerializeField]
	private float startFrame;

	[SerializeField]
	private float danceFrameOffset;

	private GameObject audio_;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
public class UVAnimationHelper : MonoBehaviour
{
	[SerializeField]
	private string paramName;

	[SerializeField]
	private Vector2 offset;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void assign()
	{
	}
}
[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInputSysfont : MonoBehaviour
{
	public enum KeyboardType
	{
		Default,
		ASCIICapable,
		NumbersAndPunctuation,
		URL,
		NumberPad,
		PhonePad,
		NamePhonePad,
		EmailAddress
	}

	public delegate char Validator(string currentText, char nextChar);

	public delegate void OnSubmit(string inputString);

	public static UIInputSysfont current;

	public UISysFontLabel label;

	public int maxChars;

	public string caratChar;

	public Validator validator;

	public KeyboardType type;

	public bool isPassword;

	public Color activeColor;

	public GameObject eventReceiver;

	public string functionName;

	public OnSubmit onSubmit;

	[HideInInspector]
	public string mText;

	[HideInInspector]
	public string mDefaultText;

	[HideInInspector]
	public Color mDefaultColor;

	private UIWidget.Pivot mPivot;

	private float mPosition;

	public TouchScreenKeyboard mKeyboard;

	[HideInInspector]
	public bool mDoInit;

	public virtual string text
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool selected
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void OnSelect(bool isSelected)
	{
	}

	private void Update()
	{
	}

	private void OnInput(string input)
	{
	}

	public virtual void UpdateLabel()
	{
	}

	public void RestoreLabel()
	{
	}
}
[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInputSysfontName : UIInputSysfont
{
	public enum LabelType
	{
		Name,
		TeamName,
		TeamMessage
	}

	[SerializeField]
	private LabelType _labelType;

	private void Awake()
	{
	}

	public override void UpdateLabel()
	{
	}

	public override void OnSelect(bool isSelected)
	{
	}

	private string CutText(string processed)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/SysFont Label")]
public class UISysFontLabel : UIWidget, ISysFontTexturable
{
	[SerializeField]
	public bool hack;

	[SerializeField]
	protected SysFontTexture _texture;

	protected static Shader _shader;

	protected Material _createdMaterial;

	protected Vector3[] _vertices;

	protected Vector2 _uv;

	public string Text
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string AppleFontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string AndroidFontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string FontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int FontSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsBold
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsItalic
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public SysFont.Alignment Alignment
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsMultiLine
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int MaxWidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int MaxHeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int WidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int HeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int TextWidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int TextHeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Texture Texture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override bool keepMaterial
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void Start()
	{
	}

	public override bool OnUpdate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDestroy()
	{
	}
}
[ExecuteInEditMode]
public class PixelPerfectResizer : MonoBehaviour
{
	public Camera cam;

	private Transform _transform;

	private float _lastOrthographicSize;

	private float _lastPixelWidth;

	private float _lastPixelHeight;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
public class CacheController : MonoBehaviour
{
	[HideInInspector]
	public GameObject mikuPrefab;

	[HideInInspector]
	public GameObject nekoPrefab;

	[HideInInspector]
	public GameObject miku2Prefab;

	[HideInInspector]
	public GameObject neko2Prefab;

	public void MakeMikuCache(GameObject go)
	{
	}

	public void MakeMiku2Cache(GameObject go)
	{
	}

	public void MakeNekoCache(GameObject go)
	{
	}

	private GameObject MakeObjectCache(GameObject go)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class Global
{
	public static string VERSION;

	public static string IMAGE_NAME;

	public static bool isStartedBaseOneTime;

	public static bool isStartedShareOneTime;

	public static bool isPauseAr;

	public static bool isArInPortrait;

	public static bool isArInited;

	public static bool isShowedHelpAr;

	public static bool isShowedHelpPo;
}
public class Aim : MonoBehaviour
{
	public UISprite[] _imgs;

	public void Hide()
	{
	}

	public void HideOnly2()
	{
	}

	public void HideOnly()
	{
	}

	public void Show()
	{
	}

	[DebuggerHidden]
	private IEnumerator IEblink()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator IEhide()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator IEhideOnly()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator IEshow()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class ArNavi : MonoBehaviour
{
	public Vector3 onPos;

	public Vector3 offPos;

	public void On()
	{
	}

	public void On(float delay)
	{
	}

	public void Off()
	{
	}

	public void On2(float time)
	{
	}

	public void On2(float delay, float time)
	{
	}

	public void Off2(float time)
	{
	}

	public void ImmediateOn()
	{
	}

	public void ImmediateOff()
	{
	}
}
public class Credit : MonoBehaviour
{
	public UISprite title;

	public UISprite content;

	public UISprite content2;

	[HideInInspector]
	public bool isRunning;

	public event Action onCreditFinish
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void ToX(Transform t, float x)
	{
	}

	public void Run()
	{
	}

	[DebuggerHidden]
	private IEnumerator IERun()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator IEShow()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator IEHide()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Coroutine Sync()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	public IEnumerator PauseRoutine()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class Guide : MonoBehaviour
{
	private Vector3 onPos;

	private Vector3 offPos;

	public void Up()
	{
	}

	public void Down()
	{
	}

	public void DownThenDestroy()
	{
	}
}
public class FlashProgress : MonoBehaviour
{
	public UISprite _sprite;

	public float _rate;

	private float _delta;

	public float _maxAlpha;

	public float _minRate;

	private float _curTime;

	private bool _flag;

	private void Awake()
	{
	}

	public void Run()
	{
	}

	private void Update()
	{
	}
}
public class DLBlink : MonoBehaviour
{
	public UISprite _uiSprite;

	public string _onSprite;

	public string _offSprite;

	public float _blinkDuration;

	private float _curTime;

	private bool _isOn;

	private int _count;

	private void Awake()
	{
	}

	public void Run()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Blink()
	{
	}
}
public class DLLabelBlink : MonoBehaviour
{
	public UILabel _uiSprite;

	public Color _onColor;

	public Color _offColor;

	public float _blinkDuration;

	private float _curTime;

	private bool _isOn;

	private int _count;

	private void Awake()
	{
	}

	public void Run()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Blink()
	{
	}
}
public class DJDisk : MonoBehaviour
{
	public enum TextRotateMode
	{
		NO_TEXT_ROTATION,
		TEXT_ALWAYS_UP
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
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
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
public class DjDiskLeft : DJDisk
{
	[SerializeField]
	protected float stopX;

	protected override float AngleToCenter(float angle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void SetFirstPositionOfCenterIndex()
	{
	}

	protected override float XfromAlpha(float a, int step)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override bool HideItemCondition(float x, float y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void GetCenter(float angle)
	{
	}

	protected override float ClampAngle(float angle, float direction)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class DjDiskRight : DJDisk
{
	[SerializeField]
	protected float stopX;

	protected override float AngleToCenter(float angle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void SetFirstPositionOfCenterIndex()
	{
	}

	protected override float XfromAlpha(float a, int step)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override bool HideItemCondition(float x, float y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void GetCenter(float angle)
	{
	}

	protected override float ClampAngle(float angle, float direction)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class DjDiskTop : DJDisk
{
	[SerializeField]
	protected float stopY;

	public void Show(float delay)
	{
	}

	public void Hide(float delay)
	{
	}

	protected override float AngleToCenter(float angle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void SetFirstPositionOfCenterIndex()
	{
	}

	protected override void SetItemRotation(int index, float angle)
	{
	}

	protected override float XfromAlpha(float a, int step)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override float YfromAlpha(float a, int step)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override bool HideItemCondition(float x, float y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void GetCenter(float angle)
	{
	}

	protected override float ClampAngle(float angle, float direction)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void SetCenterItemColor()
	{
	}

	public override void SetAllItemWhite()
	{
	}
}
public class PoBlink : MonoBehaviour
{
	public UISprite _uiSprite;

	public string _onSprite;

	public string _offSprite;

	public float _restDuration;

	public float _blinkDuration;

	public float _blinkTimes;

	private float _curTime;

	private bool _isOn;

	private int _count;

	private void Awake()
	{
	}

	public void Run()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void Blink()
	{
	}
}
public class ArBlinkController : MonoBehaviour
{
	public Transform polySurface;

	public GameObject surfacePrefab;

	private List<GameObject> _squares;

	private List<Vector2> _posList;

	public float frameRate;

	private int[] _lines;

	private float _originZ;

	private float _originW;

	private float _originD;

	public Material whiteMat;

	public void Play()
	{
	}

	private void Awake()
	{
	}

	public int LoadFromFile(TextAsset file, ref StageAnimModel data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void LoadStage(StageAnimModel data, int index)
	{
	}

	public void LoadStage(List<int> list)
	{
	}

	public void AddColumn(List<int> column, float percent, ref List<int> list)
	{
	}

	public void OffAllSquare()
	{
	}

	private void DoubleLines()
	{
	}

	public void CreateSquares(int maxSquare)
	{
	}

	private void CreatePosList()
	{
	}

	private void CreateSquare(float x, float z)
	{
	}
}
public class ArBlinkScriptController : MonoBehaviour
{
	protected float _startTime;

	protected float _pauseTime;

	protected bool _isPause;

	protected float _curPhaseTime;

	private void Update()
	{
	}

	protected virtual void OnUpdate()
	{
	}

	public void Run()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public Coroutine Sync()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	public IEnumerator PauseRoutine()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class ArBlinkScript1Controller : ArBlinkScriptController
{
	private const float SPEED_FAST = 0.05f;

	private const float SPEED_NOT_VERY_FAST = 0.1f;

	private const float SPEED_SLOW = 0.2f;

	private const float SPEED_SUPER_SLOW = 0.4f;

	public ArBlinkController _blinkCtrl;

	public TextAsset _expandFile;

	public TextAsset _mikuFile;

	public TextAsset _dominoFile;

	public TextAsset _domino2File;

	public TextAsset _imagesFile;

	private StageAnimModel _expandData;

	private StageAnimModel _mikuData;

	private StageAnimModel _dominoData;

	private StageAnimModel _domino2Data;

	private StageAnimModel _imagesData;

	private int _maxSquare;

	private string _phase;

	private int _phaseCount;

	private bool _isFinished;

	public void Start()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void Phase1_1()
	{
	}

	private void Phase1_1_1()
	{
	}

	private void Phase1_2()
	{
	}

	private void Phase1_3()
	{
	}

	private void Phase1_4()
	{
	}

	private void Phase1_5()
	{
	}

	private void Phase2_1()
	{
	}

	private void Phase3_1()
	{
	}

	private void Phase4_1()
	{
	}

	private void Phase4_2()
	{
	}

	private void Phase5_1()
	{
	}

	private void Phase5_2()
	{
	}

	private void Phase6_1()
	{
	}

	private void Phase6_2()
	{
	}

	private void Phase6_3()
	{
	}

	private void Phase7_1()
	{
	}

	private void Phase8_1()
	{
	}

	private bool IsInitedPhase(string phaseName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void ResetPhase()
	{
	}

	private void Expand()
	{
	}

	private void LoopImages(float delay)
	{
	}

	private void BlinkAnImage(int index)
	{
	}

	private void LoopMiku(float delay)
	{
	}

	private void LoopDomino(float delay)
	{
	}

	private void LoopDomino2(float delay)
	{
	}
}
public class ArBlinkScript2Controller : ArBlinkScriptController
{
	private const float SPEED_FAST = 0.05f;

	private const float SPEED_NOT_VERY_FAST = 0.1f;

	private const float SPEED_SLOW = 0.2f;

	private const float SPEED_SUPER_SLOW = 0.4f;

	public ArBlinkController _blinkCtrl;

	public TextAsset _randSixFile;

	private StageAnimModel _randSixData;

	private int _maxSquare;

	private string _phase;

	private int _phaseCount;

	private bool _isFinished;

	public void Start()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void Phase1_1()
	{
	}

	private void Phase1_1_1()
	{
	}

	private void Phase1_2()
	{
	}

	private void Phase1_3()
	{
	}

	private void Phase1_4()
	{
	}

	private void Phase1_5()
	{
	}

	private void Phase2_1()
	{
	}

	private void Phase3_1()
	{
	}

	private void Phase4_1()
	{
	}

	private void Phase4_2()
	{
	}

	private void Phase5_1()
	{
	}

	private void Phase5_2()
	{
	}

	private void Phase6_1()
	{
	}

	private void Phase6_2()
	{
	}

	private void Phase6_3()
	{
	}

	private void Phase7_1()
	{
	}

	private void Phase8_1()
	{
	}

	private bool IsInitedPhase(string phaseName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void ResetPhase()
	{
	}

	private void RandomSix(float delay)
	{
	}
}
public class ArBlinkScript3Controller : ArBlinkScriptController
{
	private const int SAMPLE_NUMBER = 8;

	private const float MAX_VALUE = 3.5f;

	public ArBlinkController _blinkCtrl;

	public TextAsset[] _files;

	private StageAnimModel[] _data;

	public TextAsset _dominoFile;

	private StageAnimModel _dominoData;

	private float[] samples;

	private float[] curValues;

	private int _maxSquare;

	private bool _isFinished;

	public void Start()
	{
	}

	protected override void OnUpdate()
	{
	}

	[DebuggerHidden]
	private IEnumerator Finish()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void MusicVisualization()
	{
	}
}
public class ArController : MonoBehaviour, ITrackableEventHandler
{
	public ArUIController _arUICtrl;

	public Camera _arCam;

	public Camera _modelCam;

	public Transform _arRoot;

	public Transform _hidePos;

	public Transform _showPos;

	private bool _isMarked;

	private bool _isInited;

	private TrackableBehaviour _curTrack;

	public TrackableBehaviour[] mTrackableBehaviours;

	public GameObject _effect1;

	public event Action<string> onTrackingFound
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public event Action onTrackingLost
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public event Action onArInited
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void DeactiveArCamera()
	{
	}

	public void ActiveArCamera()
	{
	}

	public void ShowRoot()
	{
	}

	public void HideRoot()
	{
	}

	public void ActiveEffect()
	{
	}

	public void DeactiveEffect()
	{
	}

	public void ModelCamToDepth()
	{
	}

	public void ModelCamToSkybox()
	{
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	private void Update()
	{
	}

	private void ResetShowPos()
	{
	}
}
public class ArDLController : MonoBehaviour
{
	private const string MIKU_URL = "Model/Dance/Miku/miku1";

	private const string STAGE_URL = "Model/Dance/Stage/stage1";

	private const string ASHI_URL = "Model/Dance/Stage/ashi1";

	private const string MONITOR_URL = "Model/Dance/Stage/alpha_monitor1";

	private const string SONG_URL = "Sound/Ar/Luv4NightShort";

	private const string AR_ATLAS_URL = "Texture/Ar/ArAtlas";

	private const string AR_FINISH_ATLAS_URL = "Texture/Ar/ArFinishAtlas";

	private const string AR_HELP_ATLAS_URL = "Texture/Ar/Ar2HelpAtlas";

	private const string AR_BANNER_ATLAS_URL = "Texture/Ar/Ar2BannerAtlas";

	private const string AR_SHARE_TICKET_URL = "Texture/Ar/ShareTicket";

	private const int UV_WIDTH = 3;

	private const int UV_TOTAL = 15;

	private const float MONITOR_WIDTH = 0.314f;

	private const float MONITOR_HEIGHT = -0.176f;

	private static ArDLController _instance;

	public Camera _arCam;

	public Camera _modelCam;

	public Transform _mikuContainer;

	public Transform _stageContainer;

	public Transform _arSurface;

	public Material _ar2Mat;

	public Material _shareMat;

	public Material _arHelpMat;

	public Material _arBannerMat;

	private GameObject _miku;

	private GameObject _stage;

	private GameObject _ashi;

	private GameObject _monitor;

	private GameObject _runText;

	private Texture2D _shareTicket;

	private GameObject[] _monitors;

	private float _monitorChangeTime;

	private float _curTime;

	private int _curIndex;

	private string[] _downloadList;

	private bool _isStartedDownload;

	public static ArDLController Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public event Action onDownloadCompleted
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public GameObject GetMiku()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public GameObject GetAshi()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public GameObject GetFloor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public GameObject GetMonitor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Texture GetShareTicket()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	[DebuggerHidden]
	private IEnumerator Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnOKClick()
	{
	}

	private bool isCachedAll()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private bool isDownloadedAll()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator Download()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator AfterDownload()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void SetMaterialTexture()
	{
	}

	private UnityEngine.Object GetItemByName(string item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateByName(string item, Transform parent)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateByName(string item, Transform parent, Vector3 pos)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateAshiByName(string item, Transform parent)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void SetBase(Transform t, Transform parent)
	{
	}

	private void SetAshiBase(Transform t, Transform parent)
	{
	}

	private void Update()
	{
	}

	private void ThreeMonitorAnimation()
	{
	}

	private void DominoTextAnimation()
	{
	}

	private void TutorialProgressCheck()
	{
	}

	public void TrackerStop()
	{
	}
}
public class ArMainController : MonoBehaviour
{
	private const string MIKU_ANIM = "Take 001";

	private const string ASHI_ANIM = "Take 001";

	private const string FLOOR_ANIM = "FloorAnimation";

	public float deltaTime;

	public ArController _arCtrl;

	public ArUIController _arUICtrl;

	public ArDLController _arDlCtrl;

	public ArBlinkController _arBlinkCtrl;

	public ArBlinkScriptController _arBlinkScriptCtrl;

	private bool _IsFirstFound;

	private bool _IsFinished;

	private bool _IsSoundPlayed;

	private GameObject _miku;

	private GameObject _floor;

	private GameObject _ashi;

	private bool _IsClosed;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnCloseClick()
	{
	}

	private void OnDownloadCompleted()
	{
	}

	[DebuggerHidden]
	private IEnumerator ShowHelpAuto()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnArInited()
	{
	}

	private void OnTrackingFound(string obj)
	{
	}

	private void ShowRootAfterFound()
	{
	}

	private void OnTrackingLost()
	{
	}

	private void PlayMiku()
	{
	}

	private void ResumeMiku()
	{
	}

	private void PauseMiku()
	{
	}

	[DebuggerHidden]
	private IEnumerator OnApplicationPause(bool pause)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class ArSelectDanceController : MonoBehaviour
{
	public enum DanceType
	{
		EVER_GREEN,
		LUV_4_NIGHT
	}

	[SerializeField]
	public Transform[] _panels;

	[HideInInspector]
	public static DanceType danceType;

	[SerializeField]
	private GameObject newMark;

	private bool isClicked;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SelectDanceType()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void OnEverGreenClick()
	{
	}

	private void OnLuv4NightClick()
	{
	}

	private void OnBackClick()
	{
	}
}
public class ArTutUIController : TutUIController
{
	public GameObject[] tuts;

	private int changedTutCount;

	protected override void OnPercentChanged(float percent)
	{
	}
}
public class ArUIController : MonoBehaviour
{
	public Transform _panel;

	public Aim _aim;

	public Guide _guide;

	public ArNavi _back;

	public ArNavi _help;

	public Credit _credit;

	public GameObject _logo;

	public GameObject _warning;

	public Camera _uiCam;

	public BoxCollider _shield;

	private bool IsFoundOneTime;

	private bool IsLostOneTime;

	public event Action onCloseClick
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void OnCreditFinish()
	{
	}

	public void OnCloseClick()
	{
	}

	public void OnHelpClick()
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

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Found()
	{
	}

	public void Found2nd()
	{
	}

	public void Lost()
	{
	}

	public void RunCredit()
	{
	}

	public bool IsRunningCredit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Lock()
	{
	}

	public void Unlock()
	{
	}

	[DebuggerHidden]
	private IEnumerator IEfound()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator IElost()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void TrackerStart()
	{
	}

	public void TrackerStop()
	{
	}
}
public class ArUIShareController : ShareComposerController
{
	public TextAsset fbText;

	public TextAsset twText;

	public UISprite title1;

	public UISprite title2;

	public UISprite content;

	public UISprite again;

	public UISprite back;

	public UISprite facebook;

	public UISprite twitter;

	public UISprite shield;

	private bool _isInited;

	private void Awake()
	{
	}

	private void SetAlphaAll(float alpha)
	{
	}

	private void Update()
	{
	}

	[DebuggerHidden]
	private IEnumerator IERun()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void PostFb()
	{
	}

	protected override void PostTw()
	{
	}

	private void OnAgainClick()
	{
	}

	private void OnMikubakuClick()
	{
	}

	private void OnFacebookClick()
	{
	}

	private void OnTwitterClick()
	{
	}
}
public class ArDL2Controller : MonoBehaviour
{
	private const string EFFECT_ANIM = "MasterEffectAnim";

	private const string MIKU_URL = "Model/Dance/Miku/miku2";

	private const string STAGE_URL = "Model/Dance/Stage/stage2";

	private const string ASHI_URL = "Model/Dance/Stage/ashi2";

	private const string SONG_URL = "Sound/Ar/StrawberryShort";

	private const string AR_ATLAS_URL = "Texture/Ar/Ar2Atlas";

	private const string AR_FINISH_ATLAS_URL = "Texture/Ar/ArFinishAtlas";

	private const string AR_HELP_ATLAS_URL = "Texture/Ar/Ar2HelpAtlas";

	private const string AR_BANNER_ATLAS_URL = "Texture/Ar/Ar2BannerAtlas";

	private const string AR_SHARE_TICKET_URL = "Texture/Ar/ShareTicket";

	private const string AR_EFFECT = "Model/Dance/Stage/effect2";

	private const int UV_WIDTH = 3;

	private const int UV_TOTAL = 15;

	private const float MONITOR_WIDTH = 0.314f;

	private const float MONITOR_HEIGHT = -0.176f;

	private static ArDL2Controller _instance;

	public Camera _arCam;

	public Camera _modelCam;

	public Transform _mikuContainer;

	public Transform _stageContainer;

	public Transform _arSurface;

	public Material _ar2Mat;

	public Material _shareMat;

	public Material _arHelpMat;

	public Material _arBannerMat;

	private GameObject _miku;

	private GameObject _stage;

	private GameObject _ashi;

	private Texture2D _shareTicket;

	private GameObject _effect;

	private float _curTime;

	private int _curIndex;

	private string[] _downloadList;

	private bool _isStartedDownload;

	public static ArDL2Controller Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public event Action onDownloadCompleted
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public GameObject GetMiku()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public GameObject GetAshi()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Texture GetShareTicket()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public GameObject GetEffect()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	[DebuggerHidden]
	private IEnumerator Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnOKClick()
	{
	}

	private bool isCachedAll()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private bool isDownloadedAll()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator Download()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator AfterDownload()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void SetMaterialTexture()
	{
	}

	private UnityEngine.Object GetItemByName(string item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateByName(string item, Transform parent)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateByName(string item, Transform parent, Vector3 pos)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateAshiByName(string item, Transform parent)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateEffectByName(string item, Transform parent)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void SetBase(Transform t, Transform parent)
	{
	}

	private void SetMikuBase(Transform t, Transform parent)
	{
	}

	private void ActiveTransformArray(Transform[] ts, bool active)
	{
	}

	private void SetAshiBase(Transform t, Transform parent)
	{
	}

	private void SetStageBase(Transform t, Transform parent)
	{
	}

	private void Update()
	{
	}

	private void TutorialProgressCheck()
	{
	}

	public void TrackerStop()
	{
	}
}
public class ArMain2Controller : MonoBehaviour
{
	private const string MIKU_ANIM = "Take 001";

	private const string ASHI_ANIM = "Take 001";

	private const string EFFECT_ANIM = "MasterEffectAnim";

	private float deltaTime;

	public ArController _arCtrl;

	public ArUIController _arUICtrl;

	public ArDL2Controller _arDlCtrl;

	public ArBlinkController _arBlinkCtrl;

	public ArBlinkScriptController _arBlinkScriptCtrl;

	[SerializeField]
	private GameObject alphaShield;

	private bool _IsFirstFound;

	private bool _IsFinished;

	private bool _IsSoundPlayed;

	private GameObject _miku;

	private GameObject _ashi;

	private GameObject _effect;

	private bool _IsClosed;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnCloseClick()
	{
	}

	private void OnDownloadCompleted()
	{
	}

	[DebuggerHidden]
	private IEnumerator ShowHelpAuto()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnArInited()
	{
	}

	private void OnTrackingFound(string obj)
	{
	}

	[DebuggerHidden]
	private IEnumerator PlaySound()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void ShowRootAfterFound()
	{
	}

	private void OnTrackingLost()
	{
	}

	private void PlayMiku()
	{
	}

	private void ResumeMiku()
	{
	}

	private void PauseMiku()
	{
	}

	[DebuggerHidden]
	private IEnumerator OnApplicationPause(bool pause)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class BaseController : MonoBehaviour
{
	private int _counter;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void StartUnity(string message)
	{
	}
}
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
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public event Action onGoAr
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public event Action onOK
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
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
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public event Action onOK
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
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
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
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
public class ShareComposer2Controller : MonoBehaviour
{
	private const string CONSUMER_KEY = "CwZvon4BKdGa1krWRM6ubw";

	private const string CONSUMER_SECRET = "aHRTcazIIITnGCOvlq0s9F9X8tTphRv1wwPH9rKAyuI";

	protected virtual void PostFb()
	{
	}

	protected virtual void PostTw()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected void PostFacebook()
	{
	}

	private void facebookComposerCompletedEvent(bool didSucceed)
	{
	}

	protected void PostTwitter()
	{
	}

	private void tweetSheetCompletedEvent(bool didSucceed)
	{
	}
}
public class ShareComposerController : MonoBehaviour
{
	private const string CONSUMER_KEY = "CwZvon4BKdGa1krWRM6ubw";

	private const string CONSUMER_SECRET = "aHRTcazIIITnGCOvlq0s9F9X8tTphRv1wwPH9rKAyuI";

	private bool _isPostClicked;

	protected string _fbMessage;

	protected virtual void AfterLogin()
	{
	}

	protected virtual void PostFb()
	{
	}

	protected virtual void PostTw()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPostClick(string message)
	{
	}

	protected void PostFacebook()
	{
	}

	private void sessionOpenedEvent()
	{
	}

	protected void completionHandler(string error, object result)
	{
	}

	private void facebookComposerCompletedEvent(bool didSucceed)
	{
	}

	protected void PostTwitter()
	{
	}

	private void tweetSheetCompletedEvent(bool didSucceed)
	{
	}
}
public class ShareController : MonoBehaviour
{
	private const string CONSUMER_KEY = "CwZvon4BKdGa1krWRM6ubw";

	private const string CONSUMER_SECRET = "aHRTcazIIITnGCOvlq0s9F9X8tTphRv1wwPH9rKAyuI";

	protected virtual void PostFb()
	{
	}

	protected virtual void PostTw()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected void PostFacebook()
	{
	}

	private void sessionOpenedEvent()
	{
	}

	protected void completionHandler(string error, object result)
	{
	}

	private void facebookComposerCompletedEvent(bool didSucceed)
	{
	}

	protected void PostTwitter()
	{
	}

	private void loginSucceeded()
	{
	}

	private void postSucceeded()
	{
	}

	private void tweetSheetCompletedEvent(bool didSucceed)
	{
	}
}
public class PoMainMiku2Controller : PoMainController
{
	private const string MIKU_SPINE_PATH = "Reference/Hips/Spine";

	private GameObject _miku;

	private bool _isAnimCheck;

	private bool _isInitedMiku;

	private GameObject _prevModel;

	private Vector3 _prevSpinePos;

	private Transform _itemBone;

	private void Update()
	{
	}

	protected override void OnDownloadCompleted()
	{
	}

	public override void Init()
	{
	}

	[DebuggerHidden]
	private IEnumerator ShowHelpAuto()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void InitMiku()
	{
	}

	protected override void OnFaceItemChange(int itemId)
	{
	}

	protected override void OnPoseItemChange(int itemId)
	{
	}

	protected override void OnGoToAr()
	{
	}

	private void OnAnimFinish()
	{
	}

	private void ResetCenter()
	{
	}

	private string GetSpinePath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private string GetSpinePath(GameObject go)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void SetMixing(GameObject go, Transform faceBone, Transform allBone)
	{
	}

	private void SetFaceMixing(GameObject go, bool recursive, Transform faceBone)
	{
	}

	private void SetPoseMixing(GameObject go, bool recursive, Transform faceBone, Transform allBone)
	{
	}

	private void SetPoseItemMixing(GameObject go, Transform itemBone)
	{
	}

	private void Mix(GameObject go, string anim, List<Transform> boneList, bool recursive)
	{
	}

	private void ActiveModel(GameObject go)
	{
	}
}
public class PoMainMikuController : PoMainController
{
	private const string MIKU_SPINE_PATH = "Reference/Hips/Spine";

	private const string NEKO_SPINE_PATH = "neko_pose:Reference/neko_pose:Hips/neko_pose:Spine";

	private GameObject _miku;

	private GameObject _neko;

	private bool _isAnimCheck;

	private bool _isInitedMiku;

	private GameObject _prevModel;

	private Vector3 _prevSpinePos;

	private Transform _itemBone;

	private void Update()
	{
	}

	protected override void OnDownloadCompleted()
	{
	}

	public override void Init()
	{
	}

	[DebuggerHidden]
	private IEnumerator ShowHelpAuto()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void InitMiku()
	{
	}

	private void InitNeko()
	{
	}

	private void DeactiveNeko()
	{
	}

	protected override void OnFaceItemChange(int itemId)
	{
	}

	protected override void OnPoseItemChange(int itemId)
	{
	}

	protected override void OnGoToAr()
	{
	}

	private void OnAnimFinish()
	{
	}

	private void ResetCenter()
	{
	}

	private string GetSpinePath()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private string GetSpinePath(GameObject go)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void SetMixing(GameObject go, Transform faceBone, Transform allBone)
	{
	}

	private void SetFaceMixing(GameObject go, bool recursive, Transform faceBone)
	{
	}

	private void SetPoseMixing(GameObject go, bool recursive, Transform faceBone, Transform allBone)
	{
	}

	private void SetPoseItemMixing(GameObject go, Transform itemBone)
	{
	}

	private void Mix(GameObject go, string anim, List<Transform> boneList, bool recursive)
	{
	}

	private void ActiveModel(GameObject go)
	{
	}
}
public class PoController : MonoBehaviour, ITrackableEventHandler
{
	public Camera _arCam;

	public MaxCamera _modelCam;

	public Transform _modelCenter;

	public Transform _mikuContainer;

	public TrackableBehaviour[] mTrackableBehaviours;

	private TrackableBehaviour _curTrack;

	public event Action<string> onTrackingFound
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public event Action onTrackingLost
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	private void GetCurrentTrack()
	{
	}

	public void DeactiveArCamera()
	{
	}

	public void ActiveArCamera()
	{
	}

	public void ModelCamToDepth()
	{
	}

	public void ModelCamToSkybox()
	{
	}

	public void ResetModel()
	{
	}

	public void ResetNeko(GameObject go)
	{
	}
}
public class PoDLController : MonoBehaviour
{
	private const string MIKU_URL = "Model/Portrait/Miku/miku_fix";

	private const string NEKO_URL = "Model/Portrait/Miku/miku_neko_fix";

	private const string MIKU_2_URL = "Model/Portrait/Miku/miku2_fix";

	private const string PO_DIALOG_ATLAS_URL = "Texture/Portrait/DialogAtlas";

	private const string PO_DISK_URL = "Texture/Portrait/DiskAtlas";

	private const string PO_HELP_ATLAS_URL = "Texture/Portrait/PoHelpAtlas";

	private const string PO_URL = "Texture/Portrait/PortraitAtlas";

	public CacheController cache;

	public Material _poDialogMat;

	public Material _poDiskMat;

	public Material _poHelpMat;

	public Material _poMat;

	public Camera _arCam;

	public Camera _modelCam;

	public Transform _mikuContainer;

	public Transform _modelCenter;

	private GameObject _miku;

	private GameObject _neko;

	private bool _isStartedDownload;

	private bool _isFinishedDownload;

	private string[] _downloadList;

	public bool IsFinishedDownload
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public event Action onDownloadCompleted
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public GameObject GetMiku()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public GameObject GetNeko()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public GameObject GetMiku2()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public GameObject GetNeko2()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject GetMikuByURL(GameObject prefab)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject GetNekoByURL(GameObject prefab)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Awake()
	{
	}

	[DebuggerHidden]
	private IEnumerator Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnOKClick()
	{
	}

	private bool isCachedAll()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator Download()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void SetMaterialTexture()
	{
	}

	private UnityEngine.Object GetItemByName(string item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateByName(string name, string item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private GameObject InstantiateByPrefab(GameObject prefab)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ResetCenter(GameObject go, string spinePath)
	{
	}

	private void Update()
	{
	}
}
public class PoMainController : MonoBehaviour
{
	public PoController _poCtrl;

	public PoUIController _poUICtrl;

	public PoDLController _poDlCtrl;

	public TouchScriptForMaxCam _poModelCtrl;

	public QCARBehaviour2 _qcarCtrl;

	public Transform _mikuContainer;

	[HideInInspector]
	public GameObject _curModel;

	[HideInInspector]
	public MSpecialPose _specialData;

	[HideInInspector]
	public List<string> faceList;

	[HideInInspector]
	public List<string> poseList;

	private bool isStarted;

	public virtual void Init()
	{
	}

	public void GetProperties(PoMainController other)
	{
	}

	private void Start()
	{
	}

	protected void ResetCenter(GameObject go, string spinePath)
	{
	}

	protected void ResetCenter(Vector3 prevSpinePos, GameObject go, string spinePath)
	{
	}

	private void OnEnable()
	{
	}

	private void AddDelegates()
	{
	}

	private void OnDisable()
	{
	}

	private void RemoveDelegates()
	{
	}

	protected virtual void OnDownloadCompleted()
	{
	}

	protected virtual void OnFaceItemChange(int itemId)
	{
	}

	protected virtual void OnPoseItemChange(int itemId)
	{
	}

	[DebuggerHidden]
	protected IEnumerator ShowSpecialDialog()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected virtual void OnGoToAr()
	{
	}

	private void OnSpecialDialogClose()
	{
	}

	private void OnSpecialDialogGoar()
	{
	}

	private void ToPortrait()
	{
	}

	private void RunSpecial()
	{
	}

	private void GoToAr()
	{
	}

	private void UnlockUI()
	{
	}

	private void OnBannerClick()
	{
	}

	private void OnArBackClick()
	{
	}

	private void OnTrackingFound(string obj)
	{
	}

	private void OnTrackingLost()
	{
	}

	[DebuggerHidden]
	private IEnumerator OnApplicationPause(bool pause)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnSwitchNormalClick()
	{
	}

	private void OnSwitchNewClick()
	{
	}
}
public class PoOpeningController : MonoBehaviour
{
	private const string OPENING_URL = "Texture/Portrait/OpeningAtlas";

	public GameObject _root;

	[SerializeField]
	private Material _poOpeningMat;

	private bool _isInited;

	private bool _isClosed;

	private void Awake()
	{
	}

	[DebuggerHidden]
	private IEnumerator Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator Download()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void OnOKClick()
	{
	}

	private bool isCachedAll()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Set()
	{
	}

	private void Show()
	{
	}

	private void OnCloseClick()
	{
	}

	private void DestroyScene()
	{
	}
}
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
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public event Action onArBackClick
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public event Action onSwitchClick
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public event Action onNewClick
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
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
public class Special1Controller : SpecialController
{
	private GameObject _miku;

	private GameObject _neko;

	private ArNavi _mask;

	protected override void Init()
	{
	}

	[DebuggerHidden]
	protected override IEnumerator ShowPose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	protected override IEnumerator ShowDiskAnim()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected override void OnRotationFinish()
	{
	}

	[DebuggerHidden]
	private IEnumerator Capture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class SpecialController : MonoBehaviour
{
	protected PoController _poCtrl;

	protected PoUIController _poUICtrl;

	protected PoDLController _poDlCtrl;

	protected TouchScriptForMaxCam _poModelCtrl;

	protected PoMainController _poMainCtrl;

	public virtual void Setup(PoController poCtrl, PoUIController poUICtrl, PoDLController poDlCtrl, TouchScriptForMaxCam poModelCtrl)
	{
	}

	private void OnDisable()
	{
	}

	public void Run(float delay)
	{
	}

	[DebuggerHidden]
	public virtual IEnumerator IErun(float delay)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected virtual void Init()
	{
	}

	[DebuggerHidden]
	protected virtual IEnumerator ShowPose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	protected virtual IEnumerator ShowPortraitUI()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DebuggerHidden]
	protected virtual IEnumerator ShowDiskAnim()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	protected virtual void OnRotationFinish()
	{
	}
}
public class TutUIController : MonoBehaviour
{
	private const float MAX_BAR_WIDTH = 560f;

	public GameObject _root;

	public Camera _camera;

	public UILabel _textPer;

	public UISlicedSprite _barPer;

	public UISprite _loading;

	public FlashProgress _flash;

	public Transform[] _panels;

	private int _type;

	private bool _isStartedBlink;

	private bool _isReady;

	private static TutUIController _instance;

	public bool IsReady
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static TutUIController Instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private void Awake()
	{
	}

	private void ResetZero()
	{
	}

	[DebuggerHidden]
	private IEnumerator Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void SetReady()
	{
	}

	private void DestroyScene()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void SetDownloadPercent(float percent)
	{
	}

	private void SetTextPercent(float percent)
	{
	}

	private void SetBarPercent(float percent)
	{
	}

	protected virtual void OnPercentChanged(float percent)
	{
	}

	public void OnBackClick()
	{
	}

	public void SetCameraToDepthOnly()
	{
	}

	public void SetIsLoading()
	{
	}

	public void SetIsDownloading()
	{
	}

	private void RunFlash()
	{
	}

	private void BlinkLoading()
	{
	}
}
public class MSpecialPose
{
	public string id;

	public int diskIndex;

	public List<string> markers;

	public string className;

	public MSpecialPose(string _id, int _diskIndex, string[] _markers, string _className)
	{
	}

	public static bool IsGotSpecial(MSpecialPose special)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void GotSpecial(MSpecialPose special)
	{
	}

	public static MSpecialPose GetSpecialData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static MSpecialPose GetSpecial1Data()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static MSpecialPose GetSpecial2Data()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class TestAllController : MonoBehaviour
{
	private static TestAllController instance;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	private void TestAR()
	{
	}

	private void TestModel()
	{
	}

	private void TestARandModel()
	{
	}
}
public class TestAntiAliasing : MonoBehaviour
{
	public GameObject miku;

	private void OnGUI()
	{
	}
}
public class TestBlink2Controller : MonoBehaviour
{
	public Transform polySurface;

	private MeshRenderer[] _rens;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private Color RandomColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class TestBlinkController : MonoBehaviour
{
	private const int MAX_SQUARE = 40;

	public Transform polySurface;

	public GameObject surfacePrefab;

	private List<GameObject> _squares;

	private List<Vector2> _posList;

	private int[] _lines;

	private float _originZ;

	private float _originW;

	private float _originD;

	public Material whiteMat;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void UpdateSquares()
	{
	}

	private void DeactiveOldSquares()
	{
	}

	private void DoubleLines()
	{
	}

	private void CreateSquares()
	{
	}

	private void CreatePosList()
	{
	}

	private void CreateSquare(float x, float z)
	{
	}

	private Color RandomColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class TestDownload : MonoBehaviour
{
	public Material mat;

	[DebuggerHidden]
	private IEnumerator Start()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void Update()
	{
	}
}
public class TestMarker2Controller : MonoBehaviour, ITrackableEventHandler
{
	public GameObject restObject;

	public GameObject rootObj;

	public GameObject targetTr;

	private bool isMarked;

	public TrackableBehaviour mTrackableBehaviour;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	private void OnTrackingFound()
	{
	}

	private void OnTrackingLost()
	{
	}
}
public class TestMarkerController : MonoBehaviour, ITrackableEventHandler
{
	public GameObject restObject;

	public GameObject rootObj;

	public GameObject targetTr;

	private bool isMarked;

	public TrackableBehaviour mTrackableBehaviour;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	private void OnTrackingFound()
	{
	}

	private void OnTrackingLost()
	{
	}
}
public class TestMikuController : MonoBehaviour
{
	public GameObject m_MikuModel;

	public Transform m_Container;

	public GameObject m_ARCamera;

	public GameObject m_ObjCamera;

	private static TestMikuController instance;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	private void CreateMiku()
	{
	}

	private void TestAR()
	{
	}

	private void TestModel()
	{
	}

	private void TestARandModel()
	{
	}
}
public class TestSizeScript : MonoBehaviour
{
}
public class TestStageController : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}
}
public class TestUV : MonoBehaviour
{
	private const int UV_WIDTH = 3;

	private const int UV_TOTAL = 15;

	private const float MONITOR_WIDTH = 0.314f;

	private const float MONITOR_HEIGHT = -0.176f;

	public GameObject _runText;

	public GameObject[] _monitors;

	public float _monitorChangeTime;

	private float _curTime;

	private int _curIndex;

	private void Update()
	{
	}

	private void ThreeMonitorAnimation()
	{
	}

	private void DominoTextAnimation()
	{
	}
}
public class StageAnimModel
{
	public int matId;

	public List<List<int>> data;

	public void Update(List<GameObject> squares, List<int> frame)
	{
	}

	public void Insert(int index)
	{
	}

	public void InsertAndCopy(int index)
	{
	}

	public void Remove(int index)
	{
	}

	public void SetMaterial(int id)
	{
	}

	public StageAnimModelTemp Convert()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class StageAnimModelTemp
{
	public int matId;

	public Dictionary<string, List<int>> data;

	public StageAnimModel Convert()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class UIWrapper
{
	[DllImport("__Internal")]
	private static extern void showDomino_();

	[DllImport("__Internal")]
	private static extern void playShutterSound_();

	[DllImport("__Internal")]
	private static extern bool isTest_();

	public static void showDomino()
	{
	}

	public static void playShutterSound()
	{
	}

	public static bool isTest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
