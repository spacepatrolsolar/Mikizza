using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ABManager : MonoBehaviour
{
	public enum ABServer
	{
		RELEASE = 0,
		DEV = 1,
		DEV_PREVIEW = 2,
		DOMINO_TEST = 3
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

	public Object GetItem(string item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public Object GetItemChild(string item, string name)
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
