using System;

namespace CustomerManager
{
	public partial class ProjectsWindow : Gtk.Window
	{
		public ProjectsWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

