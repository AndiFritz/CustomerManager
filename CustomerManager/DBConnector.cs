using System;
using System.Collections.Generic;

namespace CustomerManager
{
	public abstract class DBConnector
	{
		public abstract bool login(String user, String password);
		public abstract bool addUser(String gender, String vname, String nname, String uname, String password, String email, String telnumber, String mobilenumber, Int32 plz, String country, String street, String hnr, DateTime regidate, Int16 status, string cname, string ctyp);
		public abstract bool addCompany(String name, Int16 plz, String country, String street, String hnr, String web, String pname, String email, String telnumber, String mobilenumber, DateTime regidate, String typ);
		public abstract List<string> readCompany(String typ); //für ComboBox in Firmenregistrierung; CompanyWindow und CustomerWindow

		public abstract List<string> readProjectDetails(Int16 Pid, String Pname); //Auslesung ProjectBeschreibung für Specific Window
		public abstract Int64 readSumHours(Int16 projID); // Gesamtstunden für Geldbetrag auslesen
		public abstract bool addStartTime(Int16 projID, String date, String startTime, String description, Int16 userID); // Starzeit in Tabelle tbl_times einfügen
		public abstract bool addEndTime(Int16 projID, String date, String startTime, String endTime, Int32 duration, String description, Int16 userID); // Endzeit eintragen in tbl_times
	}	
}

