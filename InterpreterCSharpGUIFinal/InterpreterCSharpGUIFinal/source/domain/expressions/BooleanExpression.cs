using System;
using InterpreterCSharp.Source.domain.adts;

namespace InterpreterCSharp.Source.domain.expressions
{
	[Serializable] public class BooleanExpression : IExpression
	{
		public enum Operator
		{
			Less,
			LessOrEqual,
			Equal,
			NotEqual,
			Greater,
			GreaterOrEqual,
			And,
			Or
		}

		private readonly IExpression leftExpression;

		private readonly Operator op;
		private readonly IExpression rightExpression;

		public BooleanExpression (Operator op, IExpression leftExpression, IExpression rightExpression)
		{
			this.op = op;
			this.leftExpression = leftExpression;
			this.rightExpression = rightExpression;
		}

		public int Evaluate (IDictionary<string, int> symbolTable, IList<int> heap)
		{
			int value;
			var l = leftExpression.Evaluate (symbolTable, heap);
			var r = rightExpression.Evaluate (symbolTable, heap);
			switch (op) {
			case Operator.Less:
				value = (l < r) ? 1 : 0;
				break;
			case Operator.LessOrEqual:
				value = (l <= r) ? 1 : 0;
				break;
			case Operator.Equal:
				value = (l == r) ? 1 : 0;
				break;
			case Operator.NotEqual:
				value = (l != r) ? 1 : 0;
				break;
			case Operator.Greater:
				value = (l > r) ? 1 : 0;
				break;
			case Operator.GreaterOrEqual:
				value = (l >= r) ? 1 : 0;
				break;
			case Operator.And:
				value = (l != 0 && r != 0) ? 1 : 0;
				break;
			case Operator.Or:
				value = (l != 0 || r != 0) ? 1 : 0;
				break;
			default:
				throw new ArgumentOutOfRangeException ();
			}
			return value;
		}

		public override string ToString ()
		{
			string sop;
			switch (op) {
			case Operator.Less:
				sop = " < ";
				break;
			case Operator.LessOrEqual:
				sop = " <+ ";
				break;
			case Operator.Equal:
				sop = " == ";
				break;
			case Operator.NotEqual:
				sop = " != ";
				break;
			case Operator.Greater:
				sop = " > ";
				break;
			case Operator.GreaterOrEqual:
				sop = " >= ";
				break;
			case Operator.And:
				sop = " && ";
				break;
			case Operator.Or:
				sop = " || ";
				break;
			default:
				throw new ArgumentOutOfRangeException ();
			}
			return leftExpression.ToString () + sop + rightExpression.ToString ();
		}
	}
}