
// This file has been generated by the GUI designer. Do not modify.
namespace InterpreterCSharpGUIFinal
{
	public partial class InsertProgramWindow
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView textView;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Button newButton;
		
		private global::Gtk.Button backButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget InterpreterCSharpGUIFinal.InsertProgramWindow
			this.Name = "InterpreterCSharpGUIFinal.InsertProgramWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("InsertProgramWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child InterpreterCSharpGUIFinal.InsertProgramWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textView = new global::Gtk.TextView ();
			this.textView.CanFocus = true;
			this.textView.Name = "textView";
			this.textView.Editable = false;
			this.textView.CursorVisible = false;
			this.GtkScrolledWindow.Add (this.textView);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Homogeneous = true;
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.newButton = new global::Gtk.Button ();
			this.newButton.CanFocus = true;
			this.newButton.Name = "newButton";
			this.newButton.UseUnderline = true;
			this.newButton.Label = global::Mono.Unix.Catalog.GetString ("New");
			this.hbox1.Add (this.newButton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.newButton]));
			w3.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.backButton = new global::Gtk.Button ();
			this.backButton.CanFocus = true;
			this.backButton.Name = "backButton";
			this.backButton.UseUnderline = true;
			this.backButton.Label = global::Mono.Unix.Catalog.GetString ("Back");
			this.hbox1.Add (this.backButton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.backButton]));
			w4.Position = 1;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1156;
			this.DefaultHeight = 253;
			this.Show ();
			this.newButton.Clicked += new global::System.EventHandler (this.OnNewButtonClicked);
			this.backButton.Clicked += new global::System.EventHandler (this.OnBackButtonClicked);
		}
	}
}
