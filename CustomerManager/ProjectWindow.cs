using System;
using System.Drawing;
using System.Drawing.Design;
using HollyLibrary;
using System.Diagnostics;
using System.Threading;

namespace CustomerManager
{
	public partial class ProjectWindow : Gtk.Window
	{
		public ProjectWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

			#region DateTimePicker / HDateEdit
			HDateEdit d = new HDateEdit();
			d.DateTimeFormatType = DateTimeFormatTypeEnum.ShortDate;
			//table1.Attach(d, 2,3,0,1);

			d.Show ();
			#endregion
		}
		protected void OnNewSupplierButtonClicked (object sender, EventArgs e)
		{
			Projects pj = new Projects();

		}
	}
}

