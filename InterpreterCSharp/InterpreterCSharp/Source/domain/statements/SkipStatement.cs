namespace InterpreterCSharp.Source.domain.statements
{
    public class SkipStatement : IStatement
    {
        public ProgramState Execute(ProgramState state)
        {
            return state;
        }

        public override string ToString()
        {
            return " skip ";
        }
    }
}