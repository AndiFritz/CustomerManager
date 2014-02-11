using System;
using Gtk;
using System.Collections.Generic;
using Mono.Data.Sqlite;
using System.Data;
using System.Diagnostics;

namespace CustomerManager
{
	public class SQLiteConnection : DBConnector
	{
		SqliteConnection sqlite_conn;
		SqliteCommand sqlite_cmd;
		SqliteDataReader datareader;

		public SQLiteConnection ()
		{
			connect ();
		}
		private bool connect()
		{
			sqlite_conn = new SqliteConnection ("Data Source=" + System.Environment.CurrentDirectory.ToString () + "/customerManager.sqlite3");
			try {
				sqlite_conn.Open ();
			} catch (Exception e) {
				return false;
				//TODO Log errors
			}
			return true;
		}

		#region Login
		public override bool login (string uname, string pwd)
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
						bool loginOK = this.checkPassword(uname, pwd);

						if(loginOK == true)
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

				if(!connect())
					throw new Exception();

				// Now the SQLiteCommand object can give us a DataReader-Object:
				int amountUser = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
				sqlite_conn.Close();
				
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
			catch(Exception exce)
			{
				sqlite_conn.Close ();

				MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, Convert.ToString(exce));
				md.Run();
				md.Destroy(); 
				return true;
			}
		}

		private bool checkUserExist(string uname) // existiert ein Benutzer mit dem angegebenen Benutzernamen?
		{
			try
			{
				#region Benutzername vorhanden - Prüfung
				sqlite_cmd = sqlite_conn.CreateCommand ();
				
				sqlite_cmd.CommandText = "SELECT count(*) FROM tbl_users Where uname='"+uname+"'";

				sqlite_conn.Open ();

				// Now the SQLiteCommand object can give us a DataReader-Object:
				int exist = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

				sqlite_conn.Close(); 
				
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
			catch(Exception ex)
			{
				sqlite_conn.Close ();
				MessageDialog md = new MessageDialog(null, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, "Es ist ein Fehler bei der Benutzerauslesung geschehen!");
				md.Run();
				md.Destroy(); 
				return false; 
			}
		}
		#endregion

		#region Userkonfigurationen
		public override bool addUser (string gender, string vname, string nname, string uname, string password, string email, string telnumber, string mobilenumber, Int32 plz, string country, string street, string hnr, DateTime regidate, Int16 status, string cname, string ctyp) //Benutzer im System hinzufügen
		{
			if (ctyp == "Privat") 
			{

				try {
					sqlite_cmd = sqlite_conn.CreateCommand ();
					sqlite_cmd.CommandText = "INSERT into tbl_users(gender, vname, nname, uname, password, email, telnumber, mobilenumber, plz, country, street, hnr, regidate, fk_companies, status) VALUES ('"+gender+"', '"+vname+"', '"+nname+"', '"+uname+"', '"+password+"','"+email+"','"+telnumber+"','"+mobilenumber+"','"+plz+"','"+country+"','"+street+"','"+hnr+"','"+regidate+"','1','1')";
					sqlite_conn.Open ();
					sqlite_cmd.ExecuteNonQuery ();
					sqlite_conn.Close ();
					return true; 
				} catch (Exception ex) {
					sqlite_conn.Close ();
					return false; 
				}
			} 
			else 
			{
				int fk_companies = this.getFKcompany (cname);
				
				try {
					sqlite_cmd = sqlite_conn.CreateCommand ();
					sqlite_cmd.CommandText = "INSERT into tbl_users(gender, vname, nname, uname, password, email, telnumber, mobilenumber, plz, country, street, hnr, regidate, fk_companies, status) VALUES ('"+gender+"', '"+vname+"', '"+nname+"', '"+uname+"','"+password+"','"+email+"','"+telnumber+"','"+mobilenumber+"','"+plz+"','"+country+"','"+street+"','"+hnr+"','"+regidate+"','"+fk_companies+"','1')";
					sqlite_conn.Open ();
					sqlite_cmd.ExecuteNonQuery ();
					sqlite_conn.Close ();
					return true; 
				} catch (Exception ex) {
					sqlite_conn.Close ();
					return false; 
				}
			}
		}

		public bool dropUser(string username, string email, string pwd) // Benutzer im System löschen
		{
			try 
			{
				sqlite_cmd = sqlite_conn.CreateCommand ();
				sqlite_cmd.CommandText = "UPDATE tbl_users SET status='0' WHERE username='"+username+"' AND email='"+email+"'";
				sqlite_conn.Open();
				sqlite_cmd.ExecuteNonQuery();
				sqlite_conn.Close();
				return true; 
			}
			catch (Exception ex) 
			{
				sqlite_conn.Close ();
				return false;
	
			}
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

		public bool checkPassword(string uname, string pwd) // Passwort eines bestimmten Bentzers für den Status ändern prüfen
		{
			try 
			{
				sqlite_cmd = sqlite_conn.CreateCommand();
				sqlite_cmd.CommandText = "Select password From tbl_users WHERE uname='"+uname+"'";

				sqlite_conn.Open();

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
					return false;
				}
			}

			catch (Exception ex)
			{
				sqlite_conn.Close ();
				return false; 
			}
		}

		#region Unternehmen 
		public override bool addCompany (string name, Int16 plz, string country, string street, string hnr, string web, string pname, string email, string telnumber, string mobilenumber, DateTime regidate, string typ)
		{
			int fk_typcompany = getFKTypcompany (typ); //ID von CompanyTyp aus tbl_typcompany bekommen

			try {
				sqlite_cmd = sqlite_conn.CreateCommand ();
				sqlite_cmd.CommandText = "INSERT into tbl_companies(fk_typcompany, name, plz, country, street, hnr, web, pname, email, telnumber, mobilenumber, regidate) VALUES ('"+fk_typcompany+"', '"+name+"', '"+plz+"', '"+country+"', '"+street+"','"+hnr+"','"+web+"','"+pname+"','"+email+"','"+telnumber+"','"+mobilenumber+"','"+regidate+"')";
				sqlite_conn.Open ();
				sqlite_cmd.ExecuteNonQuery ();
				sqlite_conn.Close ();
				return true; 
			} catch (Exception ex) {
				sqlite_conn.Close ();
				return false; 
			}
		}


		private int getFKcompany(string name)
		{
			try {
				sqlite_cmd = sqlite_conn.CreateCommand ();

				sqlite_cmd.CommandText = "SELECT id FROM tbl_companies WHERE name='"+name+"'";

				sqlite_conn.Open();

				datareader = sqlite_cmd.ExecuteReader ();
				
				int readID = 99999999; // ausgelesene ID von Typ von Company
				
				while (datareader.Read())
				{
					readID = datareader.GetInt16(0);
				}

				sqlite_conn.Close ();
				return readID; 
			} 
			catch (Exception ex) 
			{
				sqlite_conn.Close ();
				return 99999999; 
			}
		}


		private int getFKTypcompany (string typ)
		{
			try {
				sqlite_cmd = sqlite_conn.CreateCommand ();
				
				sqlite_cmd.CommandText = "SELECT id FROM tbl_typcompany WHERE typ ='"+typ+"'";
				
				sqlite_conn.Open();
				
				datareader = sqlite_cmd.ExecuteReader ();
				
				int readID = 99999999; // ausgelesene ID von Typ von Company
				
				while (datareader.Read())
				{
					readID = datareader.GetInt16(0);
				}
				
				sqlite_conn.Close ();
				return readID; 
			} 
			catch (Exception ex) 
			{
				sqlite_conn.Close ();
				return 99999999; 
			}
		}

		public override System.Collections.Generic.List<string> readCompany (string typ)
		{
			int fk_typcompany = getFKTypcompany (typ); //ID von CompanyTyp aus tbl_typcompany bekommen
			
			try {
				
				sqlite_cmd = sqlite_conn.CreateCommand ();
				
				sqlite_cmd.CommandText = "SELECT name FROM tbl_companies WHERE fk_typcompany ='"+fk_typcompany+"'";
				
				sqlite_conn.Open();
				
				datareader = sqlite_cmd.ExecuteReader ();
				
				string readname = ""; // ausgelesene ID von Typ von Company
				List<string> companies = new List<string>();
				
				while (datareader.Read())
				{
					readname = datareader.GetString(0);
					companies.Add (readname);
				}
				sqlite_conn.Close ();
				return companies; 
			}  
			catch (Exception ex) 
			{
				sqlite_conn.Close ();
				return null; 
			}
		}

		#endregion


	}
}

