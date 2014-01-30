using System;
using Gtk;
using Mono.Data.Sqlite;
using System.Data;
using System.Diagnostics;

namespace CustomerManager
{
	public class Connection
	{
		SqliteConnection sqlite_conn;
		SqliteCommand sqlite_cmd;
		SqliteDataReader datareader;

		public Connection ()
		{
			sqlite_conn = new SqliteConnection ("Data Source="+System.Environment.CurrentDirectory.ToString()+"/customerManager.sqlite3");
		}


		#region Login
		public bool login (string uname, string pwd)
		{
			try 
			{			
				bool userExist = this.checkAmountUser(); // ist ein User im System vorhanden?

				if (userExist == false)
				{
					MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Info, ButtonsType.Ok, "Herzlich Willkommen zu CustomerManager! Sie müssen nur noch einen Benutzer anlegen und schon kann es losgehen!");
					md.Run();
					md.Destroy();

					CustomerWindow cw = new CustomerWindow(); //neuer Benutzer muss erstellt werden 
					cw.addUser(); 

					return false; 
				}
				else
				{
					bool corrUname = this.checkUserExist(uname);
						
					if(corrUname == true)
					{
						sqlite_cmd = sqlite_conn.CreateCommand ();
						
						sqlite_cmd.CommandText = "SELECT password FROM tbl_users WHERE username='"+uname+"'";

						sqlite_conn.Open (); //Datenbankverbindung öffnen

						// Now the SQLiteCommand object can give us a DataReader-Object:
						datareader = sqlite_cmd.ExecuteReader ();

						string readPwd = ""; // ausgelesene Passwort für den Benutzernamen 


						while (datareader.Read())
						{
							readPwd = datareader.GetString(0);
						}
						sqlite_conn.Close ();

						if(readPwd == pwd)
						{
							return true; 
						}
						else
						{
							MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, "Das Passwort stimmt nicht!");
							md.Run();
							md.Destroy();
							return false;
						}
					}
					else
					{
						MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, "Dieser Benutzername ist nicht im System vorhanden!");
						md.Run();
						md.Destroy();
						return false; 
					}
				}
			} 
			catch (Exception x)
			{
				sqlite_conn.Close ();
				MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, x.Message);
				md.Run();
				md.Destroy();
				return false; 
			}
		}

		private bool checkAmountUser()
		{
			try
			{
				#region Benutzername vorhanden - Prüfung
				sqlite_cmd = sqlite_conn.CreateCommand ();
				
				sqlite_cmd.CommandText = "SELECT count(*) FROM tbl_users";
				
				sqlite_conn.Open();
				
				// Now the SQLiteCommand object can give us a DataReader-Object:
				int amountUser = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
				
				if(amountUser == 0)
				{
					return false; 
				}
				else
				{
					return true;
				}
				#endregion
			}
			catch
			{
				MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, "Es ist ein Fehler bei der Benutzerauslesung geschehen!");
				md.Run();
				md.Destroy(); 
				return false; 
			}
		}

		private bool checkUserExist(string uname) // existiert ein Benutzer mit dem angegebenen Benutzernamen?
		{
			try
			{
				#region Benutzername vorhanden - Prüfung
				sqlite_cmd = sqlite_conn.CreateCommand ();
				
				sqlite_cmd.CommandText = "SELECT count(*) FROM tbl_users Where username='"+uname+"'";
				
				sqlite_conn.Open();
				
				// Now the SQLiteCommand object can give us a DataReader-Object:
				int exist = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
				
				if(exist == 0)
				{
					return false; 
				}
				else
				{
					return true;
				}
				#endregion
			}
			catch
			{
				MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, "Es ist ein Fehler bei der Benutzerauslesung geschehen!");
				md.Run();
				md.Destroy(); 
				return false; 
			}
		}
		#endregion

		#region Userkonfigurationen
		public bool addUser(string vname, string nname, string uname, string password, string email, string telnumber, string mobilenumber, string country, string regidate) //Benutzer im System hinzufügen
		{
			try {
				sqlite_cmd = sqlite_conn.CreateCommand ();
				
				sqlite_cmd.CommandText = "INSERT into tbl_users(vname, nname, username, password, email, telnumber, mobilenumber, country, registrationdate) VALUES ('"+vname+"', '"+nname+"', '"+uname+"','"+password+"','"+email+"','"+telnumber+"','"+mobilenumber+"','"+country+"','"+regidate+"')";
				
				sqlite_conn.Open();

				sqlite_cmd.ExecuteNonQuery();

				return true; 

			} catch (Exception ex) {
				return false; 
			}
		}

		public bool dropUser() // Benutzer im System löschen
		{
			return true; 
		}

		public bool viewUser() // Benutzer anzeigen
		{
			return true; 
		}

		public bool viewUsers () // Alle Benutzer im System anzeigen
		{
			return true; 
		}
		#endregion

	}
}

