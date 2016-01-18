using System;
using System.Collections.Generic;

namespace InterpreterCSharp.Source.domain.adts
{
	[Serializable] public class LibDictionary<K, V> : IDictionary<K, V>
	{
		private readonly Dictionary<K, V> _dictionary;

		public LibDictionary ()
		{
			_dictionary = new Dictionary<K, V> ();
		}

		public LibDictionary (LibDictionary<K, V> tmp)
		{
			_dictionary = new Dictionary<K, V> (tmp._dictionary);
		}

		public void Put (K key, V value)
		{
			if (_dictionary.ContainsKey (key)) {
				_dictionary.Remove (key);
			}
			_dictionary.Add (key, value);
		}

		public V Get (K key)
		{
			return _dictionary [key];
		}

		public override string ToString ()
		{
			var output = "";
			foreach (var e in _dictionary.Keys) {
				output += e + " => " + _dictionary [e] + "\n";
			}
			return output;
		}
	}
}