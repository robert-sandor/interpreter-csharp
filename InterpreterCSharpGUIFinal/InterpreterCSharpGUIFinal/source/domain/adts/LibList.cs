using System;

namespace InterpreterCSharp.Source.domain.adts
{
	[Serializable] public class LibList<E> : IList<E>
	{
		private readonly System.Collections.ArrayList _list;

		public LibList ()
		{
			_list = new System.Collections.ArrayList ();
		}

		public void Add (E element)
		{
			_list.Add (element);
		}

		public void Update (int index, E element)
		{
			_list [index] = element;
		}

		public E Get (int index)
		{
			return (E)_list [index];
		}

		public int Size ()
		{
			return _list.Count;
		}

		public override string ToString ()
		{
			var output = "";
			foreach (var e in _list) {
				output += e + "\n";
			}
			return output;
		}
	}
}