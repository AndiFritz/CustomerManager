using System;

namespace CustomerManager
{
	public class Customer
	{
		public Customer ()
		{
			//sqlite_conn = new SqliteConnection ("Data Source="+System.Environment.CurrentDirectory.ToString()+"/customerManager.sqlite3");
		}

		public bool addCustomer() // Kunde hinzufügen 
		{	
			try
			{
			sqlite_cmd = sqlite_conn.CreateCommand ();

				sqlite_cmd.CommandText = "INSERT into tbl_customers()";
			}

			catch
			{

			}

			try
			{
			sqlite_cmd = sqlite_conn.CreateCommand ();

				sqlite_cmd.CommandText = "INSERT into tbl_customers(id,vname,nname,typ,email,telnumber,mobilenumber,plz,country,hnr,street,registrationdate,gender)";
			}

			catch
			{

			}

		}
		 
		public bool dropCustomer() // Kunde löschen
		{
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

