using System;
using Gtk;
using InterpreterCSharpGUIFinal;
using InterpreterCSharp.Source.controller;
using InterpreterCSharp.Source.repository;

public partial class MainWindow: Gtk.Window
{
	private Controller controller;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		IRepository repo = new Repository ();
		controller = new Controller (repo);
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnLogCheckBoxClicked (object sender, EventArgs e)
	{
		controller.LogFlag = logCheckBox.Active;
	}

	protected void OnDeserializeButtonClicked (object sender, EventArgs e)
	{
		DeserializeWindow dw = new DeserializeWindow (controller);
		dw.ShowAll ();
	}

	protected void OnSerializeButtonClicked (object sender, EventArgs e)
	{
		controller.Repo.Serialize ();
	}

	protected void OnAllStepButtonClicked (object sender, EventArgs e)
	{
		AllStepWindow asw = new AllStepWindow (controller);
		asw.ShowAll ();
	}

	protected void OnOneStepButtonClicked (object sender, EventArgs e)
	{
		OneStepWindow osw = new OneStepWindow (controller);
		osw.ShowAll ();
	}

	protected void OnInsertProgramButtonClicked (object sender, EventArgs e)
	{
		InsertProgramWindow ipw = new InsertProgramWindow (controller);
		ipw.ShowAll ();
	}
}
