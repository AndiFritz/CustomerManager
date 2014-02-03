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

<<<<<<< HEAD
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
=======
//		static string GetMd5Hash(MD5 md5Hash, string input)
//		{
////			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
////			StringBuilder sBuilder = new StringBuilder();
////			
////			for (int i = 0; i < data.Length; i++)
////			{
////				sBuilder.Append(data[i].ToString("x2"));
////			}
////			
////			return sBuilder.ToString();
//		}
>>>>>>> e62c9eb0045699cf7cf5b2c366cd9f4aa4d8ac18
	}
}

