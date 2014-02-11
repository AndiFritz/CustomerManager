using System;
using System.Collections.Generic;

namespace CustomerManager
{
	public abstract class DBConnector
	{
		public abstract bool login(String user, String password);
		public abstract bool addUser(String gender, String vname, String nname, String uname, String password, String email, String telnumber, String mobilenumber, Int32 plz, String country, String street, String hnr, DateTime regidate, Int16 status, string cname, string ctyp);
		public abstract bool addCompany(String name, Int16 plz, String country, String street, String hnr, String web, String pname, String email, String telnumber, String mobilenumber, DateTime regidate, String typ);
		public abstract List<string> readCompany(String typ);
	}
}

