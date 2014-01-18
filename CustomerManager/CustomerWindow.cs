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
		protected void OnCloseTBActivated (object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnPwCTextBoxChanged (object sender, EventArgs e)
		{
			if (pwTextBox.Text == pwCTextBox.Text) {
				pwCTextBox.Settings.ColorHash = Color.Green; 
			} else {
				pwCTextBox.Colormap = Color.Red; 
			}
		}
	}
}

