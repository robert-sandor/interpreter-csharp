using System;
using InterpreterCSharp.Source.domain;
using InterpreterCSharp.Source.repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterpreterCSharp.Source.controller
{
	public class Controller
	{
		private IRepository repo;
		private bool printFlag;
		private bool logFlag;

		public IRepository Repo {
			get {
				return this.repo;
			}
			set {
				repo = value;
			}
		}

		public bool PrintFlag {
			get {
				return this.printFlag;
			}
			set {
				printFlag = value;
			}
		}

		public bool LogFlag {
			get {
				return this.logFlag;
			}
			set {
				logFlag = value;
			}
		}

		public Controller (IRepository repo)
		{
			this.repo = repo;
			PrintFlag = true;
			LogFlag = true;
		}

		public void SerializeProgramState ()
		{
			repo.Serialize ();
		}

		public List<ProgramState> RemoveCompletedPrograms (List<ProgramState> inList)
		{
			return inList.Where (p => p.IsNotCompleted ()).ToList ();
		}

		private void OneStepForAllPrograms (List<ProgramState> list)
		{
			List<Task<ProgramState>> taskList = (from prg in list
			                                     select Task<ProgramState>.Factory.StartNew (() => prg.OneStep ())).ToList ();

			try {
				List<ProgramState> newList = (from tsk in taskList
				                             where tsk.Result != null
				                             select tsk.Result).ToList ();

				newList.AddRange (list.Where (p => !newList.Any (q => q.Id == p.Id)).ToList ());

				if (PrintFlag) {
					newList.ForEach (p => Console.WriteLine (p.ToString ()));
				}

				if (LogFlag) {
					repo.LogState ();
				}

				repo.Programs = newList;
			} catch (Exception e) {
				Console.Write (e.StackTrace);
			}
		}

		public void OneStep ()
		{
			List<ProgramState> list = RemoveCompletedPrograms (repo.Programs);
			OneStepForAllPrograms (list);
		}

		public void AllStep ()
		{
			while (true) {
				List<ProgramState> list = RemoveCompletedPrograms (repo.Programs);
				if (list.Count == 0) {
					return;
				} else {
					OneStepForAllPrograms (list);
				}
			}
		}
	}
}