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
				
				sqlite_cmd.CommandText = "SELECT count(*) FROM tbl_users Where username='"+uname+"'";
				
				sqlite_conn.Open();
				
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
			catch
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
				sqlite_cmd.CommandText = "Select password From tbl_users WHERE username='"+uname+"'";
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
				return 1; 
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
				return 1; 
			}
		}

		#endregion

		#region Customer
		public override bool addCustomer (string gender, string vname, string nname, string email, string telnumber, string mobilenumber, int plz, string country, string street, string hnr, string regidate, string cname)
		{
			int fk_companies = this.getFKcompany (cname);

			try 
			{
				sqlite_cmd = sqlite_conn.CreateCommand ();
				sqlite_cmd.CommandText = "INSERT INTO tbl_customers (nname, vname, fk_companies, email, telnumber, mobilenumber, plz, country, street, hnr, regidate, gender, status) VALUES ('"+nname+"', '"+vname+"','"+fk_companies+"','"+email+"','"+telnumber+"','"+mobilenumber+"','"+plz+"','"+country+"','"+street+"','"+hnr+"','"+regidate+"','"+gender+"','1')";
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


		#endregion
		 
		#region Supplier

		public override List<string> readTyp ()
		{
			try 
			{
				sqlite_cmd = sqlite_conn.CreateCommand ();				
				sqlite_cmd.CommandText = "SELECT typ FROM tbl_typ";
				datareader = sqlite_cmd.ExecuteReader ();

				string readname = ""; // ausgelesene ID von Typ von Company
				List<string> typs = new List<string>();
				
				while (datareader.Read())
				{
					readname = datareader.GetString(0);
					typs.Add (readname);
				}
				sqlite_conn.Close ();
				return typs; 
			} 
			catch (Exception ex)
			{
				sqlite_conn.Close ();
				return null; 
			}
		}

		private int getFKtyp(string typ)
		{
			try {
				sqlite_cmd = sqlite_conn.CreateCommand ();				
				sqlite_cmd.CommandText = "SELECT id FROM tbl_typ WHERE typ ='"+typ+"'";
				sqlite_conn.Open();
				
				datareader = sqlite_cmd.ExecuteReader ();
				
				int readID = 0;
				
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
				return 0; 
			}
		}

		private int getFKsupplier (string supplier)
		{
			try {
				sqlite_cmd = sqlite_conn.CreateCommand ();				
				sqlite_cmd.CommandText = "SELECT id FROM tbl_suppliers WHERE name ='"+supplier+"'";
				sqlite_conn.Open();
				
				datareader = sqlite_cmd.ExecuteReader ();
				
				int readID = 0;
				
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
				return 0; 
			}
		}

		public override bool addSupplier(String name, String street, String hnr, Int32 plz, String land, String web, String typ, String pname, String email, String telephone, String mobile, String regidate)
		{


			try 
			{
				sqlite_cmd = sqlite_conn.CreateCommand ();
				sqlite_cmd.CommandText = "INSERT INTO tbl_suppliers (name, plz, country, street, hnr, web, pname, email, telnumber, mobilenumber, regidate) VALUES ('"+name+"', '"+plz+"','"+land+"','"+street+"','"+hnr+"','"+web+"','"+pname+"','"+email+"','"+telephone+"','"+mobile+"','"+regidate+"')";
				sqlite_conn.Open(); 
				sqlite_cmd.ExecuteNonQuery();
				sqlite_conn.Close();

				int fksupplier = getFKsupplier(name);
				int fktyp = getFKtyp(typ);

				sqlite_cmd = sqlite_conn.CreateCommand ();
				sqlite_cmd.CommandText = "INSERT INTO tbl_suppliers_typ (fk_suppliers, fk_typ) VALUES ('"+fksupplier+"','"+fktyp+"')";
				sqlite_conn.Open ();
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

		public override bool addSupTyp (String typ)
		{
			try 
			{
				sqlite_cmd = sqlite_conn.CreateCommand ();
				sqlite_cmd.CommandText = "INSERT INTO tbl_typ (typ) VALUES ('"+typ+"')";
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
		#endregion


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
	
		public override System.Collections.Generic.List<string> readProjectDetails (short Pid, string Pname) //Auslesung Projektdetails
		{
			try {
				
				sqlite_cmd = sqlite_conn.CreateCommand ();
				
				sqlite_cmd.CommandText = "SELECT startdate, enddate, description, hourprice FROM tbl_projects WHERE (id ="+Pid+" AND name='"+Pname+"')";
				
				datareader = sqlite_cmd.ExecuteReader ();

				string readstartdate = ""; 
				string readenddate = ""; 
				string readDescript = ""; 
				int readhourprice = 0; 

				List<string> projDetails = new List<string>();

				while (datareader.Read())
				{
					readstartdate = datareader.GetString(0); 
					readenddate = datareader.GetString(1);
					readDescript = datareader.GetString(2);
					readhourprice = datareader.GetInt16(3);
				}
				sqlite_conn.Close ();

				projDetails.Add(Convert.ToString (readstartdate));
				projDetails.Add (Convert.ToString(readenddate));
				projDetails.Add (readDescript);
				projDetails.Add (Convert.ToString (readhourprice));

				return projDetails;
			}  
			catch (Exception ex) 
			{
				sqlite_conn.Close ();
				return null; 
			}
			
		}

		public override Int64 readSumHours (short projID)
		{
			try {
				
				sqlite_cmd = sqlite_conn.CreateCommand ();
				sqlite_cmd.CommandText = "SELECT sum(duration) FROM tbl_times WHERE fk_projects = "+projID+"";

				sqlite_conn.Open ();

				datareader = sqlite_cmd.ExecuteReader ();
				
				Int64 readDuration = 0;
				Int64 gesDuration = 0;
				
				while (datareader.Read())
				{
					gesDuration = datareader.GetInt64(0); 
				}
				sqlite_conn.Close ();
				
				return gesDuration;
			}  
			catch (Exception ex) 
			{
				sqlite_conn.Close ();
				return 0; 
			}
		}

		public override bool addStartTime (short projID, string date, string startTime, string description, short userID)
		{
			try {
				sqlite_cmd = sqlite_conn.CreateCommand ();
				sqlite_cmd.CommandText = "INSERT into tbl_times(fk_projects, date, starttime, description, fk_user) VALUES ('"+projID+"', '"+date+"', '"+startTime+"', '"+description+"', "+userID+")";
				sqlite_conn.Open ();
				sqlite_cmd.ExecuteNonQuery ();
				sqlite_conn.Close ();
				return true; 
			} catch (Exception ex) {
				sqlite_conn.Close ();
				return false; 
			}
		}

		public override bool addEndTime (short projID, string date, string startTime, string endTime, int duration, string description, short userID, int price)
		{
			try {
				sqlite_cmd = sqlite_conn.CreateCommand ();
				sqlite_cmd.CommandText = "UPDATE tbl_times SET endtime='"+endTime+"', description='"+description+"', duration = "+duration+", price = "+price+" WHERE (fk_projects = "+projID+" AND date = '"+date+"' AND starttime='"+startTime+"' AND fk_user = "+userID+")";
				sqlite_conn.Open ();
				sqlite_cmd.ExecuteNonQuery ();
				sqlite_conn.Close ();
				return true; 
			} catch (Exception ex) {
				sqlite_conn.Close ();
				return false; 
			}
		}

		public override bool readStemps (short projID)
		{
			throw new System.NotImplementedException ();
		}

	}
}

