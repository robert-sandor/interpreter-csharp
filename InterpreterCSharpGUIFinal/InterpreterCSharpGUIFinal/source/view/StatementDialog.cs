using System;
using Gtk;
using System.Collections.Generic;

namespace InterpreterCSharpGUIFinal
{
	public partial class StatementDialog : Gtk.Dialog
	{
		public StatementDialog (string message, string[] choiceCollection)
		{
			this.Build ();

			label.Text = message;

			foreach (string choice in choiceCollection) {
				combobox1.AppendText (choice);
			}
		}

		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			this.Respond (combobox1.Active);
			this.Destroy ();
		}

		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}
	}
}

