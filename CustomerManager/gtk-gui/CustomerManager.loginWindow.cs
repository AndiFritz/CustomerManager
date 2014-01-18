
// This file has been generated by the GUI designer. Do not modify.
namespace CustomerManager
{
	public partial class loginWindow
	{
		private global::Gtk.HBox hbox3;
		private global::Gtk.VBox vbox8;
		private global::Gtk.Fixed fixed7;
		private global::Gtk.Label welcomeLabel;
		private global::Gtk.Fixed fixed8;
		private global::Gtk.Label unameLabel;
		private global::Gtk.Label pwdLabel;
		private global::Gtk.Entry unameTextBox;
		private global::Gtk.Entry pwdTextBox;
		private global::Gtk.Button loginButton;
		private global::Gtk.Button exitButton;
		private global::Gtk.VBox vbox7;
		private global::Gtk.Image image3;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CustomerManager.loginWindow
			this.Name = "CustomerManager.loginWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Login");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child CustomerManager.loginWindow.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.fixed7 = new global::Gtk.Fixed ();
			this.fixed7.WidthRequest = 300;
			this.fixed7.HeightRequest = 60;
			this.fixed7.Name = "fixed7";
			this.fixed7.HasWindow = false;
			// Container child fixed7.Gtk.Fixed+FixedChild
			this.welcomeLabel = new global::Gtk.Label ();
			this.welcomeLabel.WidthRequest = 294;
			this.welcomeLabel.HeightRequest = 57;
			this.welcomeLabel.CanDefault = true;
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Xalign = 0F;
			this.welcomeLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Herzlich Willkommen zu Customer Manager!");
			this.fixed7.Add (this.welcomeLabel);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed7 [this.welcomeLabel]));
			w1.X = 8;
			w1.Y = 3;
			this.vbox8.Add (this.fixed7);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.fixed7]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.fixed8 = new global::Gtk.Fixed ();
			this.fixed8.Name = "fixed8";
			this.fixed8.HasWindow = false;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.unameLabel = new global::Gtk.Label ();
			this.unameLabel.Name = "unameLabel";
			this.unameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Benutzername:");
			this.fixed8.Add (this.unameLabel);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.unameLabel]));
			w3.X = 19;
			w3.Y = 20;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.pwdLabel = new global::Gtk.Label ();
			this.pwdLabel.Name = "pwdLabel";
			this.pwdLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Passwort: ");
			this.fixed8.Add (this.pwdLabel);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.pwdLabel]));
			w4.X = 19;
			w4.Y = 55;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.unameTextBox = new global::Gtk.Entry ();
			this.unameTextBox.CanFocus = true;
			this.unameTextBox.Name = "unameTextBox";
			this.unameTextBox.IsEditable = true;
			this.unameTextBox.InvisibleChar = '●';
			this.fixed8.Add (this.unameTextBox);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.unameTextBox]));
			w5.X = 123;
			w5.Y = 16;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.pwdTextBox = new global::Gtk.Entry ();
			this.pwdTextBox.CanFocus = true;
			this.pwdTextBox.Name = "pwdTextBox";
			this.pwdTextBox.IsEditable = true;
			this.pwdTextBox.MaxLength = 20;
			this.pwdTextBox.Visibility = false;
			this.pwdTextBox.InvisibleChar = '●';
			this.fixed8.Add (this.pwdTextBox);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.pwdTextBox]));
			w6.X = 123;
			w6.Y = 50;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.loginButton = new global::Gtk.Button ();
			this.loginButton.WidthRequest = 170;
			this.loginButton.CanFocus = true;
			this.loginButton.Name = "loginButton";
			this.loginButton.UseUnderline = true;
			this.loginButton.Label = global::Mono.Unix.Catalog.GetString ("login");
			this.fixed8.Add (this.loginButton);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.loginButton]));
			w7.X = 12;
			w7.Y = 93;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.exitButton = new global::Gtk.Button ();
			this.exitButton.WidthRequest = 80;
			this.exitButton.CanFocus = true;
			this.exitButton.Name = "exitButton";
			this.exitButton.UseUnderline = true;
			this.exitButton.Label = global::Mono.Unix.Catalog.GetString ("abbrechen");
			this.fixed8.Add (this.exitButton);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.exitButton]));
			w8.X = 202;
			w8.Y = 93;
			this.vbox8.Add (this.fixed8);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.fixed8]));
			w9.Position = 1;
			this.hbox3.Add (this.vbox8);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox8]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.image3 = new global::Gtk.Image ();
			this.image3.WidthRequest = 128;
			this.image3.HeightRequest = 141;
			this.image3.Name = "image3";
			this.vbox7.Add (this.image3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.image3]));
			w11.Position = 0;
			w11.Fill = false;
			this.hbox3.Add (this.vbox7);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox7]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.Add (this.hbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 447;
			this.DefaultHeight = 204;
			this.Show ();
			this.loginButton.Clicked += new global::System.EventHandler (this.OnLoginButtonClicked);
			this.exitButton.Clicked += new global::System.EventHandler (this.OnExitButtonClicked);
		}
	}
}
