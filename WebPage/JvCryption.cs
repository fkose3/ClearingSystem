using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebPage
{
    public class JvCryption
    {
        public string SetCryptionText(string value)
        {
            var return_value = String.Empty;
            int i = 30;
            foreach (char current in value)
            {
                return_value = Convert.ToChar(current + i++).ToString();
            }
            return return_value;
        }

        public string GetCryptionText(string value)
        {
            var return_value = String.Empty;
            int i = 30;
            foreach (char current in value)
            {
                return_value = Convert.ToChar(current - i++).ToString();
            }
            return return_value;
        }

        public string GetUserAccountPassword(string value)
        {
            return GetCryptionText(MD5Hash(value)).Substring(0,16).ToUpper();
        }

        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}