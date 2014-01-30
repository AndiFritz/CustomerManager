using System;
using HollyLibrary;

namespace CustomerManager
{
	public partial class ProjectsWindow : Gtk.Window
	{
		public ProjectsWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

			#region DateTimePicker / HDateEdit
			HDateEdit d = new HDateEdit();
			d.DateTimeFormatType = DateTimeFormatTypeEnum.ShortDate;
			valueTable.Attach(d, 2,3,0,1);
			valueTable.Attach(d, 2,4,0,1);
			d.Show ();
			#endregion

		}
	}
}

