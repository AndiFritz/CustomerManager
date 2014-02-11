using System;
using Gtk;
using System.Drawing; 

namespace CustomerManager
{
	public partial class CompanyWindow : Gtk.Window
	{
		public CompanyWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}


		protected void OnApplyActionActivated (object sender, EventArgs e)
		{
			DateTime now = new DateTime();
			DateTime regidate = now.Date;

			bool addOK = MainClass.connection.addCompany(nameTextBox.Text, Convert.ToInt16(plzTextBox.Text), countryTextBox.Text, streetTextBox.Text, hnrTextBox.Text, webTextBox.Text, pnameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, mobileTextBox.Text, regidate, typComboBox.ActiveText);
		
			if(addOK == true) //kein Fehler bei der Datenbankconnection
			{
				this.Destroy (); //Fenster schließen
				MessageDialog md = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Firma / Unternehmen erfolgreich hinzugefügt!");
				md.Run ();
				md.Destroy ();
			}
			else // Fehler bei der Datenbankconnection
			{
				MessageDialog md = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Beim Erstellen einer neuen Firma / eines neuen Unternehmens ist ein Fehler aufgetreten!");
				md.Run ();
				md.Destroy ();
			}
		}

		protected void OnCloseActionActivated (object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnClearActionActivated (object sender, EventArgs e)
		{
			nameTextBox.Text = ""; 
			plzTextBox.Text = ""; 
			countryTextBox.Text = ""; 
			streetTextBox.Text = ""; 
			hnrTextBox.Text = ""; 
			webTextBox.Text = ""; 

			pnameTextBox.Text = ""; 
			emailTextBox.Text = ""; 
			phoneTextBox.Text = ""; 
			mobileTextBox.Text = ""; 
		}

		protected void OnDialogQuestionActionActivated (object sender, EventArgs e)
		{
			throw new System.NotImplementedException ();
		}
	}
}

