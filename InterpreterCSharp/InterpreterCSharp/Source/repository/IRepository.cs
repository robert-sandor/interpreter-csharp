using InterpreterCSharp.Source.domain;

namespace InterpreterCSharp.Source.repository
{
    public interface IRepository
    {
        void Add(ProgramState state);
        void SetCurrentState(int index);
        ProgramState GetCurrentProgramState();

        void Serialize(string filePath, ProgramState state);
        ProgramState Deserialize(string filePath);
        void SaveStateToFile(string filePath, ProgramState state);
    }
}