using System;
using InterpreterCSharp.Source.controller;
using Gtk;
using InterpreterCSharp.Source.domain;

namespace InterpreterCSharpGUIFinal
{
	public partial class OneStepWindow : Gtk.Window
	{
		private Controller controller;

		public OneStepWindow (Controller controller) :
			base (Gtk.WindowType.Toplevel)
		{
			this.controller = controller;
			this.Build ();
		}

		protected void OnOneStepButtonClicked (object sender, EventArgs e)
		{
			controller.OneStep ();
			TextBuffer buffer = textview2.Buffer;
			buffer.Text = "";
			foreach (ProgramState state in controller.Repo.Programs) {
				buffer.Text += state.ToString () + "\n";
			}
		}

		protected void OnBackButtonClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}
	}
}

