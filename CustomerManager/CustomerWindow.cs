using System;

namespace CustomerManager
{
	public partial class CustomerWindow : Gtk.Window
	{
		public CustomerWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

