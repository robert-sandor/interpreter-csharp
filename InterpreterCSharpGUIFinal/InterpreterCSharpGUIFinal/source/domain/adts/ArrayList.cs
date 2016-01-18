using System;
using InterpreterCSharp.Source.exceptions.domain;

namespace InterpreterCSharp.Source.domain.adts
{
	[Serializable] public class ArrayList : IList<string>
	{
		private const int Capacity = 100;
		private readonly string[] _array;
		private int _size;

		public ArrayList ()
		{
			_array = new string[Capacity];
			_size = 0;
		}

		public void Add (string element)
		{
			if (_size >= Capacity) {
				throw new ArrayOverflowException ();
			}

			_array [_size] = element;
			_size++;
		}

		public void Update (int index, string element)
		{
			if (index < 0 || index >= _size) {
				throw new IndexOutOfBoundsException ();
			}

			_array [index] = element;
		}

		public string Get (int index)
		{
			if (index < 0 || index >= _size) {
				throw new IndexOutOfBoundsException ();
			}

			return _array [index];
		}

		public int Size ()
		{
			return _size;
		}

		public override string ToString ()
		{
			var output = "";
			for (var i = 0; i < _size; i++) {
				output += _array [_size] + "\n";
			}
			return output;
		}
	}
}