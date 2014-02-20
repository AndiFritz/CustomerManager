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
<<<<<<< HEAD
			connection = new SQLiteConnection(); // heir muss die Klasse geaendert werden, wenn man eine andere Datenbank verwenden will 
			loginWindow win = new loginWindow ();
=======

			MainWindow win = new MainWindow ();
			connection = new SQLiteConnection(); // heir muss die Klasse geaendert werden, wenn man eine andere Datenbank verwenden will 

>>>>>>> 2329f629f5782d2ace94a8ea164da797a1b5d2d7
			win.Show ();
			Application.Run ();
		}
	}
}
