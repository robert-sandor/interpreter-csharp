using System;
using InterpreterCSharp.Source.domain.expressions;

namespace InterpreterCSharp.Source.domain.statements
{
	[Serializable] public class NewStatement : IStatement
	{
		private readonly IExpression _expression;
		private readonly string _varname;

		public NewStatement (string varname, IExpression expression)
		{
			_varname = varname;
			_expression = expression;
		}

		public ProgramState Execute (ProgramState state)
		{
			state.Heap.Add (_expression.Evaluate (state.SymbolTable, state.Heap));
			state.SymbolTable.Put (_varname, state.Heap.Size () - 1);
			return state;
		}

		public override string ToString ()
		{
			return " new ( " + _varname + " , " + _expression.ToString () + " ) ";
		}
	}
}