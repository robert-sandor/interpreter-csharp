using System;
using InterpreterCSharp.Source.domain.expressions;

namespace InterpreterCSharp.Source.domain.statements
{
	[Serializable] public class IfThenStatement : IStatement
	{
		private readonly IExpression _expression;
		private readonly IStatement _statement;

		public IfThenStatement (IExpression expression, IStatement statement)
		{
			_expression = expression;
			_statement = statement;
		}

		public ProgramState Execute (ProgramState state)
		{
			state.ExecutionStack.Push (
				new IfStatement (_expression, _statement, new SkipStatement ()));
			return state;
		}

		public override string ToString ()
		{
			return " if ( " + _expression.ToString () + " ) then ( " + _statement.ToString () + " ) ";
		}
	}
}