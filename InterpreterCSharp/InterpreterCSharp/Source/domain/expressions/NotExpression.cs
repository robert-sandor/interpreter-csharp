using InterpreterCSharp.Source.domain.adts;

namespace InterpreterCSharp.Source.domain.expressions
{
    public class NotExpression : IExpression
    {
        private readonly IExpression _expression;

        public NotExpression(IExpression expression)
        {
            _expression = expression;
        }

        public int Evaluate(IDictionary<string, int> symbolTable, IList<int> heap)
        {
            var value = _expression.Evaluate(symbolTable, heap);
            return (value == 0) ? 1 : 0;
        }

        public override string ToString()
        {
            return " !( " + _expression.ToString() + " ) ";
        }
    }
}