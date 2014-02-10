using System;
using System.Collections.Generic;
using Gtk;
using System.Drawing; 
using System.Drawing.Design;
using HollyLibrary;
using System.Security.Cryptography;
using System.Threading.Tasks;

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
			if (pwTextBox.Visible == true && pwdCLabel.Visible == true) { // Wenn Passwort - TextBoxen angezeigt werden, dann wird ein neuer Bentzer erstellt

				DateTime now = new DateTime();
				DateTime regidate = now.Date;

				bool ok = checkTextBoxValue ("user"); //prüft, ob alle Textboxen gefuellt sind 
				bool pwdOK = checkPasswordEntry(); // prüft, ob Passwoerter richtig eingegeben wurden

				if (ok == true) //alle Felder gefuellt
				{
					if(pwdOK == true) // Passwoerter stimmen ueberein
					{
						bool addOK = MainClass.connection.addUser (genderCB.ActiveText, vnameTextBox.Text, nnameTextBox.Text, usernameTextBox.Text, pwTextBox.Text, emailTextBox.Text, phoneTextBox.Text, mobileTextBox.Text, Convert.ToInt32(plzTextBox.Text), villageTextBox.Text, streetTextBox.Text, hnrTextBox.Text, regidate, 1, companyCB.ActiveText, typCB.ActiveText); 

						if(addOK == true) //kein Fehler bei der Datenbankconnection
						{
							this.Destroy (); //Fenster schließen
							MessageDialog md = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "User erfolgreich hinzugefügt!");
							md.Run ();
							md.Destroy ();
						}
						else // Fehler bei der Datenbankconnection
						{
							MessageDialog md = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Beim Erstellen eines neuen Users ist ein Fehler aufgetreten!");
							md.Run ();
							md.Destroy ();
						}
					}
					else
					{
						MessageDialog md = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Passwörter stimmen nicht überein!");
						md.Run ();
						md.Destroy ();
					}
				}
				else
				{
					MessageDialog md = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Bitte füllen Sie alle Felder aus!");
					md.Run ();
					md.Destroy ();
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

		private bool checkTextBoxValue (string typ) // TextBoxen alle gefuellt?
		{
			if (typ == "user") {
				if (genderCB.ActiveText != "" && nnameTextBox.Text != "" && vnameTextBox.Text != "" && typCB.ActiveText != "" && emailTextBox.Text != "" && phoneTextBox.Text != "" || mobileTextBox.Text != "" && plzTextBox.Text != "" && villageTextBox.Text != "" && streetTextBox.Text != "" && hnrTextBox.Text != "" && usernameTextBox.Text != "" && pwTextBox.Text != "" && pwCTextBox.Text != "") 
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
				if (genderCB.ActiveText != "" && nnameTextBox.Text != "" && vnameTextBox.Text != "" && typCB.ActiveText != "" && emailTextBox.Text != "" && phoneTextBox.Text != "" && mobileTextBox.Text != "" && plzTextBox.Text != "" && villageTextBox.Text != "" && streetTextBox.Text != "" && hnrTextBox.Text != "") 
				{
					return true; 
				}
				else
				{
					return false; 
				}
			}
		}

		private bool checkPasswordEntry () //Passwoerter richtig eingegeben?
		{
			if (pwTextBox.Text == pwCTextBox.Text) {
				return true; 
			} else {
				return false; 
			}
		}

		protected void OnTypCBChanged (object sender, EventArgs e) //Unternehmen - Eingabefeld Combobox ausschalten, wenn Typ = Privat
		{
			if (typCB.ActiveText == "Privat") {
				companyCB.Sensitive = false; // Eingabefeld hinterlegen
				newCompanyButton.Sensitive = false; // Button hinterlegen
			} else {
				companyCB.Sensitive = true;
				newCompanyButton.Sensitive = true; 

				string typ = typCB.ActiveText;

				List<String> companies = MainClass.connection.readCompany(typ);
				ListStore ls = new ListStore(typeof(string));
				companyCB.Model = ls;

				foreach(string s in companies)
					ls.AppendValues(s);
			}
		}

		protected void OnNewCompanyButtonClicked (object sender, EventArgs e) // neue Firma hinzufuegen Button
		{
			CompanyWindow cw = new CompanyWindow();
			cw.ShowAll();
		}
	}
}

