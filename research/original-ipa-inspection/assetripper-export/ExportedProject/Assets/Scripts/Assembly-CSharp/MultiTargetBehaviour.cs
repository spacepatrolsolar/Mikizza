public class MultiTargetBehaviour : DataSetTrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorMultiTargetBehaviour, IEditorTrackableBehaviour
{
	private MultiTarget mMultiTarget;

	public MultiTarget MultiTarget
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	void IEditorMultiTargetBehaviour.InitializeMultiTarget(MultiTarget multiTarget)
	{
	}

	protected override void InternalUnregisterTrackable()
	{
	}
}
