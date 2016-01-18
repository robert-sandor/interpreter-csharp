using System;
using InterpreterCSharp.Source.domain.adts;
using InterpreterCSharp.Source.exceptions.domain;

namespace InterpreterCSharp.Source.domain.expressions
{
	[Serializable] public class ReadExpression : IExpression
	{
		public int Evaluate (IDictionary<string, int> symbolTable, IList<int> heap)
		{
			var input = Console.ReadLine ();
			if (input == null) {
				throw new InputException ();
			}
			return int.Parse (input);
		}

		public override string ToString ()
		{
			return " read() ";
		}
	}
}