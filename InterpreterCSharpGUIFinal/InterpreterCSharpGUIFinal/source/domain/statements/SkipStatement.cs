using System;

namespace InterpreterCSharp.Source.domain.statements
{
	[Serializable] public class SkipStatement : IStatement
	{
		public ProgramState Execute (ProgramState state)
		{
			return state;
		}

		public override string ToString ()
		{
			return " skip ";
		}
	}
}