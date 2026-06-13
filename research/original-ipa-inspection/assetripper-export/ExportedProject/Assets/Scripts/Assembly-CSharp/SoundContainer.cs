using System.Collections.Generic;
using UnityEngine;

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
