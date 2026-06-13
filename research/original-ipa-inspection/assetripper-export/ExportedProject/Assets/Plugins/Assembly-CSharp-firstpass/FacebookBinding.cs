using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
