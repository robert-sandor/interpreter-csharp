using System;
using Gtk;

namespace InterpreterCSharpGUIFinal
{
	public partial class TextDialog : Gtk.Dialog
	{
		public TextDialog (string message)
		{
			this.Build ();
			label.Text = message;
		}

		public void GetText(ref string output) {
			ResponseType r = (ResponseType) this.Run ();
			if (r == ResponseType.Ok) {
				output = entry.Text;
			} else {
				output = null;
			}
			this.Destroy ();
		}

		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			Respond (ResponseType.Ok);
		}

		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			Respond (ResponseType.Cancel) ;
		}
	}
}

