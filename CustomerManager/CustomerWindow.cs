using System;
using System.Drawing; 
using System.Drawing.Design;

namespace CustomerManager
{
	public partial class CustomerWindow : Gtk.Window
	{
		public CustomerWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnPwCTextBoxChanged (object sender, EventArgs e)
		{
		}

		public void addUser()
		{
			this.headerLabel.Text = "Neuer Benutzer ersellen:";

			#region Passwortbereich einschalten
			pwdLabel.Visible = true; 
			pwdLabel.Sensitive = true; 
			
			pwTextBox.Visible = true; 
			pwTextBox.Sensitive = true; 
			
			
			pwdCLabel.Visible = true; 
			pwdCLabel.Sensitive = true; 
			
			pwCTextBox.Visible = true; 
			pwCTextBox.Sensitive = true; 
			#endregion

			this.Show ();
		}

		public void addCustomer()
		{
			this.headerLabel.Text = "Neuer Kunde ersellen:";
			this.Show ();
		}

		protected void OnApplyAddTBActivated (object sender, EventArgs e)
		{
			throw new System.NotImplementedException ();
		}

		protected void OnCloseTBActivated (object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnClearTBActivated (object sender, EventArgs e)
		{
			nnameTextBox.Text = ""; 
			vnameTextBox.Text = ""; 
			emailTextBox.Text = ""; 
			phoneTextBox.Text = ""; 
			mobileTextBox.Text = ""; 
			plzTextBox.Text = ""; 
			villageTextBox.Text = ""; 
			hnrTextBox.Text = ""; 
			streetTextBox.Text = "";
			pwTextBox.Text = ""; 
			pwCTextBox.Text = ""; 
		}

		protected void OnDialogQuestionTBActivated (object sender, EventArgs e)
		{
			throw new System.NotImplementedException ();
		}

	}
}

