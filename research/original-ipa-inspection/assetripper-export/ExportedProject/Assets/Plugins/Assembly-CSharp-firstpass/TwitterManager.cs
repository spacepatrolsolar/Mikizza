using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TwitterManager : MonoBehaviour
{
	public static event Action loginSucceededEvent
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

	public static event Action<string> loginFailedEvent
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

	public static event Action postSucceededEvent
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

	public static event Action<string> postFailedEvent
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

	public static event Action<List<object>> homeTimelineReceivedEvent
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

	public static event Action<string> homeTimelineFailedEvent
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

	public static event Action<object> requestDidFinishEvent
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

	public static event Action<string> requestDidFailEvent
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

	public static event Action<bool> tweetSheetCompletedEvent
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

	static TwitterManager()
	{
	}

	public void twitterLoginSucceeded(string empty)
	{
	}

	public void twitterLoginDidFail(string error)
	{
	}

	public void twitterPostSucceeded(string empty)
	{
	}

	public void twitterPostDidFail(string error)
	{
	}

	public void twitterHomeTimelineDidFail(string error)
	{
	}

	public void twitterHomeTimelineDidFinish(string results)
	{
	}

	public void twitterRequestDidFinish(string results)
	{
	}

	public void twitterRequestDidFail(string error)
	{
	}

	public void tweetSheetCompleted(string oneOrZero)
	{
	}
}
