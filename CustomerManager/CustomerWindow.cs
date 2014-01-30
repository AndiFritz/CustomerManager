using System;
using Gtk;
using System.Drawing; 
using System.Drawing.Design;
using HollyLibrary;

namespace CustomerManager
{
	public partial class CustomerWindow : Gtk.Window
	{
		public CustomerWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		#region Login 
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

			newUserTable.Visible = true; 
			usernameTextBox.Visible = true; 
			unameLabel.Visible = true; 
			hseparator2.Visible = true; 
			userdataLabel.Visible = true; 
			#endregion

			this.Show ();
		}

		public void addCustomer()
		{
			this.headerLabel.Text = "Neuer Kunde ersellen:";
			this.Show ();
		}
		#endregion
		protected void OnApplyAddTBActivated (object sender, EventArgs e)
		{
			Connection con = new Connection ();

			if (pwTextBox.Visible == true && pwdCLabel.Visible == true) { // Wenn Passwort - TextBoxen angezeigt werden, dann wird ein neuer Bentzer erstellt

				DateTime regidate = DateTimeKind.Local;

				bool ok = checkTextBoxValue ("user"); //prüft den Inhalt der TextBoxen 

				if (ok == true) {
					con.addUser (vnameTextBox.Text, nnameTextBox.Text, usernameTextBox.Text, pwTextBox.Text, emailTextBox.Text, phoneTextBox.Text, mobileTextBox.Text, plzTextBox.Text, villageTextBox.Text, streetTextBox.Text, hnrTextBox.Text, regidate); 
				}
				else
				{
					MessageDialog md = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Bitte füllen sie alle Felder aus!");
				}
			}

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

		private bool checkTextBoxValue (string typ)
		{
			if (typ == "user") {
				if (genderCB.ActiveText != "" && nnameTextBox.Text != "" && vnameTextBox.Text != "" && typCB.ActiveText != "" && companyCBE.ActiveText != "" && emailTextBox.Text != "" && phoneTextBox.Text != "" && mobileTextBox.Text != "" && plzTextBox.Text != "" && villageTextBox.Text != "" && streetTextBox.Text != "" && hnrTextBox.Text != "" && usernameTextBox.Text != "" && pwTextBox.Text != "" && pwCTextBox.Text != "") 
				{
					return true; 
				}
				else
				{
					return false; 
				}
			} 
			else 
			{
				if (genderCB.ActiveText != "" && nnameTextBox.Text != "" && vnameTextBox.Text != "" && typCB.ActiveText != "" && companyCBE.ActiveText != "" && emailTextBox.Text != "" && phoneTextBox.Text != "" && mobileTextBox.Text != "" && plzTextBox.Text != "" && villageTextBox.Text != "" && streetTextBox.Text != "" && hnrTextBox.Text != "") 
				{
					return true; 
				}
				else
				{
					return false; 
				}
			}




		}

	}
}

