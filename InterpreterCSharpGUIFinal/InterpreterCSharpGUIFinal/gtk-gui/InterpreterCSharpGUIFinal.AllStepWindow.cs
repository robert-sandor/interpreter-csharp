
// This file has been generated by the GUI designer. Do not modify.
namespace InterpreterCSharpGUIFinal
{
	public partial class AllStepWindow
	{
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView textView;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.Button allStepButton;
		
		private global::Gtk.Button backButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget InterpreterCSharpGUIFinal.AllStepWindow
			this.Name = "InterpreterCSharpGUIFinal.AllStepWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("AllStepWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child InterpreterCSharpGUIFinal.AllStepWindow.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			this.vbox5.BorderWidth = ((uint)(6));
			// Container child vbox5.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("All Step Output");
			this.vbox5.Add (this.label6);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label6]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
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
			this.vbox5.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.GtkScrolledWindow]));
			w3.Position = 1;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Homogeneous = true;
			this.hbox4.Spacing = 6;
			this.hbox4.BorderWidth = ((uint)(6));
			// Container child hbox4.Gtk.Box+BoxChild
			this.allStepButton = new global::Gtk.Button ();
			this.allStepButton.CanFocus = true;
			this.allStepButton.Name = "allStepButton";
			this.allStepButton.UseUnderline = true;
			this.allStepButton.Label = global::Mono.Unix.Catalog.GetString ("All Step");
			this.hbox4.Add (this.allStepButton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.allStepButton]));
			w4.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.backButton = new global::Gtk.Button ();
			this.backButton.CanFocus = true;
			this.backButton.Name = "backButton";
			this.backButton.UseUnderline = true;
			this.backButton.Label = global::Mono.Unix.Catalog.GetString ("Back");
			this.hbox4.Add (this.backButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.backButton]));
			w5.Position = 1;
			this.vbox5.Add (this.hbox4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox4]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.Add (this.vbox5);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 656;
			this.DefaultHeight = 471;
			this.Show ();
			this.allStepButton.Clicked += new global::System.EventHandler (this.OnAllStepButtonClicked);
			this.backButton.Clicked += new global::System.EventHandler (this.OnBackButtonClicked);
		}
	}
}
