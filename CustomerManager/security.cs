using System;
using System.Security.Cryptography;
using System.Text;


namespace CustomerManager
{
	public class security
	{
		public security ()
		{

		}


		public static string hashSHA512(string password)
		{
			SHA512 shaM = new SHA512Managed();
			byte[] hash =
				shaM.ComputeHash(Encoding.ASCII.GetBytes(password));
			
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in hash)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

	}
}

