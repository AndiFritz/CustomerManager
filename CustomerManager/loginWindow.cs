using System;
using Gtk;

namespace CustomerManager
{
	public partial class loginWindow : Gtk.Window
	{
		public loginWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnLoginButtonClicked (object sender, EventArgs e)
		{
			string username = unameTextBox.Text; 
			string password = pwdTextBox.Text; 

			DBConnector con = MainClass.connection;

			bool loginAccept = con.login (username, password);

			if (loginAccept == true) {
				MainWindow mw = new MainWindow(); 
				this.Destroy ();
				mw.ShowAll ();
			}
		}

		protected void OnExitButtonClicked (object sender, EventArgs e)
		{
			Application.Quit();
		}
	}
}

