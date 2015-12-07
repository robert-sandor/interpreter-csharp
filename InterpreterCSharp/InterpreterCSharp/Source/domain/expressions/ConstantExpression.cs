using InterpreterCSharp.Source.domain.adts;

namespace InterpreterCSharp.Source.domain.expressions
{
    public class ConstantExpression : IExpression
    {
        private readonly int _value;

        public ConstantExpression(int value)
        {
            _value = value;
        }

        public int Evaluate(IDictionary<string, int> symbolTable, IList<int> heap)
        {
            return _value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}