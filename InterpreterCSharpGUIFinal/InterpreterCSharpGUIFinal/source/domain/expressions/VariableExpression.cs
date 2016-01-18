using System;
using InterpreterCSharp.Source.domain.adts;

namespace InterpreterCSharp.Source.domain.expressions
{
	[Serializable] public class VariableExpression : IExpression
	{
		private readonly string _varname;

		public VariableExpression (string varname)
		{
			_varname = varname;
		}

		public int Evaluate (IDictionary<string, int> symbolTable, IList<int> heap)
		{
			return symbolTable.Get (_varname);
		}

		public override string ToString ()
		{
			return _varname;
		}
	}
}