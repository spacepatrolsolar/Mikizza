using System.Collections.Generic;

public class WebCamProfile
{
	public struct ProfileData
	{
		public QCARRenderer.Vec2I RequestedTextureSize;

		public QCARRenderer.Vec2I ResampledTextureSize;

		public int RequestedFPS;
	}

	private ProfileData mDefaultProfile;

	private readonly Dictionary<string, ProfileData> mProfiles;

	public ProfileData Default
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ProfileData GetProfile(string webcamName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool ProfileAvailable(string webcamName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void LoadAndParseProfiles()
	{
	}
}
