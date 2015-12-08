using InterpreterCSharp.Source.domain.expressions;

namespace InterpreterCSharp.Source.domain.statements
{
    public class WriteHeapStatement : IStatement
    {
        private readonly IExpression _expression;
        private readonly string _varname;

        public WriteHeapStatement(string varname, IExpression expression)
        {
            _varname = varname;
            _expression = expression;
        }

        public ProgramState Execute(ProgramState state)
        {
            var address = state.SymbolTable.Get(_varname);
            state.Heap.Update(address, _expression.Evaluate(state.SymbolTable, state.Heap));
            return state;
        }

        public override string ToString()
        {
            return " write_heap ( " + _varname + " , " + _expression.ToString() + " ) ";
        }
    }
}