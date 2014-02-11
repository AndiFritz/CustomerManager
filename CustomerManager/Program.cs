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
			MainWindow win = new MainWindow ();
=======
			connection = new SQLiteConnection(); // heir muss die Klasse geaendert werden, wenn man eine andere Datenbank verwenden will 
			loginWindow win = new loginWindow ();
>>>>>>> 97911445a2e8bc183c350120e28b627f7d51bab5
			win.Show ();
			Application.Run ();
		}
	}
}
