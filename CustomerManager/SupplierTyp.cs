using System;
using Gtk;

namespace CustomerManager
{
	public partial class SupplierTyp : Gtk.Window
	{
		public SupplierTyp () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		private bool checkTextBoxValue () // TextBoxen alle gefuellt?
		{
			
			if (typTextBox.Text != "") 
			{
				return true; 
			}
			else
			{
				return false;
			}
			
			
		}

		protected void OnSaveClicked (object sender, EventArgs e)
		{
			bool checkOK = checkTextBoxValue(); // Alle Text Boxen gefüllt ?
			
			if (checkOK == true) 
			{
				bool addOK = MainClass.connection.addSupTyp(typTextBox.Text);
				this.Destroy();
			} 
			else 
			{
				MessageDialog md = new MessageDialog (this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Bitte füllen Sie alle Felder aus!");
				md.Run ();
				md.Destroy();
			}
		}
	}
}

