using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

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
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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
