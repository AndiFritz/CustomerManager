using System;

namespace CustomerManager
{
	public partial class loginWindow : Gtk.Window
	{
		public loginWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

		}
	}
}

