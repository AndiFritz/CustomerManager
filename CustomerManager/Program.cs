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
//			MainWindow win = new MainWindow ();

			MainWindow win = new MainWindow (/*Pid, Pname*/);
			win.Show ();
			Application.Run ();
		}
	}
}
