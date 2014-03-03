using System;
using Gtk;
using CustomerManager;

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

	//Button "neuer Kunde"
	protected void OnCustomerActivated (object sender, EventArgs e)
	{
		CustomerWindow newCW = new CustomerWindow();
		newCW.Show();

	}	

	//Button "neuer Liferant"
	protected void OnAddDeliveryActivated (object sender, EventArgs e)
	{
		SupplierWindow newSW = new SupplierWindow();
		newSW.Show();

	}





}
