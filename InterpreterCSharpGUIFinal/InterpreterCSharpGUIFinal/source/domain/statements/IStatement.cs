namespace InterpreterCSharp.Source.domain.statements
{
    public interface IStatement
    {
        ProgramState Execute(ProgramState state);
        string ToString();
    }
}