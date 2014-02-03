using System;
using Mono.Data;
using Mono.Data.Sqlite;

namespace CustomerManager
{
	public class Customer
	{

		SqliteConnection sqlite_conn;
		SqliteCommand sqlite_cmd;
		SqliteDataReader datareader;

		public Customer ()
		{
			sqlite_conn = new SqliteConnection ("Data Source="+System.Environment.CurrentDirectory.ToString()+"/customerManager.sqlite3");
		}

		public bool addCustomer(string gender, string nname, string vname,string typ, string email, string telnumber, string mobilenumber, int plz, string country, string street, string hnr, DateTime regidate) // Kunde hinzufügen 
		{	

			try
			{


				sqlite_cmd = sqlite_conn.CreateCommand (); 
				sqlite_cmd.CommandText = "INSERT into tbl_customers(vname,nname,typ,email,telnumber,mobilenumber,plz,country,hnr,street,registrationdate,gender) VALUE ('"+vname+"','"+nname+"','"+typ+"','"+email+"','"+telnumber+"','"+mobilenumber+"','"+plz+"','"+country+"','"+hnr+"','"+street+"','"+regidate+"','"+gender+"')";

				return true;
			}

			catch (Exception ex)
			{
				return false;
			}


		}
		 
		public bool dropCustomer(string email) // Kunde löschen
		{
			try 
			{
				sqlite_cmd =sqlite_conn.CreateCommand();
				sqlite_cmd.CommandText ="DELETE FROM customers WHERE email='"+email+"'";

			} 

			catch (Exception ex)
			{
	
			}
			return true; 
		}

		public bool viewCustomer() //bestimmter Kunde anzeigen
		{
			return true; 
		}

		public bool viewCusomers() // Alle Kunden anzeigen
		{
			return true; 
		}
	}
}

