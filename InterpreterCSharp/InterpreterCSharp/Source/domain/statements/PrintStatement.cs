using InterpreterCSharp.Source.domain.expressions;

namespace InterpreterCSharp.Source.domain.statements
{
    public class PrintStatement : IStatement
    {
        private readonly IExpression _expression;

        public PrintStatement(IExpression expression)
        {
            _expression = expression;
        }

        public ProgramState Execute(ProgramState state)
        {
            state.Output.Add(_expression.Evaluate(state.SymbolTable, state.Heap).ToString());
            return state;
        }

        public override string ToString()
        {
            return " print( " + _expression.ToString() + " ) ";
        }
    }
}