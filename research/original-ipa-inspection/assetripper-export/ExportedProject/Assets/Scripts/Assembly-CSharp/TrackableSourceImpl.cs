using System;
using System.Runtime.CompilerServices;

public class TrackableSourceImpl : TrackableSource
{
	public IntPtr TrackableSourcePtr
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

	public TrackableSourceImpl(IntPtr trackableSourcePtr)
	{
	}
}
