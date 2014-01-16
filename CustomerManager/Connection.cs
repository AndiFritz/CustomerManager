using System;
using Gtk;
using Mono.Data.Sqlite;
using System.Data;
using System.Diagnostics;

namespace CustomerManager
{
	public class Connection
	{
		public Connection ()
		{

		}
	
		public bool login (string uname, string pwd)
		{
			try 
			{
				SqliteConnection sqlite_conn;
				SqliteCommand sqlite_cmd;
				SqliteDataReader datareader;
				
				sqlite_conn = new SqliteConnection ("Data Source="+System.Environment.CurrentDirectory.ToString()+"/customerManager.sqlite3");

#region Benutzername vorhanden - Prüfung
				sqlite_cmd = sqlite_conn.CreateCommand ();
				
				sqlite_cmd.CommandText = "SELECT * FROM tbl_users WHERE username='"+uname+"'";
				
				// Now the SQLiteCommand object can give us a DataReader-Object:
				datareader = sqlite_cmd.ExecuteReader ();


				
				while (datareader.Read())
				{
					datareader.Read (datareader[0]);
				}

#endregion


				// open the connection:
				sqlite_conn.Open ();
				
				sqlite_cmd = sqlite_conn.CreateCommand ();
				
				sqlite_cmd.CommandText = "SELECT * FROM tbl_users WHERE id=1";
				
				// Now the SQLiteCommand object can give us a DataReader-Object:
				sqlite_datareader = sqlite_cmd.ExecuteReader ();
				
				while (sqlite_datareader.Read())
				{
				}
				sqlite_conn.Close ();

			} catch (Exception x)
			{
				MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, x.Message);
				md.Run();
				md.Destroy();
			}
			return true; 
		}
	}
}

