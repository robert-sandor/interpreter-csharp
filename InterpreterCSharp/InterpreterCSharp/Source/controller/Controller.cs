using System;
using InterpreterCSharp.Source.domain;
using InterpreterCSharp.Source.repository;

namespace InterpreterCSharp.Source.controller
{
    public class Controller
    {
        private readonly IRepository _repository;

        public Controller(IRepository repository)
        {
            _repository = repository;
            LogFilePath = null;
            WriteToFile = false;
        }

        public string LogFilePath { get; set; }

        public bool WriteToFile { get; set; }

        public ProgramState OneStep(ProgramState state)
        {
            var statement = state.ExecutionStack.Pop();
            statement.Execute(state);

            if (WriteToFile && LogFilePath != null)
            {
                _repository.SaveStateToFile(LogFilePath, state);
            }
            else
            {
                Console.WriteLine(state.ToString());
            }

            return state;
        }

        public void AllStep(ProgramState state)
        {
            while (!state.ExecutionStack.IsEmpty())
            {
                OneStep(state);
            }
        }
    }
}