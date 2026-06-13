using System.Collections;
using System.Collections.Generic;

namespace LitJson
{
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
}
