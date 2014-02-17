using System;
using System.Collections.Generic;
using Gtk;
using System.Drawing; 
using System.Drawing.Design;
using CustomerManager;



<<<<<<< HEAD
public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		this.Title = "Customer Manager";
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnAddCustomerMBActivated (object sender, EventArgs e)
	{
		CustomerWindow cw = new CustomerWindow();
		cw.ShowAll();
	}
	protected void OnAddCustomerTBActivated (object sender, EventArgs e)
	{
		CustomerWindow cw = new CustomerWindow();
		cw.Show ();
	}
}
=======
public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		this.Title = "Customer Manager";
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnAddCustomerMBActivated (object sender, EventArgs e)
	{
		CustomerWindow cw = new CustomerWindow();
		cw.ShowAll();
	}
	protected void OnAddCustomerTBActivated (object sender, EventArgs e)
	{
		CustomerWindow cw = new CustomerWindow();
		cw.Show ();
	}
	protected void OnRemoveCustomerMBActivated (object sender, EventArgs e)
	{
		CustomerWindow cw = new CustomerWindow();
		cw.Show ();
	}
}
>>>>>>> 27a1df76239bb9f24f8c071ed251ab843957f8b7
