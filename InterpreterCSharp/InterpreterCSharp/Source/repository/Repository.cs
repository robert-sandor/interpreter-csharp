using InterpreterCSharp.Source.domain;
using InterpreterCSharp.Source.domain.adts;
using InterpreterCSharp.Source.exceptions.repository;

namespace InterpreterCSharp.Source.repository
{
    public class Repository : IRepository
    {
        private LibList<ProgramState> programs;
        private int currentStateIndex;

        public Repository()
        {
            programs = new LibList<ProgramState>();
            currentStateIndex = -1;
        }

        public void Add(ProgramState state)
        {
            programs.Add(state);
        }

        public void SetCurrentState(int index)
        {
            if (index < 0 || index >= programs.Size())
            {
                throw new InvalidProgramIndexException();
            }

            currentStateIndex = index;
        }

        public ProgramState GetCurrentProgramState()
        {
            return programs.Get(currentStateIndex);
        }

        public void Serialize(string filePath, ProgramState state)
        {
            throw new System.NotImplementedException();
        }

        public ProgramState Deserialize(string filePath)
        {
            throw new System.NotImplementedException();
        }

        public void SaveStateToFile(string filePath, ProgramState state)
        {
            throw new System.NotImplementedException();
        }
    }
}