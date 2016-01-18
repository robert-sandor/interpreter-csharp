﻿using System;
using InterpreterCSharp.Source.controller;
using Gtk;
using InterpreterCSharp.Source.domain;

namespace InterpreterCSharpGUIFinal
{
	public partial class DeserializeWindow : Gtk.Window
	{
		private Controller controller;

		public DeserializeWindow (Controller controller) :
			base (Gtk.WindowType.Toplevel)
		{
			this.controller = controller;
			this.Build ();
		}

		protected void OnDeserializeButtonClicked (object sender, EventArgs e)
		{
			controller.Repo.Deserialize ();
			TextBuffer buffer = textView.Buffer;
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

