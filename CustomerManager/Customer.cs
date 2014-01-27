using System;

namespace CustomerManager
{
	public class Customer
	{
		public Customer ()
		{
			sqlite_conn = new SqliteConnection ("Data Source="+System.Environment.CurrentDirectory.ToString()+"/customerManager.sqlite3");
		}

		public bool addCustomer() // Kunde hinzufügen 
		{	

		}
		 
		public bool dropCustomer() // Kunde löschen
		{

		}

		public bool viewCustomer() //bestimmter Kunde anzeigen
		{

		}

		public bool viewCusomers() // Alle Kunden anzeigen
		{

		}
	}
}

