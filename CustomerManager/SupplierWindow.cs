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
	public partial class SupplierWindow : Gtk.Window
	{
		public SupplierWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

			readTyp();

		}

		private void readTyp ()
		{
			List<String> ListTyp = MainClass.connection.readTyp();
			ListStore ls = new ListStore(typeof(string));
			typComboBox.Model = ls;
			
			foreach(string s in ListTyp)
				ls.AppendValues(s);
		}

		private bool checkTextBoxValueSup () // TextBoxen alle gefuellt?
		{

			if (nameTextBox.Text != "" && streetTextBox.Text != "" && hnrTextBox.Text != "" && plzTextBox.Text != "" && landTextBox.Text != "" && webTextBox.Text != "" && typComboBox.ActiveText != "") 
				{
					return true; 
				}
				else
				{
					return false;
				}
			 

		}

		//Formular leeren
		protected void OnCleanFormularActivated (object sender, EventArgs e)
		{
			nameTextBox.Text = ""; 
			streetTextBox.Text = ""; 
			hnrTextBox.Text = ""; 
			plzTextBox.Text = ""; 
			landTextBox.Text = ""; 
			webTextBox.Text = ""; 
			pnameTextBox.Text = ""; 
			emailTextBox.Text = ""; 
			telephoneTextBox.Text = "";
			mobileTextBox.Text = ""; 

		}


		protected void OnAddSupplierActivated (object sender, EventArgs e)
		{
			bool checkOK = checkTextBoxValueSup(); // Alle Text Boxen gefüllt ?

			if (checkOK == true) {
				DateTime now = DateTime.Now;
				string regidate = now.ToShortDateString ();
				Int16 plz = Convert.ToInt16 (plzTextBox.Text);
				bool addOK = MainClass.connection.addSupplier(nameTextBox.Text, streetTextBox.Text, hnrTextBox.Text, plz, landTextBox.Text, webTextBox.Text, typComboBox.ActiveText, pnameTextBox.Text, emailTextBox.Text, telephoneTextBox.Text, mobileTextBox.Text, regidate);

				if(addOK == true)
				{
					MessageDialog md = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Lieferant erfolgreich hinzugefügt!");
					md.Run ();
					md.Destroy(); 
					this.Destroy (); // dieses Fenster schließen
				}
				else
				{
					MessageDialog md = new MessageDialog (this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Es ist ein Fehler aufgetreten!");
					md.Run ();
					md.Destroy();
				}
			} 
			else 
			{
				MessageDialog md = new MessageDialog (this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Bitte füllen Sie alle Felder aus!");
				md.Run ();
				md.Destroy();
			}

		}

		protected void OnAddTypButtonClicked (object sender, EventArgs e)
		{
			SupplierTyp newST = new SupplierTyp();
			newST.Show();
		}
	}
}

