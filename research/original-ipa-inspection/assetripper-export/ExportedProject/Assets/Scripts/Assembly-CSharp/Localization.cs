using System.Collections.Generic;
using UnityEngine;

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
