using InterpreterCSharp.Source.domain.expressions;

namespace InterpreterCSharp.Source.domain.statements
{
    public class WhileStatement : IStatement
    {
        private readonly IExpression _expression;
        private readonly IStatement _statement;

        public WhileStatement(IExpression expression, IStatement statement)
        {
            _expression = expression;
            _statement = statement;
        }

        public ProgramState Execute(ProgramState state)
        {
            var val = _expression.Evaluate(state.SymbolTable, state.Heap);
            if (val == 0) return state;

            state.ExecutionStack.Push(this);
            state.ExecutionStack.Push(_statement);
            return state;
        }

        public override string ToString()
        {
            return " while ( " + _expression.ToString() + " ) do ( " + _statement.ToString() + " ) ";
        }
    }
}