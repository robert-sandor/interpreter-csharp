using System;
using InterpreterCSharp.Source.domain.adts;

namespace InterpreterCSharp.Source.domain.expressions
{
	[Serializable] public class ReadHeapExpression : IExpression
	{
		private readonly string _varname;

		public ReadHeapExpression (string varname)
		{
			_varname = varname;
		}

		public int Evaluate (IDictionary<string, int> symbolTable, IList<int> heap)
		{
			var addr = symbolTable.Get (_varname);
			return heap.Get (addr);
		}

		public override string ToString ()
		{
			return " read_heap ( " + _varname + " ) ";
		}
	}
}