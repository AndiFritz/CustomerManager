using System;

namespace CustomerManager
{
	public partial class SpecificWindow : Gtk.Window
	{
		public SpecificWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

