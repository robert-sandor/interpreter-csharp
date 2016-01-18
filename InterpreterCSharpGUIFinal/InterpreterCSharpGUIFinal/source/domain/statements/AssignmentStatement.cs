using System;
using InterpreterCSharp.Source.domain.expressions;

namespace InterpreterCSharp.Source.domain.statements
{
	[Serializable] public class AssignmentStatement : IStatement
	{
		private readonly IExpression _expression;
		private readonly string _varname;

		public AssignmentStatement (string varname, IExpression expression)
		{
			_varname = varname;
			_expression = expression;
		}

		public ProgramState Execute (ProgramState state)
		{
			state.SymbolTable.Put (_varname, _expression.Evaluate (state.SymbolTable, state.Heap));
			return state;
		}

		public override string ToString ()
		{
			return _varname + " = " + _expression.ToString ();
		}
	}
}