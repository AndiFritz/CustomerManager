using System;
using Gtk;
using Mono.Data.Sqlite;
using System.Data;
using System.Diagnostics;

namespace CustomerManager
{
	public class Projects
	{
		SqliteConnection sqlite_conn;
		SqliteCommand sqlite_cmd;
		SqliteDataReader datareader;

		public Projects ()
		{
			sqlite_conn = new SqliteConnection ("Data Source="+System.Environment.CurrentDirectory.ToString()+"/customerManager.sqlite3");
		}

		public bool addProject(string name, DateTime startdate, DateTime enddate, string cname, string editor)
		{
			return true;
		}

		public bool dropProject()
		{
			return true;
		}

		public bool viewProject()
		{
			return true; 
		}
	}
}

