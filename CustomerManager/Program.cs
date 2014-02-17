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

			MainWindow win = new MainWindow ();
			connection = new SQLiteConnection(); // heir muss die Klasse geaendert werden, wenn man eine andere Datenbank verwenden will 

			win.Show ();
			Application.Run ();
		}
	}
}
