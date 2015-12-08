using InterpreterCSharp.Source.domain.adts;
using InterpreterCSharp.Source.domain.statements;

namespace InterpreterCSharp.Source.domain
{
    public class ProgramState
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
        }

        public int Id { get; }

        public IStack<IStatement> ExecutionStack { get; }

        public IDictionary<string, int> SymbolTable { get; }

        public IList<string> Output { get; }

        public IList<int> Heap { get; }

        public IStatement OriginalStatement { get; }

        public override string ToString()
        {
            var o = "ID : " + Id + "\n";
            o += OriginalStatement.ToString() + "\n\n";
            o += "ExecutionStack {" + ExecutionStack.ToString() + "}\n";
            o += "SymbolTable {" + SymbolTable.ToString() + "}\n";
            o += "Heap {" + Heap.ToString() + "}\n";
            o += "Output {" + Output.ToString() + "}\n";
            return o;
        }
    }
}