using InterpreterCSharp.Source.domain;
using GLib;
using System.Collections.Generic;

namespace InterpreterCSharp.Source.repository
{
    public interface IRepository
    {
		List<ProgramState> Programs { get; set; }
        void Serialize();
        void Deserialize();
        void LogState();
    }
}