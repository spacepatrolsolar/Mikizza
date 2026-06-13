using System;
using System.Collections;
using System.Collections.Generic;
using Prime31;
using UnityEngine;

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
