using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Credit : MonoBehaviour
{
	public UISprite title;

	public UISprite content;

	public UISprite content2;

	[HideInInspector]
	public bool isRunning;

	public event Action onCreditFinish
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
