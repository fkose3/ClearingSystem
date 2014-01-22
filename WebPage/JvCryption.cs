using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}