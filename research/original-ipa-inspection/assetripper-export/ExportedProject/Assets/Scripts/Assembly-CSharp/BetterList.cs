using System;
using System.Collections.Generic;
using System.Diagnostics;

public class BetterList<T>
{
	public T[] buffer;

	public int size;

	public T this[int i]
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		set
		{
		}
	}

	[DebuggerHidden]
	public IEnumerator<T> GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void AllocateMore()
	{
	}

	private void Trim()
	{
	}

	public void Clear()
	{
	}

	public void Release()
	{
	}

	public void Add(T item)
	{
	}

	public void Insert(int index, T item)
	{
	}

	public bool Contains(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public bool Remove(T item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void RemoveAt(int index)
	{
	}

	public T[] ToArray()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public void Sort(Comparison<T> comparer)
	{
	}
}
