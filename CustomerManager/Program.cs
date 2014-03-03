using System;
using Gtk;

namespace CustomerManager
{
	class MainClass
	{
		public static DBConnector connection; 

		public static void Main (string[] args)
		{
			Application.Init ();
			connection = new SQLiteConnection(); // heir muss die Klasse geaendert werden, wenn man eine andere Datenbank verwenden will 
<<<<<<< HEAD
			MainWindow win = new MainWindow ();
=======
			SpecificWindow win = new SpecificWindow (/*Pid, Pname*/);
>>>>>>> 1fe1e82d2733c617b4025946e7c5649ca245a12d
			win.Show ();
			Application.Run ();
		}
	}
}
