using System;

namespace CustomerManager
{
	public partial class SupplierWindow : Gtk.Window
	{
		public SupplierWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

