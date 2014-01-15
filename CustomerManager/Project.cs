using System;

namespace CustomerManager
{
	public partial class Project : Gtk.Window
	{
		public Project () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.Title = "Neues Projekt";
		}
	}
}

