using System.Collections;
using System.Diagnostics;
using UnityEngine;

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
