using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

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
