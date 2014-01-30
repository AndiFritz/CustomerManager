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
			return true; 
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

