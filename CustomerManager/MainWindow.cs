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

	protected void OnAddAction1Activated (object sender, EventArgs e)
	{
//		MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "neuer Benutzer hinzufügen!");
//		md.Run();
//		md.Destroy();
//		ProjectWindow projectWindow = new ProjectWindow();
//		projectWindow.Show();
	}

}
