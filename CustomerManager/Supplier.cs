using System;
using Gtk;
using Mono.Data.Sqlite;
using System.Data;
using System.Diagnostics;
namespace CustomerManager
{
	public class Supplier
	{
		SqliteConnection sqlite_conn;
		SqliteCommand sqlite_cmd;
		SqliteDataReader datareader;


		public Supplier ()
		{
			sqlite_conn = new SqliteConnection ("Data Source="+System.Environment.CurrentDirectory.ToString()+"/customerManager.sqlite3");
		}

		public bool addSupplier() // Lieferant hinzufuegen
		{
			return true; 
		}

		public bool dropSupplier () // Lieferant löschen
		{
			return true; 
		}

		public bool viewSupplier () // einzelner Lieferant anzeigen
		{
			return true; 
		}

		public bool viewSuppliers() // Alle Lieferanten anzeigen
		{
			return true; 
		}

	}
}

