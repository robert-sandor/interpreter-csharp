using System;
using InterpreterCSharp.Source.domain.adts;
using InterpreterCSharp.Source.domain.statements;
using InterpreterCSharp.Source.exceptions.domain;

namespace InterpreterCSharp.Source.domain
{
    [Serializable] public class ProgramState
    {
        public ProgramState(int id, IStack<IStatement> executionStack, IDictionary<string, int> symbolTable,
            IList<string> output, IList<int> heap, IStatement originalStatement)
        {
            Id = id;
            ExecutionStack = executionStack;
            SymbolTable = symbolTable;
            Output = output;
            Heap = heap;
            OriginalStatement = originalStatement;

			executionStack.Push (originalStatement);
        }

        public int Id { get; }

        public IStack<IStatement> ExecutionStack { get; }

        public IDictionary<string, int> SymbolTable { get; }

        public IList<string> Output { get; }

        public IList<int> Heap { get; }

        public IStatement OriginalStatement { get; }

		public bool IsNotCompleted () {
			return !ExecutionStack.IsEmpty ();
		}

		public ProgramState OneStep() {
			try {
				IStatement current = ExecutionStack.Pop ();
				return current.Execute (this);
			} catch (EmptyStackException) {
				// TODO add exception
				return null;
			}
		}

        public override string ToString()
        {
            var o = "ID : " + Id + "\n";
            o += OriginalStatement.ToString() + "\n\n";
            o += "ExecutionStack {\n" + ExecutionStack.ToString() + "}\n";
            o += "SymbolTable {\n" + SymbolTable.ToString() + "}\n";
            o += "Heap {\n" + Heap.ToString() + "}\n";
            o += "Output {\n" + Output.ToString() + "}\n";
            return o;
        }
    }
}