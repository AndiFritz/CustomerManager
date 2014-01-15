using System;
using Gtk;

namespace CustomerManager
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			loginWindow win = new loginWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
