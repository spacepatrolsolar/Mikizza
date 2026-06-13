using System;
using System.Runtime.InteropServices;
using System.Text;

public class QCARNativeWrapper : IQCARWrapper
{
	public int CameraDeviceInitCamera(int camera)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceDeinitCamera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceStartCamera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceStopCamera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceGetNumVideoModes()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void CameraDeviceGetVideoMode(int idx, [In][Out] IntPtr videoMode)
	{
	}

	public int CameraDeviceSelectVideoMode(int idx)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceSetFlashTorchMode(int on)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceSetFocusMode(int focusMode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int CameraDeviceSetCameraConfiguration(int width, int height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarSetFrameFormat(int format, int enabled)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetExists(string relativePath, int storageType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetGetTrackablesOfType(int trackableType, [In][Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In][Out] IntPtr trackableData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int DataSetHasReachedTrackableLimit(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetBuilderBuild(string targetName, float sceenSizeWidth)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ImageTargetBuilderStartScan()
	{
	}

	public void ImageTargetBuilderStopScan()
	{
	}

	public int ImageTargetBuilderGetFrameQuality()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public IntPtr ImageTargetBuilderGetTrackableSource()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetVirtualButtons([In][Out] IntPtr virtualButtonDataArray, [In][Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerStart()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void ImageTrackerStop()
	{
	}

	public IntPtr ImageTrackerCreateDataSet()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerDestroyDataSet(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerActivateDataSet(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int ImageTrackerDeactivateDataSet(IntPtr dataSetPtr)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int MarkerTrackerStart()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void MarkerTrackerStop()
	{
	}

	public int MarkerTrackerCreateMarker(int id, string trackableName, float size)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int MarkerTrackerDestroyMarker(int trackableId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void InitFrameState([In][Out] IntPtr frameIndex)
	{
	}

	public void DeinitFrameState([In][Out] IntPtr frameIndex)
	{
	}

	public void UpdateQCAR([In][Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In][Out] IntPtr frameIndex, int screenOrientation)
	{
	}

	public int QcarGetBufferSize(int width, int height, int format)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void QcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally)
	{
	}

	public void RendererSetVideoBackgroundCfg([In][Out] IntPtr bgCfg)
	{
	}

	public void RendererGetVideoBackgroundCfg([In][Out] IntPtr bgCfg)
	{
	}

	public void RendererGetVideoBackgroundTextureInfo([In][Out] IntPtr texInfo)
	{
	}

	public int RendererSetVideoBackgroundTextureID(int textureID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int RendererIsVideoBackgroundTextureInfoAvailable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int GetInitErrorCode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int IsRendererDirty()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarSetHint(int hint, int value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarRequiresAlpha()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int GetProjectionGL(float nearClip, float farClip, [In][Out] IntPtr projMatrix, int screenOrientation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void SetUnityVersion(int major, int minor, int change)
	{
	}

	public int TargetFinderStartInit(string userKey, string secretKey)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderGetInitState()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderDeinit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderStartRecognition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderStop()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void TargetFinderSetUIScanlineColor(float r, float g, float b)
	{
	}

	public void TargetFinderSetUIPointColor(float r, float g, float b)
	{
	}

	public void TargetFinderUpdate([In][Out] IntPtr targetFinderState)
	{
	}

	public int TargetFinderGetResults([In][Out] IntPtr searchResultArray, int searchResultArrayLength)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TargetFinderEnableTracking(IntPtr searchResult, [In][Out] IntPtr trackableData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void TargetFinderGetImageTargets([In][Out] IntPtr trackableIdArray, int trackableIdArrayLength)
	{
	}

	public void TargetFinderClearTrackables()
	{
	}

	public int TrackerManagerInitTracker(int trackerType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int TrackerManagerDeinitTracker(int trackerType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int VirtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int GetSurfaceOrientation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public int QcarDeinit()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[DllImport("__Internal")]
	private static extern int cameraDeviceInitCamera(int camera);

	[DllImport("__Internal")]
	private static extern int cameraDeviceDeinitCamera();

	[DllImport("__Internal")]
	private static extern int cameraDeviceStartCamera();

	[DllImport("__Internal")]
	private static extern int cameraDeviceStopCamera();

	[DllImport("__Internal")]
	private static extern int cameraDeviceGetNumVideoModes();

	[DllImport("__Internal")]
	private static extern void cameraDeviceGetVideoMode(int idx, [In][Out] IntPtr videoMode);

	[DllImport("__Internal")]
	private static extern int cameraDeviceSelectVideoMode(int idx);

	[DllImport("__Internal")]
	private static extern int cameraDeviceSetFlashTorchMode(int on);

	[DllImport("__Internal")]
	private static extern int cameraDeviceSetFocusMode(int focusMode);

	[DllImport("__Internal")]
	private static extern int qcarSetFrameFormat(int format, int enabled);

	[DllImport("__Internal")]
	private static extern int dataSetExists(string relativePath, int storageType);

	[DllImport("__Internal")]
	private static extern int dataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int dataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int dataSetGetTrackablesOfType(int trackableType, [In][Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int dataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength);

	[DllImport("__Internal")]
	private static extern int dataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In][Out] IntPtr trackableData);

	[DllImport("__Internal")]
	private static extern int dataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId);

	[DllImport("__Internal")]
	private static extern int dataSetHasReachedTrackableLimit(IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int imageTargetBuilderBuild(string targetName, float sceenSizeWidth);

	[DllImport("__Internal")]
	private static extern void imageTargetBuilderStartScan();

	[DllImport("__Internal")]
	private static extern void imageTargetBuilderStopScan();

	[DllImport("__Internal")]
	private static extern int imageTargetBuilderGetFrameQuality();

	[DllImport("__Internal")]
	private static extern IntPtr imageTargetBuilderGetTrackableSource();

	[DllImport("__Internal")]
	private static extern int imageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData);

	[DllImport("__Internal")]
	private static extern int imageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName);

	[DllImport("__Internal")]
	private static extern int virtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName);

	[DllImport("__Internal")]
	private static extern int imageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName);

	[DllImport("__Internal")]
	private static extern int imageTargetGetVirtualButtons([In][Out] IntPtr virtualButtonDataArray, [In][Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName);

	[DllImport("__Internal")]
	private static extern int imageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength);

	[DllImport("__Internal")]
	private static extern int imageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size);

	[DllImport("__Internal")]
	private static extern int imageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size);

	[DllImport("__Internal")]
	private static extern int imageTrackerStart();

	[DllImport("__Internal")]
	private static extern void imageTrackerStop();

	[DllImport("__Internal")]
	private static extern IntPtr imageTrackerCreateDataSet();

	[DllImport("__Internal")]
	private static extern int imageTrackerDestroyDataSet(IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int imageTrackerActivateDataSet(IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int imageTrackerDeactivateDataSet(IntPtr dataSetPtr);

	[DllImport("__Internal")]
	private static extern int markerTrackerStart();

	[DllImport("__Internal")]
	private static extern void markerTrackerStop();

	[DllImport("__Internal")]
	private static extern int markerTrackerCreateMarker(int id, string trackableName, float size);

	[DllImport("__Internal")]
	private static extern int markerTrackerDestroyMarker(int trackableId);

	[DllImport("__Internal")]
	private static extern void initFrameState([In][Out] IntPtr frameIndex);

	[DllImport("__Internal")]
	private static extern void deinitFrameState([In][Out] IntPtr frameIndex);

	[DllImport("__Internal")]
	private static extern void updateQCAR([In][Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In][Out] IntPtr frameIndex, int screenOrientation);

	[DllImport("__Internal")]
	private static extern int qcarGetBufferSize(int width, int height, int format);

	private static void qcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally)
	{
	}

	[DllImport("__Internal")]
	private static extern void rendererSetVideoBackgroundCfg([In][Out] IntPtr bgCfg);

	[DllImport("__Internal")]
	private static extern void rendererGetVideoBackgroundCfg([In][Out] IntPtr bgCfg);

	[DllImport("__Internal")]
	private static extern void rendererGetVideoBackgroundTextureInfo([In][Out] IntPtr texInfo);

	[DllImport("__Internal")]
	private static extern int rendererSetVideoBackgroundTextureID(int textureID);

	[DllImport("__Internal")]
	private static extern int rendererIsVideoBackgroundTextureInfoAvailable();

	[DllImport("__Internal")]
	private static extern int getInitErrorCode();

	[DllImport("__Internal")]
	private static extern int isRendererDirty();

	[DllImport("__Internal")]
	private static extern int qcarSetHint(int hint, int value);

	[DllImport("__Internal")]
	private static extern int qcarRequiresAlpha();

	[DllImport("__Internal")]
	private static extern int getProjectionGL(float nearClip, float farClip, [In][Out] IntPtr projMatrix, int screenOrientation);

	[DllImport("__Internal")]
	private static extern void setUnityVersion(int major, int minor, int change);

	[DllImport("__Internal")]
	private static extern int targetFinderStartInit(string userKey, string secretKey);

	[DllImport("__Internal")]
	private static extern int targetFinderGetInitState();

	[DllImport("__Internal")]
	private static extern int targetFinderDeinit();

	[DllImport("__Internal")]
	private static extern int targetFinderStartRecognition();

	[DllImport("__Internal")]
	private static extern int targetFinderStop();

	[DllImport("__Internal")]
	private static extern void targetFinderSetUIScanlineColor(float r, float g, float b);

	[DllImport("__Internal")]
	private static extern void targetFinderSetUIPointColor(float r, float g, float b);

	[DllImport("__Internal")]
	private static extern void targetFinderUpdate([In][Out] IntPtr targetFinderState);

	[DllImport("__Internal")]
	private static extern int targetFinderGetResults([In][Out] IntPtr searchResultArray, int searchResultArrayLength);

	[DllImport("__Internal")]
	private static extern int targetFinderEnableTracking(IntPtr searchResult, [In][Out] IntPtr trackableData);

	[DllImport("__Internal")]
	private static extern void targetFinderGetImageTargets([In][Out] IntPtr trackableIdArray, int trackableIdArrayLength);

	[DllImport("__Internal")]
	private static extern void targetFinderClearTrackables();

	[DllImport("__Internal")]
	private static extern int trackerManagerInitTracker(int trackerType);

	[DllImport("__Internal")]
	private static extern int trackerManagerDeinitTracker(int trackerType);

	[DllImport("__Internal")]
	private static extern int virtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled);

	[DllImport("__Internal")]
	private static extern int virtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity);

	[DllImport("__Internal")]
	private static extern int virtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData);

	[DllImport("__Internal")]
	private static extern int getSurfaceOrientation();

	[DllImport("__Internal")]
	private static extern int qcarDeinit();
}
