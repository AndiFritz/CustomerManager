
// This file has been generated by the GUI designer. Do not modify.
namespace CustomerManager
{
	public partial class loginWindow
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.VBox vbox1;
		private global::Gtk.MenuBar menubar1;
		private global::Gtk.Fixed fixed3;
		private global::Gtk.Label welcomeLabel;
		private global::Gtk.Button loginButton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CustomerManager.loginWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "CustomerManager.loginWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("loginWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child CustomerManager.loginWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu><menuitem/></menu><menu/></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.fixed3 = new global::Gtk.Fixed ();
			this.fixed3.HeightRequest = 170;
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.welcomeLabel = new global::Gtk.Label ();
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("LOGIN");
			this.fixed3.Add (this.welcomeLabel);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed3 [this.welcomeLabel]));
			w3.X = 18;
			w3.Y = 16;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.loginButton = new global::Gtk.Button ();
			this.loginButton.CanFocus = true;
			this.loginButton.Name = "loginButton";
			this.loginButton.UseUnderline = true;
			this.loginButton.Label = global::Mono.Unix.Catalog.GetString ("Login");
			this.fixed3.Add (this.loginButton);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed3 [this.loginButton]));
			w4.X = 14;
			w4.Y = 121;
			this.vbox1.Add (this.fixed3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.fixed3]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 450;
			this.DefaultHeight = 228;
			this.Show ();
		}
	}
}
