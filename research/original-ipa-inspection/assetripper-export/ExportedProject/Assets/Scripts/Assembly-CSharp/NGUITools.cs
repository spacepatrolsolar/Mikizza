using System.Collections.Generic;
using UnityEngine;

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

	public static void Destroy(Object obj)
	{
	}

	public static void DestroyImmediate(Object obj)
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
