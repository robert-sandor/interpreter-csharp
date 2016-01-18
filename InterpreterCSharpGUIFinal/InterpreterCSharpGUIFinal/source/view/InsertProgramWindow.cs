using System;
using InterpreterCSharp.Source.controller;
using InterpreterCSharp.Source.domain.statements;
using GLib;
using System.Collections.Generic;
using InterpreterCSharp.Source.domain.expressions;
using InterpreterCSharpGUI;
using System.IO;
using InterpreterCSharp.Source.domain;
using InterpreterCSharp.Source.domain.adts;
using Gtk;

namespace InterpreterCSharpGUIFinal
{
	public partial class InsertProgramWindow : Gtk.Window
	{
		private Controller controller;

		public InsertProgramWindow (Controller controller) :
			base (Gtk.WindowType.Toplevel)
		{
			this.controller = controller;
			this.Build ();
		}

		protected void OnBackButtonClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}

		protected void OnNewButtonClicked (object sender, EventArgs e)
		{
			IStatement statement = newStatement ("First statement : ");
			/*
			IStatement statement = new CompoundStatement (
				new AssignmentStatement ("v", new ConstantExpression (10)),
				new CompoundStatement (
					new NewStatement ("a", new ConstantExpression (22)),
					new CompoundStatement (
						new ForkStatement (
							new CompoundStatement (
								new WriteHeapStatement ("a", new ConstantExpression (30)),
								new CompoundStatement (
									new AssignmentStatement ("v", new ConstantExpression (32)),
									new CompoundStatement (
										new PrintStatement (new VariableExpression ("v")),
										new PrintStatement (new ReadHeapExpression ("a"))
									)
								)
							)
						),
						new CompoundStatement (
							new PrintStatement (new VariableExpression("v")),
							new PrintStatement (new ReadHeapExpression ("a"))
						)
					)
				)
			);
			*/
			List<ProgramState> programs = new List<ProgramState> ();
			programs.Add (new ProgramState(1, new LibStack<IStatement>(), 
				new LibDictionary<string, int>(), new LibList<string>(), new LibList<int>(), statement));
			controller.Repo.Programs = programs;

			TextBuffer buffer = textView.Buffer;
			buffer.Text = statement.ToString ();
		}

		private string newString(string message) {
			string resp = null;

			while (resp == null) {
				TextDialog td = new TextDialog (message);
				td.GetText (ref resp);
			}

			return resp;
		}

		private IStatement newStatement(string message) {
			string[] choices = {
				"Assignment Statement",
				"Compound Statement",
				"Fork Statement",
				"If Statement",
				"IfThen Statement",
				"New Statement",
				"Print Statement",
				"Skip Statement",
				"Switch Statement",
				"While Statement",
				"WriteHeap Statement",
			};
			StatementDialog sd = new StatementDialog (message, choices);
			int resp = sd.Run ();

			IStatement statement;
			switch (resp) {
			case 0:
				{
					string varname = newString ("Variable name : ");
					IExpression expression = newExpression ("Expression : ");
					statement = new AssignmentStatement (varname, expression);
					break;
				}
			case 1:
				{
					IStatement left = newStatement ("Left Statement : ");
					IStatement right = newStatement ("Right Statement : ");
					statement = new CompoundStatement (left, right);
					break;
				}
			case 2:
				{
					IStatement stmt = newStatement ("Forked Statement : ");
					statement = new ForkStatement (stmt);
					break;
				}
			case 3:
				{
					IExpression expression = newExpression ("Condition : ");
					IStatement thenStatement = newStatement ("Then : ");
					IStatement elseStatement = newStatement ("Else : ");
					statement = new IfStatement (expression, thenStatement, elseStatement);
					break;
				}
			case 4:
				{
					IExpression expression = newExpression ("Condition : ");
					IStatement thenStatement = newStatement ("Then : ");
					statement = new IfThenStatement (expression, thenStatement);
					break;
				}
			case 5:
				{
					string varname = newString ("Variable name : ");
					IExpression expression = newExpression ("Expression : ");
					statement = new NewStatement (varname, expression);
					break;
				}
			case 6:
				{
					IExpression expression = newExpression ("Expression : ");
					statement = new PrintStatement (expression);
					break;
				}
			case 7:
				{
					statement = new SkipStatement ();
					break;
				}
			case 8:
				{
					string varname = newString ("Variable name : ");
					IExpression exp1 = newExpression ("Condition 1 : ");
					IExpression exp2 = newExpression ("Condition 2 : ");
					IStatement stmt1 = newStatement ("Statement 1 : ");
					IStatement stmt2 = newStatement ("Statement 2 : ");
					IStatement def = newStatement ("Default : ");
					statement = new SwitchStatement (varname, exp1, exp2, stmt1, stmt2, def);
					break;
				}
			case 9:
				{
					IExpression expression = newExpression ("Condition : ");
					IStatement stmt = newStatement ("Statement : ");
					statement = new WhileStatement (expression, stmt);
					break;
				}
			case 10:
				{
					string varname = newString ("Variable name : ");
					IExpression expression = newExpression ("Expression : ");
					statement = new WriteHeapStatement (varname, expression);
					break;
				}
			default:
				{
					throw new IOException();
				}
			}

			return statement;
		}

		IExpression newExpression (string message)
		{
			string[] choices = {
				"Arithmetic Expression",
				"Boolean Expression",
				"Constant Expression",
				"Not Expression",
				"Read Value Expression",
				"ReadHeap Expression",
				"Variable Expression",
			};
			StatementDialog sd = new StatementDialog (message, choices);
			int resp = sd.Run ();

			IExpression e;
			switch (resp) {
			case 0:
				{
					string o = newString ("Operator (+ - * /) : ");
					ArithmeticExpression.Operator op;
					switch (o) {
					case "+":
						op = ArithmeticExpression.Operator.Add;
						break;
					case "-":
						op = ArithmeticExpression.Operator.Sub;
						break;
					case "*":
						op = ArithmeticExpression.Operator.Mul;
						break;
					case "/":
						op = ArithmeticExpression.Operator.Div;
						break;
					default:
						throw new IOException ();
					}
					IExpression exp1 = newExpression ("Left expression : ");
					IExpression exp2 = newExpression ("Right expression : ");
					e = new ArithmeticExpression (op, exp1, exp2);
					break;
				}
			case 1:
				{
					string o = newString ("Operator (< <= == != > >= && ||) : ");
					BooleanExpression.Operator op;
					switch (o) {
					case "<":
						op = BooleanExpression.Operator.Less;
						break;
					case "<=":
						op = BooleanExpression.Operator.LessOrEqual;
						break;
					case "==":
						op = BooleanExpression.Operator.Equal;
						break;
					case "!=":
						op = BooleanExpression.Operator.NotEqual;
						break;
					case ">":
						op = BooleanExpression.Operator.Greater;
						break;
					case ">=":
						op = BooleanExpression.Operator.GreaterOrEqual;
						break;
					case "&&":
						op = BooleanExpression.Operator.And;
						break;
					case "||":
						op = BooleanExpression.Operator.Or;
						break;
					default:
						throw new IOException ();
					}
					IExpression exp1 = newExpression ("Left expression : ");
					IExpression exp2 = newExpression ("Right expression : ");
					e = new BooleanExpression (op, exp1, exp2);
					break;
				}
			case 2:
				{
					int c;
					if (Int32.TryParse (newString ("Input integer : "), out c)) {
						e = new ConstantExpression (c);
					} else {
						throw new IOException ();
					}
					break;
				}
			case 3:
				{
					IExpression exp = newExpression ("Expression : ");
					e = new NotExpression (exp);
					break;
				}
			case 4:
				{
					e = new ReadExpression ();
					break;
				}
			case 5:
				{
					string varname = newString ("Variable name : ");
					e = new ReadHeapExpression (varname);
					break;
				}
			case 6:
				{
					string varname = newString ("Variable name : ");
					e = new VariableExpression (varname);
					break;
				}
			default:
				throw new IOException ();
			}

			return e;
		}
	}
}

