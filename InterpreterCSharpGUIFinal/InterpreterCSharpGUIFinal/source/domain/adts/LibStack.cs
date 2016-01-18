using System;
using System.Collections.Generic;

namespace InterpreterCSharp.Source.domain.adts
{
	[Serializable] public class LibStack<E> : IStack<E>
	{
		private readonly Stack<E> _stack;

		public LibStack ()
		{
			_stack = new Stack<E> ();
		}

		public void Push (E element)
		{
			_stack.Push (element);
		}

		public E Pop ()
		{
			return _stack.Pop ();
		}

		public bool IsEmpty ()
		{
			return _stack.Count == 0;
		}

		public override string ToString ()
		{
			var output = "";
			foreach (var e in _stack) {
				output += e + "\n";
			}
			return output;
		}
	}
}