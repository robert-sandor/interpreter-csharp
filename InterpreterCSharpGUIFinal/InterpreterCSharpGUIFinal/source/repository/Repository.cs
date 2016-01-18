using InterpreterCSharp.Source.domain;
using InterpreterCSharp.Source.domain.adts;
using InterpreterCSharp.Source.exceptions.repository;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace InterpreterCSharp.Source.repository
{
    public class Repository : IRepository
    {
        private List<ProgramState> programs;
        
		public Repository (List<ProgramState> programs)
    	{
    		this.programs = programs;
    	}
    	
		public Repository ()
    	{
			this.programs = new List<ProgramState> ();
    	}
    	
		public List<ProgramState> Programs {
			get {
				return programs;
			}
			set {
				programs = value;
			}
		}

		public void Serialize ()
    	{
			IFormatter formatter = new BinaryFormatter ();
			using (FileStream s = File.Create ("serialized.bin")) {
				formatter.Serialize (s, programs);
			}
    	}

    	public void Deserialize ()
    	{
			IFormatter formatter = new BinaryFormatter ();
			using (FileStream s = File.OpenRead ("serialized.bin")) {
				Programs = (List<ProgramState>)formatter.Deserialize (s);
			}
    	}

    	public void LogState ()
    	{
			using (StreamWriter w = File.AppendText ("log.txt")) {
				programs.ForEach (p => w.WriteLine (p.ToString ()));
			}
    	}
    }
}