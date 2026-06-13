using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace LitJson
{
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
}
