using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactDetails
{
    public class MyContactDetails
    {
        public static bool MyNameVerification(string str)
        {
            string pattern = @"([А-ЯЁ][а-яё]+[\-\s]?){3,}";
            return Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase) ? true : false;
        }
        public static bool MyAgeVerification(string str)
        {
            string pattern = @"^[1-9][0-9]{0,2}?$";
            return Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase) ? true : false;
        }
        public static bool MyPhoneNumberVerification(string str)
        {
            string pattern = @"\+7\(\d\d\d\)\d\d\d-\d\d-\d\d";
            return Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase) ? true : false;
        }
        public static bool MyEmailVerification(string str)
        {
            string pattern = @"^(([A-zА-я0-9_-]+\.)*[A-zА-я0-9_-]+@[a-z0-9-]+(\.[a-zа-я0-9-]+)*\.[a-z]{2,6})?$";
            return Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase) ? true : false;
        }
    }
}