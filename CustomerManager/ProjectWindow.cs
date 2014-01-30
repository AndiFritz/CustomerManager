using System;

namespace CustomerManager
{
	public partial class ProjectWindow : Gtk.Window
	{
		public ProjectWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

