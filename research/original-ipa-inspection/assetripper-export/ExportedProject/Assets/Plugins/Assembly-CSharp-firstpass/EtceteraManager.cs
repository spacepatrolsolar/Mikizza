using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prime31;
using UnityEngine;

public class EtceteraManager : AbstractManager
{
	public delegate void EceteraTextureDelegate(Texture2D texture);

	public delegate void EceteraTextureFailedDelegate(string error);

	public static string pushIOApiKey;

	public static string[] pushIOCategories;

	public static string deviceToken
	{
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static event Action dismissingViewControllerEvent
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

	public static event Action imagePickerCancelledEvent
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

	public static event Action<string> imagePickerChoseImageEvent
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

	public static event Action saveImageToPhotoAlbumSucceededEvent
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

	public static event Action<string> saveImageToPhotoAlbumFailedEvent
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

	public static event Action<string> alertButtonClickedEvent
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

	public static event Action promptCancelledEvent
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

	public static event Action<string> singleFieldPromptTextEnteredEvent
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

	public static event Action<string, string> twoFieldPromptTextEnteredEvent
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

	public static event Action<string> remoteRegistrationSucceededEvent
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

	public static event Action<string> remoteRegistrationFailedEvent
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

	public static event Action urbanAirshipRegistrationSucceededEvent
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

	public static event Action<string> urbanAirshipRegistrationFailedEvent
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

	public static event Action<string> pushIORegistrationCompletedEvent
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

	public static event Action<IDictionary> remoteNotificationReceivedEvent
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

	public static event Action<IDictionary> remoteNotificationReceivedAtLaunchEvent
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

	public static event Action<IDictionary> localNotificationWasReceivedEvent
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

	public static event Action<IDictionary> localNotificationWasReceivedAtLaunchEvent
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

	public static event Action<string> mailComposerFinishedEvent
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

	public static event Action<string> smsComposerFinishedEvent
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

	static EtceteraManager()
	{
	}

	public void dismissingViewController()
	{
	}

	public void imagePickerDidCancel(string empty)
	{
	}

	public void imageSavedToDocuments(string filePath)
	{
	}

	public void saveImageToPhotoAlbumFailed(string error)
	{
	}

	public void saveImageToPhotoAlbumSucceeded(string empty)
	{
	}

	[DebuggerHidden]
	public static IEnumerator textureFromFileAtPath(string filePath, EceteraTextureDelegate del, EceteraTextureFailedDelegate errorDel)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void alertViewClickedButton(string buttonTitle)
	{
	}

	public void alertPromptCancelled(string empty)
	{
	}

	public void alertPromptEnteredText(string text)
	{
	}

	public void remoteRegistrationDidSucceed(string deviceToken)
	{
	}

	[DebuggerHidden]
	private IEnumerator registerDeviceWithPushIO()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void remoteRegistrationDidFail(string error)
	{
	}

	public void urbanAirshipRegistrationDidSucceed(string empty)
	{
	}

	public void urbanAirshipRegistrationDidFail(string error)
	{
	}

	public void remoteNotificationWasReceived(string json)
	{
	}

	public void remoteNotificationWasReceivedAtLaunch(string json)
	{
	}

	public void localNotificationWasReceived(string json)
	{
	}

	public void localNotificationWasReceivedAtLaunch(string json)
	{
	}

	public void mailComposerFinishedWithResult(string result)
	{
	}

	public void smsComposerFinishedWithResult(string result)
	{
	}
}
