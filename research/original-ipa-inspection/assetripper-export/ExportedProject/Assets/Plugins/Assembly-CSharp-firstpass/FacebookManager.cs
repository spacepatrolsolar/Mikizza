using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Prime31;

public class FacebookManager : AbstractManager
{
	public static event Action sessionOpenedEvent
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

	public static event Action preLoginSucceededEvent
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

	public static event Action<string> dialogCompletedWithUrlEvent
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

	public static event Action<string> dialogFailedEvent
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

	public static event Action<object> graphRequestCompletedEvent
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

	public static event Action<string> graphRequestFailedEvent
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

	public static event Action<object> restRequestCompletedEvent
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

	public static event Action<string> restRequestFailedEvent
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

	public static event Action<bool> facebookComposerCompletedEvent
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

	public static event Action reauthorizationSucceededEvent
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

	public static event Action<string> reauthorizationFailedEvent
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

	public static event Action<string> shareDialogFailedEvent
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

	public static event Action<Dictionary<string, object>> shareDialogSucceededEvent
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

	static FacebookManager()
	{
	}

	public void sessionOpened(string accessToken)
	{
	}

	public void loginFailed(string error)
	{
	}

	public void dialogCompletedWithUrl(string url)
	{
	}

	public void dialogFailedWithError(string error)
	{
	}

	public void graphRequestCompleted(string json)
	{
	}

	public void graphRequestFailed(string error)
	{
	}

	public void restRequestCompleted(string json)
	{
	}

	public void restRequestFailed(string error)
	{
	}

	public void facebookComposerCompleted(string result)
	{
	}

	public void reauthorizationSucceeded(string empty)
	{
	}

	public void reauthorizationFailed(string error)
	{
	}

	public void shareDialogFailed(string error)
	{
	}

	public void shareDialogSucceeded(string json)
	{
	}
}
