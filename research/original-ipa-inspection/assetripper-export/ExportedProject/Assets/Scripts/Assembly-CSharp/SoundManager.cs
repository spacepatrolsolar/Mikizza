using System.Collections.Generic;
using UnityEngine;

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
