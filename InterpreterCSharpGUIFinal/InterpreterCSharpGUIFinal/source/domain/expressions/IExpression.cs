using InterpreterCSharp.Source.domain.adts;

namespace InterpreterCSharp.Source.domain.expressions
{
    public interface IExpression
    {
        int Evaluate(IDictionary<string, int> symbolTable, IList<int> heap);
        string ToString();
    }
}