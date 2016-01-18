using System;
using InterpreterCSharp.Source.domain.expressions;

namespace InterpreterCSharp.Source.domain.statements
{
	[Serializable] public class SwitchStatement : IStatement
	{
		private readonly IStatement _defaultStatement;
		private readonly IExpression _expression1;
		private readonly IExpression _expression2;
		private readonly IStatement _statement1;
		private readonly IStatement _statement2;
		private readonly string _varname;

		public SwitchStatement (string varname, IExpression expression1, IExpression expression2, IStatement statement1,
		                             IStatement statement2, IStatement defaultStatement)
		{
			_varname = varname;
			_expression1 = expression1;
			_expression2 = expression2;
			_statement1 = statement1;
			_statement2 = statement2;
			_defaultStatement = defaultStatement;
		}

		public ProgramState Execute (ProgramState state)
		{
			state.ExecutionStack.Push (
				new IfStatement (
					new ArithmeticExpression (
						ArithmeticExpression.Operator.Sub,
						new VariableExpression (_varname),
						_expression1),
					new IfStatement (
						new ArithmeticExpression (
							ArithmeticExpression.Operator.Sub,
							new VariableExpression (_varname),
							_expression2),
						_defaultStatement,
						_statement1
					),
					_statement2
				));
			return state;
		}

		public override string ToString ()
		{
			return " switch ( " + _varname + " ) case ( " + _expression1.ToString () + " ) : ( " + _statement1.ToString () +
			" ) case ( " + _expression2.ToString () + " ) : ( " + _statement2.ToString () + " ) default : ( " +
			_defaultStatement.ToString () + " ) ";
		}
	}
}