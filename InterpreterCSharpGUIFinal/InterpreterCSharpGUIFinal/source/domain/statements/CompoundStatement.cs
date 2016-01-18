using System;

namespace InterpreterCSharp.Source.domain.statements
{
	[Serializable] public class CompoundStatement : IStatement
	{
		private readonly IStatement _leftStatement;
		private readonly IStatement _rightStatement;

		public CompoundStatement (IStatement leftStatement, IStatement rightStatement)
		{
			_leftStatement = leftStatement;
			_rightStatement = rightStatement;
		}

		public ProgramState Execute (ProgramState state)
		{
			state.ExecutionStack.Push (_rightStatement);
			state.ExecutionStack.Push (_leftStatement);
			return state;
		}

		public override string ToString ()
		{
			return _leftStatement.ToString () + " ; " + _rightStatement.ToString ();
		}
	}
}