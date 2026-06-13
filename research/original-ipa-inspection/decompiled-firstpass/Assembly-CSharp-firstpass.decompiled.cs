using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Prime31;
using UnityEngine;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyVersion("0.0.0.0")]
public enum P31RemoteNotificationType
{
	None = 0,
	Badge = 1,
	Sound = 2,
	Alert = 4
}
public enum UIInterfaceOrientation
{
	Portrait = 1,
	PortraitUpsideDown = 2,
	LandscapeLeft = 4,
	LandscapeRight = 3
}
public enum PhotoPromptType
{
	Camera,
	Album,
	CameraAndAlbum
}
public class EtceteraBinding
{
	[DebuggerHidden]
	public static IEnumerator takeScreenShot(string filename)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern bool _etceteraApplicationCanOpenUrl(string url);

	public static bool applicationCanOpenUrl(string url)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern string _etceteraGetCurrentLanguage();

	public static string getCurrentLanguage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern string _etceteraGetLocalizedString(string key, string defaultValue);

	public static string getLocalizedString(string key, string defaultValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[Obsolete("Use the _etceteraShowAlertWithTitleMessageAndButtons. This method will be removed.")]
	public static void showAlertWithTitleMessageAndButton(string title, string message, string buttonTitle)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowAlertWithTitleMessageAndButtons(string title, string message, string buttons);

	public static void showAlertWithTitleMessageAndButtons(string title, string message, string[] buttons)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraSetPromptColors(uint borderColor, uint gradientStopOne, uint gradientStopTwo);

	public static void setPromptColors(uint borderColor, uint gradientStopOne, uint gradientStopTwo)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowPromptWithOneField(string title, string message, string placeHolder, bool autocomplete);

	public static void showPromptWithOneField(string title, string message, string placeHolder, bool autocomplete)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowPromptWithTwoFields(string title, string message, string placeHolder1, string placeHolder2, bool autocomplete);

	public static void showPromptWithTwoFields(string title, string message, string placeHolder1, string placeHolder2, bool autocomplete)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowWebPage(string url, bool showControls);

	public static void showWebPage(string url, bool showControls)
	{
	}

	[DllImport("__Internal")]
	private static extern bool _etceteraIsEmailAvailable();

	public static bool isEmailAvailable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern bool _etceteraIsSMSAvailable();

	public static bool isSMSAvailable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowMailComposer(string toAddress, string subject, string body, bool isHTML);

	public static void showMailComposer(string toAddress, string subject, string body, bool isHTML)
	{
	}

	[DebuggerHidden]
	public static IEnumerator showMailComposerWithScreenshot(MonoBehaviour mono, string toAddress, string subject, string body, bool isHTML)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowMailComposerWithAttachment(string filePathToAttachment, string attachementMimeType, string attachmentFilename, string toAddress, string subject, string body, bool isHTML);

	public static void showMailComposerWithAttachment(string filePathToAttachment, string attachmentMimeType, string attachmentFilename, string toAddress, string subject, string body, bool isHTML)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowSMSComposer(string recipients, string body);

	public static void showSMSComposer(string body)
	{
	}

	public static void showSMSComposer(string[] recipients, string body)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowActivityView();

	public static void showActivityView()
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraHideActivityView();

	public static void hideActivityView()
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowBezelActivityViewWithLabel(string label);

	public static void showBezelActivityViewWithLabel(string label)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraShowBezelActivityViewWithImage(string label, string imagePath);

	public static void showBezelActivityViewWithImage(string label, string imagePath)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraAskForReview(int launchCount, float hoursBetweenPrompts, string title, string message, string iTunesAppId);

	public static void askForReview(int launchCount, float hoursBetweenPrompts, string title, string message, string iTunesAppId)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraAskForReviewImmediately(string title, string message, string iTunesAppId);

	public static void askForReview(string title, string message, string iTunesAppId)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraSetPopoverPoint(float xPos, float yPos);

	public static void setPopoverPoint(float xPos, float yPos)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraPromptForPhoto(float scaledToSize, int promptType, float jpegCompression, bool allowsEditing);

	public static void promptForPhoto(float scaledToSize)
	{
	}

	public static void promptForPhoto(float scaledToSize, PhotoPromptType promptType)
	{
	}

	public static void promptForPhoto(float scaledToSize, PhotoPromptType promptType, float jpegCompression, bool allowsEditing)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraResizeImageAtPath(string filePath, float width, float height);

	public static void resizeImageAtPath(string filePath, float width, float height)
	{
	}

	[DllImport("__Internal")]
	private static extern string _etceteraGetImageSize(string filePath);

	public static Vector2 getImageSize(string filePath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern void _etceteraSaveImageToPhotoAlbum(string filePath);

	public static void saveImageToPhotoAlbum(string filePath)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraSetUrbanAirshipCredentials(string appKey, string appSecret, string alias);

	public static void setUrbanAirshipCredentials(string appKey, string appSecret)
	{
	}

	public static void setUrbanAirshipCredentials(string appKey, string appSecret, string alias)
	{
	}

	public static void setPushIOCredentials(string apiKey)
	{
	}

	public static void setPushIOCredentials(string apiKey, string[] categories)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraRegisterForRemoteNotifications(int types);

	public static void registerForRemoteNotifcations(P31RemoteNotificationType types)
	{
	}

	[DllImport("__Internal")]
	private static extern int _etceteraGetEnabledRemoteNotificationTypes();

	public static P31RemoteNotificationType getEnabledRemoteNotificationTypes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern int _etceteraGetBadgeCount();

	public static int getBadgeCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern void _etceteraSetBadgeCount(int badgeCount);

	public static void setBadgeCount(int badgeCount)
	{
	}

	[DllImport("__Internal")]
	private static extern int _etceteraGetStatusBarOrientation();

	public static UIInterfaceOrientation getStatusBarOrientation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern string _etceteraUniqueDeviceIdentifier();

	public static string uniqueDeviceIdentifier()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern string _etceteraUniqueGlobalDeviceIdentifier();

	public static string uniqueGlobalDeviceIdentifier()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewShow(int x, int y, int width, int height);

	public static void inlineWebViewShow(int x, int y, int width, int height)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewClose();

	public static void inlineWebViewClose()
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewSetUrl(string url);

	public static void inlineWebViewSetUrl(string url)
	{
	}

	[DllImport("__Internal")]
	private static extern void _etceteraInlineWebViewSetFrame(int x, int y, int width, int height);

	public static void inlineWebViewSetFrame(int x, int y, int width, int height)
	{
	}
}
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
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action imagePickerCancelledEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> imagePickerChoseImageEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action saveImageToPhotoAlbumSucceededEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> saveImageToPhotoAlbumFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> alertButtonClickedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action promptCancelledEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> singleFieldPromptTextEnteredEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string, string> twoFieldPromptTextEnteredEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> remoteRegistrationSucceededEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> remoteRegistrationFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action urbanAirshipRegistrationSucceededEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> urbanAirshipRegistrationFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> pushIORegistrationCompletedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<IDictionary> remoteNotificationReceivedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<IDictionary> remoteNotificationReceivedAtLaunchEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<IDictionary> localNotificationWasReceivedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<IDictionary> localNotificationWasReceivedAtLaunchEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> mailComposerFinishedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> smsComposerFinishedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
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
public class CubeRotator : MonoBehaviour
{
	public float speed;

	private Transform cube;

	private bool shouldRotate;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void togglePauseRotation()
	{
	}
}
public class EtceteraEventListener : MonoBehaviour
{
	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void dismissingViewControllerEvent()
	{
	}

	private void imagePickerCancelled()
	{
	}

	private void imagePickerChoseImage(string imagePath)
	{
	}

	private void saveImageToPhotoAlbumSucceededEvent()
	{
	}

	private void saveImageToPhotoAlbumFailedEvent(string error)
	{
	}

	private void alertButtonClicked(string text)
	{
	}

	private void promptCancelled()
	{
	}

	private void singleFieldPromptTextEntered(string text)
	{
	}

	private void twoFieldPromptTextEntered(string textOne, string textTwo)
	{
	}

	private void remoteRegistrationSucceeded(string deviceToken)
	{
	}

	private void remoteRegistrationFailed(string error)
	{
	}

	private void pushIORegistrationCompletedEvent(string error)
	{
	}

	private void urbanAirshipRegistrationSucceeded()
	{
	}

	private void urbanAirshipRegistrationFailed(string error)
	{
	}

	private void remoteNotificationReceived(IDictionary notification)
	{
	}

	private void remoteNotificationReceivedAtLaunch(IDictionary notification)
	{
	}

	private void localNotificationWasReceivedEvent(IDictionary notification)
	{
	}

	private void localNotificationWasReceivedAtLaunchEvent(IDictionary notification)
	{
	}

	private void mailComposerFinished(string result)
	{
	}

	private void smsComposerFinished(string result)
	{
	}
}
public class EtceteraGUIManager : MonoBehaviourGUI
{
	private void Start()
	{
	}

	private void OnGUI()
	{
	}
}
public class EtceteraGUIManagerThree : MonoBehaviourGUI
{
	private void OnGUI()
	{
	}
}
public class EtceteraGUIManagerTwo : MonoBehaviourGUI
{
	public GameObject testPlane;

	private string imagePath;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGUI()
	{
	}

	private void imagePickerChoseImage(string imagePath)
	{
	}

	[DebuggerHidden]
	public IEnumerator hideActivityView()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void textureLoaded(Texture2D texture)
	{
	}

	public void textureLoadFailed(string error)
	{
	}
}
namespace LitJson
{
	public enum JsonType
	{
		None,
		Object,
		Array,
		String,
		Int,
		Long,
		Double,
		Boolean
	}
	public interface IJsonWrapper : ICollection, IDictionary, IList, IEnumerable, IOrderedDictionary
	{
		bool IsArray { get; }

		bool IsBoolean { get; }

		bool IsDouble { get; }

		bool IsInt { get; }

		bool IsLong { get; }

		bool IsObject { get; }

		bool IsString { get; }

		bool GetBoolean();

		double GetDouble();

		int GetInt();

		JsonType GetJsonType();

		long GetLong();

		string GetString();

		void SetBoolean(bool val);

		void SetDouble(double val);

		void SetInt(int val);

		void SetJsonType(JsonType type);

		void SetLong(long val);

		void SetString(string val);

		string ToJson();

		void ToJson(JsonWriter writer);
	}
	public class JsonData : ICollection, IJsonWrapper, IDictionary, IList, IEnumerable, IOrderedDictionary, IEquatable<JsonData>
	{
		private IList<JsonData> inst_array;

		private bool inst_boolean;

		private double inst_double;

		private int inst_int;

		private long inst_long;

		private IDictionary<string, JsonData> inst_object;

		private string inst_string;

		private string json;

		private JsonType type;

		private IList<KeyValuePair<string, JsonData>> object_list;

		int ICollection.Count
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool ICollection.IsSynchronized
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object ICollection.SyncRoot
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IDictionary.IsFixedSize
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IDictionary.IsReadOnly
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		ICollection IDictionary.Keys
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		ICollection IDictionary.Values
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IJsonWrapper.IsArray
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IJsonWrapper.IsBoolean
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IJsonWrapper.IsDouble
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IJsonWrapper.IsInt
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IJsonWrapper.IsLong
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IJsonWrapper.IsObject
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IJsonWrapper.IsString
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IList.IsFixedSize
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		bool IList.IsReadOnly
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IDictionary.this[object key]
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		object IOrderedDictionary.this[int idx]
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		object IList.this[int index]
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public int Count
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool IsArray
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool IsBoolean
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool IsDouble
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool IsInt
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool IsLong
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool IsObject
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool IsString
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public JsonData this[string prop_name]
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public JsonData this[int index]
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public JsonData()
		{
		}

		public JsonData(bool boolean)
		{
		}

		public JsonData(double number)
		{
		}

		public JsonData(int number)
		{
		}

		public JsonData(long number)
		{
		}

		public JsonData(object obj)
		{
		}

		public JsonData(string str)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		void IDictionary.Add(object key, object value)
		{
		}

		void IDictionary.Clear()
		{
		}

		bool IDictionary.Contains(object key)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		void IDictionary.Remove(object key)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		bool IJsonWrapper.GetBoolean()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		double IJsonWrapper.GetDouble()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		int IJsonWrapper.GetInt()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		long IJsonWrapper.GetLong()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		string IJsonWrapper.GetString()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		void IJsonWrapper.SetBoolean(bool val)
		{
		}

		void IJsonWrapper.SetDouble(double val)
		{
		}

		void IJsonWrapper.SetInt(int val)
		{
		}

		void IJsonWrapper.SetLong(long val)
		{
		}

		void IJsonWrapper.SetString(string val)
		{
		}

		string IJsonWrapper.ToJson()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		void IJsonWrapper.ToJson(JsonWriter writer)
		{
		}

		int IList.Add(object value)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object value)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		int IList.IndexOf(object value)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		void IOrderedDictionary.Insert(int idx, object key, object value)
		{
		}

		void IOrderedDictionary.RemoveAt(int idx)
		{
		}

		private ICollection EnsureCollection()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private IDictionary EnsureDictionary()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private IList EnsureList()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private JsonData ToJsonData(object obj)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		public int Add(object value)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void Clear()
		{
		}

		public bool Equals(JsonData x)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public JsonType GetJsonType()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void SetJsonType(JsonType type)
		{
		}

		public string ToJson()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void ToJson(JsonWriter writer)
		{
		}

		public override string ToString()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static implicit operator JsonData(bool data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static implicit operator JsonData(double data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static implicit operator JsonData(int data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static implicit operator JsonData(long data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static implicit operator JsonData(string data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static explicit operator bool(JsonData data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static explicit operator double(JsonData data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static explicit operator int(JsonData data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static explicit operator long(JsonData data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static explicit operator string(JsonData data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}
	internal class OrderedDictionaryEnumerator : IEnumerator, IDictionaryEnumerator
	{
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;

		public object Current
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public DictionaryEntry Entry
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public object Key
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public object Value
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		public bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void Reset()
		{
		}
	}
	public class JsonException : ApplicationException
	{
		public JsonException()
		{
		}

		internal JsonException(ParserToken token)
		{
		}

		internal JsonException(ParserToken token, Exception inner_exception)
		{
		}

		internal JsonException(int c)
		{
		}

		internal JsonException(int c, Exception inner_exception)
		{
		}

		public JsonException(string message)
		{
		}

		public JsonException(string message, Exception inner_exception)
		{
		}
	}
	internal struct PropertyMetadata
	{
		public MemberInfo Info;

		public bool IsField;

		public Type Type;
	}
	internal struct ArrayMetadata
	{
		private Type element_type;

		private bool is_array;

		private bool is_list;

		public Type ElementType
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public bool IsArray
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public bool IsList
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}
	}
	internal struct ObjectMetadata
	{
		private Type element_type;

		private bool is_dictionary;

		private IDictionary<string, PropertyMetadata> properties;

		public Type ElementType
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public bool IsDictionary
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public IDictionary<string, PropertyMetadata> Properties
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}
	}
	public class JsonMapper
	{
		private static int max_nesting_depth;

		private static IFormatProvider datetime_format;

		private static IDictionary<Type, ExporterFunc> base_exporters_table;

		private static IDictionary<Type, ExporterFunc> custom_exporters_table;

		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

		private static IDictionary<Type, ArrayMetadata> array_metadata;

		private static readonly object array_metadata_lock;

		private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

		private static readonly object conv_ops_lock;

		private static IDictionary<Type, ObjectMetadata> object_metadata;

		private static readonly object object_metadata_lock;

		private static IDictionary<Type, IList<PropertyMetadata>> type_properties;

		private static readonly object type_properties_lock;

		private static JsonWriter static_writer;

		private static readonly object static_writer_lock;

		static JsonMapper()
		{
		}

		private static void AddArrayMetadata(Type type)
		{
		}

		private static void AddObjectMetadata(Type type)
		{
		}

		private static void AddTypeProperties(Type type)
		{
		}

		private static MethodInfo GetConvOp(Type t1, Type t2)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static object ReadValue(Type inst_type, JsonReader reader)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static void RegisterBaseExporters()
		{
		}

		private static void RegisterBaseImporters()
		{
		}

		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
		{
		}

		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
		{
		}

		public static string ToJson(object obj)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static void ToJson(object obj, JsonWriter writer)
		{
		}

		public static JsonData ToObject(JsonReader reader)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static JsonData ToObject(TextReader reader)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static JsonData ToObject(string json)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static T ToObject<T>(JsonReader reader)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static T ToObject<T>(TextReader reader)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static T ToObject<T>(string json)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static void RegisterExporter<T>(ExporterFunc<T> exporter)
		{
		}

		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
		{
		}

		public static void UnregisterExporters()
		{
		}

		public static void UnregisterImporters()
		{
		}
	}
	public enum JsonToken
	{
		None,
		ObjectStart,
		PropertyName,
		ObjectEnd,
		ArrayStart,
		ArrayEnd,
		Int,
		Long,
		Double,
		String,
		Boolean,
		Null
	}
	public class JsonReader
	{
		private static IDictionary<int, IDictionary<int, int[]>> parse_table;

		private Stack<int> automaton_stack;

		private int current_input;

		private int current_symbol;

		private bool end_of_json;

		private bool end_of_input;

		private Lexer lexer;

		private bool parser_in_string;

		private bool parser_return;

		private bool read_started;

		private TextReader reader;

		private bool reader_is_owned;

		private object token_value;

		private JsonToken token;

		public bool AllowComments
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public bool AllowSingleQuotedStrings
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public bool EndOfInput
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool EndOfJson
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public JsonToken Token
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public object Value
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public JsonReader(string json_text)
		{
		}

		public JsonReader(TextReader reader)
		{
		}

		private JsonReader(TextReader reader, bool owned)
		{
		}

		static JsonReader()
		{
		}

		private static void PopulateParseTable()
		{
		}

		private static void TableAddCol(ParserToken row, int col, params int[] symbols)
		{
		}

		private static void TableAddRow(ParserToken rule)
		{
		}

		private void ProcessNumber(string number)
		{
		}

		private void ProcessSymbol()
		{
		}

		private bool ReadToken()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void Close()
		{
		}

		public bool Read()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}
	internal enum Condition
	{
		InArray,
		InObject,
		NotAProperty,
		Property,
		Value
	}
	internal class WriterContext
	{
		public int Count;

		public bool InArray;

		public bool InObject;

		public bool ExpectingValue;

		public int Padding;
	}
	public class JsonWriter
	{
		private static NumberFormatInfo number_format;

		private WriterContext context;

		private Stack<WriterContext> ctx_stack;

		private bool has_reached_end;

		private char[] hex_seq;

		private int indentation;

		private int indent_value;

		private StringBuilder inst_string_builder;

		private bool pretty_print;

		private bool validate;

		private TextWriter writer;

		public int IndentValue
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public bool PrettyPrint
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public TextWriter TextWriter
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool Validate
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public JsonWriter()
		{
		}

		public JsonWriter(StringBuilder sb)
		{
		}

		public JsonWriter(TextWriter writer)
		{
		}

		static JsonWriter()
		{
		}

		private void DoValidation(Condition cond)
		{
		}

		private void Init()
		{
		}

		private static void IntToHex(int n, char[] hex)
		{
		}

		private void Indent()
		{
		}

		private void Put(string str)
		{
		}

		private void PutNewline()
		{
		}

		private void PutNewline(bool add_comma)
		{
		}

		private void PutString(string str)
		{
		}

		private void Unindent()
		{
		}

		public override string ToString()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public void Reset()
		{
		}

		public void Write(bool boolean)
		{
		}

		public void Write(decimal number)
		{
		}

		public void Write(double number)
		{
		}

		public void Write(int number)
		{
		}

		public void Write(long number)
		{
		}

		public void Write(string str)
		{
		}

		public void Write(ulong number)
		{
		}

		public void WriteArrayEnd()
		{
		}

		public void WriteArrayStart()
		{
		}

		public void WriteObjectEnd()
		{
		}

		public void WriteObjectStart()
		{
		}

		public void WritePropertyName(string property_name)
		{
		}
	}
	internal class FsmContext
	{
		public bool Return;

		public int NextState;

		public Lexer L;

		public int StateStack;
	}
	internal class Lexer
	{
		private delegate bool StateHandler(FsmContext ctx);

		private static int[] fsm_return_table;

		private static StateHandler[] fsm_handler_table;

		private bool allow_comments;

		private bool allow_single_quoted_strings;

		private bool end_of_input;

		private FsmContext fsm_context;

		private int input_buffer;

		private int input_char;

		private TextReader reader;

		private int state;

		private StringBuilder string_buffer;

		private string string_value;

		private int token;

		private int unichar;

		public bool AllowComments
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public bool AllowSingleQuotedStrings
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public bool EndOfInput
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public int Token
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public string StringValue
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public Lexer(TextReader reader)
		{
		}

		static Lexer()
		{
		}

		private static int HexValue(int digit)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static void PopulateFsmTables()
		{
		}

		private static char ProcessEscChar(int esc_char)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State1(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State2(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State3(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State4(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State5(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State6(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State7(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State8(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State9(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State10(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State11(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State12(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State13(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State14(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State15(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State16(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State17(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State18(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State19(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State20(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State21(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State22(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State23(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State24(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State25(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State26(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State27(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State28(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private bool GetChar()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private int NextChar()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public bool NextToken()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private void UngetChar()
		{
		}
	}
	internal enum ParserToken
	{
		None = 65536,
		Number,
		True,
		False,
		Null,
		CharSeq,
		Char,
		Text,
		Object,
		ObjectPrime,
		Pair,
		PairRest,
		Array,
		ArrayPrime,
		Value,
		ValueRest,
		String,
		End,
		Epsilon
	}
}
public enum FacebookSessionDefaultAudience
{
	None = 0,
	OnlyMe = 10,
	Friends = 20,
	Everyone = 30
}
public enum FacebookSessionLoginBehavior
{
	WithFallbackToWebView,
	WithNoFallbackToWebView,
	ForcingWebView,
	UseSystemAccountIfPresent
}
public class FacebookBinding
{
	static FacebookBinding()
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookInit();

	public static void init()
	{
	}

	[DllImport("__Internal")]
	private static extern string _facebookGetAppLaunchUrl();

	public static string getAppLaunchUrl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern void _facebookSetSessionLoginBehavior(int behavior);

	public static void setSessionLoginBehavior(FacebookSessionLoginBehavior loginBehavior)
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookEnableFrictionlessRequests();

	public static void enableFrictionlessRequests()
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookRenewCredentialsForAllFacebookAccounts();

	public static void renewCredentialsForAllFacebookAccounts()
	{
	}

	[DllImport("__Internal")]
	private static extern bool _facebookIsLoggedIn();

	public static bool isSessionValid()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern string _facebookGetFacebookAccessToken();

	public static string getAccessToken()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern string _facebookGetSessionPermissions();

	public static List<object> getSessionPermissions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern void _facebookLoginUsingDeprecatedAuthorizationFlowWithRequestedPermissions(string perms, string urlSchemeSuffix);

	[Obsolete("Note that this auth flow has been deprecated by Facebook and could be removed at any time at Facebook's discretion")]
	public static void loginUsingDeprecatedAuthorizationFlowWithRequestedPermissions(string[] permissions)
	{
	}

	[Obsolete("Note that this auth flow has been deprecated by Facebook and could be removed at any time at Facebook's discretion")]
	public static void loginUsingDeprecatedAuthorizationFlowWithRequestedPermissions(string[] permissions, string urlSchemeSuffix)
	{
	}

	public static void login()
	{
	}

	public static void loginWithReadPermissions(string[] permissions)
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookLoginWithRequestedPermissions(string perms, string urlSchemeSuffix);

	public static void loginWithReadPermissions(string[] permissions, string urlSchemeSuffix)
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookReauthorizeWithReadPermissions(string perms);

	public static void reauthorizeWithReadPermissions(string[] permissions)
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookReauthorizeWithPublishPermissions(string perms, int defaultAudience);

	public static void reauthorizeWithPublishPermissions(string[] permissions, FacebookSessionDefaultAudience defaultAudience)
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookLogout();

	public static void logout()
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookShowDialog(string dialogType, string json);

	public static void showDialog(string dialogType, Dictionary<string, string> options)
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookRestRequest(string restMethod, string httpMethod, string jsonDict);

	public static void restRequest(string restMethod, string httpMethod, Hashtable keyValueHash)
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookGraphRequest(string graphPath, string httpMethod, string jsonDict);

	public static void graphRequest(string graphPath, string httpMethod, Hashtable keyValueHash)
	{
	}

	[DllImport("__Internal")]
	private static extern bool _facebookIsFacebookComposerSupported();

	public static bool isFacebookComposerSupported()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern bool _facebookCanUserUseFacebookComposer();

	public static bool canUserUseFacebookComposer()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern void _facebookShowFacebookComposer(string message, string imagePath, string link);

	public static void showFacebookComposer(string message)
	{
	}

	public static void showFacebookComposer(string message, string imagePath, string link)
	{
	}

	[DllImport("__Internal")]
	private static extern void _facebookShowFacebookShareDialog(string json);

	public static void showFacebookShareDialog(Dictionary<string, object> parameters)
	{
	}
}
public class Facebook : P31RestKit
{
	public string accessToken;

	public string appAccessToken;

	private static Facebook _instance;

	public static Facebook instance
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	protected override IEnumerator send(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters, Action<string, object> onComplete)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void prepareForMetroUse(GameObject go, MonoBehaviour mb)
	{
	}

	public void graphRequest(string path, Action<string, object> completionHandler)
	{
	}

	public void graphRequest(string path, HTTPVerb verb, Action<string, object> completionHandler)
	{
	}

	public void graphRequest(string path, HTTPVerb verb, Dictionary<string, object> parameters, Action<string, object> completionHandler)
	{
	}

	public void graphRequestBatch(IEnumerable<FacebookBatchRequest> requests, Action<string, object> completionHandler)
	{
	}

	public void restRequest(string method, HTTPVerb verb, Dictionary<string, object> parameters, Action<string, object> completionHandler)
	{
	}

	public void postMessage(string message, Action<string, object> completionHandler)
	{
	}

	public void postMessageWithLink(string message, string link, string linkName, Action<string, object> completionHandler)
	{
	}

	public void postMessageWithLinkAndLinkToImage(string message, string link, string linkName, string linkToImage, string caption, Action<string, object> completionHandler)
	{
	}

	public void postImage(byte[] image, string message, Action<string, object> completionHandler)
	{
	}

	public void postImageToAlbum(byte[] image, string caption, string albumId, Action<string, object> completionHandler)
	{
	}

	public void getFriends(Action<string, object> completionHandler)
	{
	}

	public void extendAccessToken(string appId, string appSecret, Action<DateTime?> completionHandler)
	{
	}

	public void getAppAccessToken(string appId, string appSecret, Action<string> completionHandler)
	{
	}

	public void postScore(string userId, int score, Action<bool> completionHandler)
	{
	}

	public void getScores(string userId, Action<string, object> onComplete)
	{
	}
}
public class FacebookBatchRequest
{
	public Dictionary<string, string> _parameters;

	private Dictionary<string, object> _requestDict;

	public FacebookBatchRequest(string relativeUrl, string method)
	{
	}

	public void addParameter(string key, string value)
	{
	}

	public Dictionary<string, object> requestDictionary()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class FacebookEventListener : MonoBehaviour
{
	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void sessionOpenedEvent()
	{
	}

	private void loginFailedEvent(string error)
	{
	}

	private void dialogCompletedEvent(string url)
	{
	}

	private void dialogFailedEvent(string error)
	{
	}

	private void facebokDialogCompleted()
	{
	}

	private void graphRequestCompletedEvent(object obj)
	{
	}

	private void facebookCustomRequestFailed(string error)
	{
	}

	private void restRequestCompletedEvent(object obj)
	{
	}

	private void restRequestFailedEvent(string error)
	{
	}

	private void facebookComposerCompletedEvent(bool didSucceed)
	{
	}

	private void reauthorizationSucceededEvent()
	{
	}

	private void reauthorizationFailedEvent(string error)
	{
	}

	private void shareDialogFailedEvent(string error)
	{
	}

	private void shareDialogSucceededEvent(Dictionary<string, object> dict)
	{
	}
}
public class FacebookManager : AbstractManager
{
	public static event Action sessionOpenedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action preLoginSucceededEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> loginFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> dialogCompletedWithUrlEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> dialogFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<object> graphRequestCompletedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> graphRequestFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<object> restRequestCompletedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> restRequestFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<bool> facebookComposerCompletedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action reauthorizationSucceededEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> reauthorizationFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> shareDialogFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<Dictionary<string, object>> shareDialogSucceededEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
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
public class SharingBinding
{
	[DllImport("__Internal")]
	private static extern void _sharingShareItems(string items, string excludedActivityTypes);

	public static void shareItems(string[] items)
	{
	}

	public static void shareItems(string[] items, string[] excludedActivityTypes)
	{
	}
}
public class SharingManager : AbstractManager
{
	public static event Action<string> sharingFinishedWithActivityTypeEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action sharingCancelledEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
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
public class TwitterBinding
{
	[DllImport("__Internal")]
	private static extern void _twitterInit(string consumerKey, string consumerSecret);

	public static void init(string consumerKey, string consumerSecret)
	{
	}

	[DllImport("__Internal")]
	private static extern bool _twitterIsLoggedIn();

	public static bool isLoggedIn()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern string _twitterLoggedInUsername();

	public static string loggedInUsername()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern void _twitterLogin(string username, string password);

	public static void login(string username, string password)
	{
	}

	[DllImport("__Internal")]
	private static extern void _twitterShowOauthLoginDialog();

	public static void showOauthLoginDialog()
	{
	}

	[DllImport("__Internal")]
	private static extern void _twitterLogout();

	public static void logout()
	{
	}

	public static void postStatusUpdate(string status)
	{
	}

	[DllImport("__Internal")]
	private static extern void _twitterPostStatusUpdateWithImage(string status, string imagePath);

	public static void postStatusUpdate(string status, string pathToImage)
	{
	}

	public static void getHomeTimeline()
	{
	}

	[DllImport("__Internal")]
	private static extern void _twitterPerformRequest(string methodType, string path, string parameters);

	public static void performRequest(string methodType, string path, Dictionary<string, string> parameters)
	{
	}

	[DllImport("__Internal")]
	private static extern bool _twitterIsTweetSheetSupported();

	public static bool isTweetSheetSupported()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern bool _twitterCanUserTweet();

	public static bool canUserTweet()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern void _twitterShowTweetComposer(string status, string imagePath, string url);

	public static void showTweetComposer(string status)
	{
	}

	public static void showTweetComposer(string status, string pathToImage)
	{
	}

	public static void showTweetComposer(string status, string pathToImage, string link)
	{
	}
}
public class TwitterEventListener : MonoBehaviour
{
	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void loginSucceeded()
	{
	}

	private void loginFailed(string error)
	{
	}

	private void postSucceeded()
	{
	}

	private void postFailed(string error)
	{
	}

	private void homeTimelineFailed(string error)
	{
	}

	private void homeTimelineReceived(List<object> result)
	{
	}

	private void requestDidFailEvent(string error)
	{
	}

	private void requestDidFinishEvent(object result)
	{
	}

	private void tweetSheetCompletedEvent(bool didSucceed)
	{
	}
}
public class TwitterManager : MonoBehaviour
{
	public static event Action loginSucceededEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> loginFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action postSucceededEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> postFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<List<object>> homeTimelineReceivedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> homeTimelineFailedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<object> requestDidFinishEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<string> requestDidFailEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public static event Action<bool> tweetSheetCompletedEvent
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
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
public class FacebookGUIManager : MonoBehaviourGUI
{
	public GameObject cube;

	private string _userId;

	private bool _canUserUseFacebookComposer;

	private bool _hasPublishPermission;

	private bool _hasPublishActions;

	public static string screenshotFilename;

	private void completionHandler(string error, object result)
	{
	}

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	private void secondColumnButtonsGUI()
	{
	}

	private void secondColumnAdditionalButtonsGUI()
	{
	}

	[DebuggerHidden]
	private IEnumerator fetchAndShowProfileImage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
public class SharingGUIManager : MonoBehaviourGUI
{
	public static string screenshotFilename;

	private void Start()
	{
	}

	private void OnGUI()
	{
	}
}
public class TwitterGUIManager : MonoBehaviourGUI
{
	public bool canUseTweetSheet;

	private void Start()
	{
	}

	private void completionHandler(string error, object result)
	{
	}

	private void OnGUI()
	{
	}
}
public interface ISysFontTexturable
{
	string Text { get; set; }

	string AppleFontName { get; set; }

	string AndroidFontName { get; set; }

	string FontName { get; set; }

	int FontSize { get; set; }

	bool IsBold { get; set; }

	bool IsItalic { get; set; }

	SysFont.Alignment Alignment { get; set; }

	bool IsMultiLine { get; set; }

	int MaxWidthPixels { get; set; }

	int MaxHeightPixels { get; set; }

	int WidthPixels { get; }

	int HeightPixels { get; }

	int TextWidthPixels { get; }

	int TextHeightPixels { get; }

	Texture Texture { get; }
}
public class SysFont : MonoBehaviour
{
	public enum Alignment
	{
		Left,
		Center,
		Right
	}

	[DllImport("__Internal")]
	private static extern void _SysFontQueueTexture(string text, string fontName, int fontSize, bool isBold, bool isItalic, Alignment alignment, int maxWidthPixels, int maxHeightPixels, int textureID);

	[DllImport("__Internal")]
	private static extern void _SysFontUpdateQueuedTexture(int textureID);

	[DllImport("__Internal")]
	private static extern void _SysFontDequeueTexture(int textureID);

	[DllImport("__Internal")]
	private static extern int _SysFontGetTextureWidth(int textureID);

	[DllImport("__Internal")]
	private static extern int _SysFontGetTextureHeight(int textureID);

	[DllImport("__Internal")]
	private static extern int _SysFontGetTextWidth(int textureID);

	[DllImport("__Internal")]
	private static extern int _SysFontGetTextHeight(int textureID);

	[DllImport("__Internal")]
	private static extern void _SysFontRender();

	public static int GetTextureWidth(int textureID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int GetTextureHeight(int textureID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int GetTextWidth(int textureID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static int GetTextHeight(int textureID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static void QueueTexture(string text, string fontName, int fontSize, bool isBold, bool isItalic, Alignment alignment, bool isMultiLine, int maxWidthPixels, int maxHeightPixels, int textureID)
	{
	}

	public static void UpdateQueuedTexture(int textureID)
	{
	}

	public static void DequeueTexture(int textureID)
	{
	}

	public static void SafeDestroy(UnityEngine.Object obj)
	{
	}
}
[ExecuteInEditMode]
[AddComponentMenu("SysFont/Text")]
public class SysFontText : MonoBehaviour, ISysFontTexturable
{
	public enum PivotAlignment
	{
		TopLeft,
		Top,
		TopRight,
		Left,
		Center,
		Right,
		BottomLeft,
		Bottom,
		BottomRight
	}

	[SerializeField]
	protected SysFontTexture _texture;

	[SerializeField]
	protected Color _fontColor;

	[SerializeField]
	protected PivotAlignment _pivot;

	protected Color _lastFontColor;

	protected PivotAlignment _lastPivot;

	protected Transform _transform;

	protected Material _createdMaterial;

	protected Material _material;

	protected Vector3[] _vertices;

	protected Vector2[] _uv;

	protected int[] _triangles;

	protected Mesh _mesh;

	protected MeshFilter _filter;

	protected MeshRenderer _renderer;

	protected static Shader _shader;

	public string Text
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string AppleFontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string AndroidFontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string FontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int FontSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsBold
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsItalic
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public SysFont.Alignment Alignment
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsMultiLine
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int MaxWidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int MaxHeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int WidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int HeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int TextWidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int TextHeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Texture Texture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Color FontColor
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public PivotAlignment Pivot
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	protected void UpdateMesh()
	{
	}

	protected void UpdatePivot()
	{
	}

	public void UpdateScale()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void Update()
	{
	}

	protected void OnDestroy()
	{
	}
}
[Serializable]
public class SysFontTexture : ISysFontTexturable
{
	[SerializeField]
	protected string _text;

	[SerializeField]
	protected string _appleFontName;

	[SerializeField]
	protected string _androidFontName;

	[SerializeField]
	protected int _fontSize;

	[SerializeField]
	protected bool _isBold;

	[SerializeField]
	protected bool _isItalic;

	[SerializeField]
	protected SysFont.Alignment _alignment;

	[SerializeField]
	protected bool _isMultiLine;

	[SerializeField]
	protected int _maxWidthPixels;

	[SerializeField]
	protected int _maxHeightPixels;

	protected string _lastText;

	protected string _lastFontName;

	protected int _lastFontSize;

	protected bool _lastIsBold;

	protected bool _lastIsItalic;

	protected SysFont.Alignment _lastAlignment;

	protected bool _lastIsMultiLine;

	protected int _lastMaxWidthPixels;

	protected int _lastMaxHeightPixels;

	protected int _widthPixels;

	protected int _heightPixels;

	protected int _textWidthPixels;

	protected int _textHeightPixels;

	protected Texture _texture;

	public string Text
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string AppleFontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string AndroidFontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public string FontName
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int FontSize
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsBold
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsItalic
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public SysFont.Alignment Alignment
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public bool IsMultiLine
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int MaxWidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int MaxHeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	public int WidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int HeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int TextWidthPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int TextHeightPixels
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Texture Texture
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool NeedsRedraw
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public void Update()
	{
	}

	public void Destroy()
	{
	}
}
namespace LitJson
{
	internal delegate void ExporterFunc(object obj, JsonWriter writer);
	public delegate void ExporterFunc<T>(T obj, JsonWriter writer);
	internal delegate object ImporterFunc(object input);
	public delegate TValue ImporterFunc<TJson, TValue>(TJson input);
	public delegate IJsonWrapper WrapperFactory();
}
