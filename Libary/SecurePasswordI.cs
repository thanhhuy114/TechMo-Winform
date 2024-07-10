using System.Security.Cryptography;
using System.Text;


namespace Librarys
{
    public class SecurePasswordI
    {
        public static string Encode(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {
                sbHash.Append($"{b}2:5");
            }
            return (sbHash.ToString());
        }

        public static string Encode(int password)
        {
            string pass = password.ToString();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {
                sbHash.Append($"{b}2:5");
            }
            return (sbHash.ToString());
        }
    }
}
