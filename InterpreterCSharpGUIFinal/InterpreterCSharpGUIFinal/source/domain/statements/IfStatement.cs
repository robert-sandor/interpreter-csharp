using System;
using InterpreterCSharp.Source.domain.expressions;

namespace InterpreterCSharp.Source.domain.statements
{
	[Serializable] public class IfStatement : IStatement
	{
		private readonly IStatement _elseStatement;
		private readonly IExpression _expression;
		private readonly IStatement _thenStatement;

		public IfStatement (IExpression expression, IStatement thenStatement, IStatement elseStatement)
		{
			_expression = expression;
			_thenStatement = thenStatement;
			_elseStatement = elseStatement;
		}

		public ProgramState Execute (ProgramState state)
		{
			var val = _expression.Evaluate (state.SymbolTable, state.Heap);
			state.ExecutionStack.Push (val != 0 ? _thenStatement : _elseStatement);
			return state;
		}

		public override string ToString ()
		{
			return " if ( " + _expression.ToString () + " ) then ( " + _thenStatement.ToString () + " ) else ( " +
			_elseStatement.ToString () + " ) ";
		}
	}
}