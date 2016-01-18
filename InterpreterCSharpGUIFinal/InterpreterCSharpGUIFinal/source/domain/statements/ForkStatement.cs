using System;
using InterpreterCSharp.Source.domain.statements;
using InterpreterCSharp.Source.domain;
using InterpreterCSharp.Source.domain.adts;

namespace InterpreterCSharpGUI
{
	[Serializable] public class ForkStatement : IStatement
	{
		private IStatement statement;

		public ForkStatement (IStatement statement)
		{
			this.statement = statement;
		}

		public IStatement Statement {
			get {
				return this.statement;
			}
			set {
				statement = value;
			}
		}

		public ProgramState Execute (ProgramState state)
		{
			IStack<IStatement> newStack = new LibStack<IStatement> ();
			IDictionary<String, int> newSymTable = new LibDictionary<String, int> ((LibDictionary<string, int>) state.SymbolTable);
			return new ProgramState (state.Id * 10, newStack, newSymTable, state.Output, state.Heap, statement);
		}

		public override string ToString ()
		{
			return " fork ( " + statement + " ) ";
		}
	}
}

