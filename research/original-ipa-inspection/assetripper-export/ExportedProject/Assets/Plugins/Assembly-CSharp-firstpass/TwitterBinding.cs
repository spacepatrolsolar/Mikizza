using System.Collections.Generic;
using System.Runtime.InteropServices;

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
