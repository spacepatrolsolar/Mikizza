using System;
using System.Runtime.CompilerServices;
using Prime31;

public class SharingManager : AbstractManager
{
	public static event Action<string> sharingFinishedWithActivityTypeEvent
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

	public static event Action sharingCancelledEvent
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

	static SharingManager()
	{
	}

	private void sharingFinishedWithActivityType(string activityType)
	{
	}

	private void sharingCancelled(string empty)
	{
	}
}
