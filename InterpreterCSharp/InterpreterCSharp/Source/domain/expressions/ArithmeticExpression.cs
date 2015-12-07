using System;
using InterpreterCSharp.Source.domain.adts;
using InterpreterCSharp.Source.exceptions.domain;

namespace InterpreterCSharp.Source.domain.expressions
{
    public class ArithmeticExpression : IExpression
    {
        public enum Operator
        {
            Add,
            Sub,
            Mul,
            Div
        }

        private readonly IExpression _leftExpression;

        private readonly Operator _op;
        private readonly IExpression _rightExpression;

        public ArithmeticExpression(Operator op, IExpression leftExpression, IExpression rightExpression)
        {
            _op = op;
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Evaluate(IDictionary<string, int> symbolTable, IList<int> heap)
        {
            int value;
            switch (_op)
            {
                case Operator.Add:
                    value = _leftExpression.Evaluate(symbolTable, heap) + _rightExpression.Evaluate(symbolTable, heap);
                    break;
                case Operator.Sub:
                    value = _leftExpression.Evaluate(symbolTable, heap) - _rightExpression.Evaluate(symbolTable, heap);
                    break;
                case Operator.Mul:
                    value = _leftExpression.Evaluate(symbolTable, heap)*_rightExpression.Evaluate(symbolTable, heap);
                    break;
                case Operator.Div:
                    var r = _rightExpression.Evaluate(symbolTable, heap);
                    if (r == 0)
                    {
                        throw new DivisionByZeroException();
                    }
                    value = _leftExpression.Evaluate(symbolTable, heap)/r;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return value;
        }

        public override string ToString()
        {
            string sop;
            switch (_op)
            {
                case Operator.Add:
                    sop = " + ";
                    break;
                case Operator.Sub:
                    sop = " - ";
                    break;
                case Operator.Mul:
                    sop = " * ";
                    break;
                case Operator.Div:
                    sop = " / ";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return _leftExpression.ToString() + sop + _rightExpression.ToString();
        }
    }
}