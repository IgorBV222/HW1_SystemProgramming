using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkWithText
{
    public class MyWorkWithText
    {
        public static bool MyIsPalindrome(string str)
        {
            var left = 0;
            var right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right]) 
                    return false;
                left++;
                right--;
            }
            return true;
        }

        public static bool MyIsPalindrome(int num)
        {
            string str = num.ToString();
            var left = 0;
            var right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        public static int MyNumberProposals(string text)
        {            
            int countproposals = 0; // количество предложений            
            text = Regex.Replace(text, " {2,}", " "); // удаление вторых пробелов
            string[] lines = text.Trim(' ').Split(' ');
            for (int i = 0; i < lines.Length; ++i)
            {               
                char[] mas = lines[i].ToArray();
                if (mas[mas.Length - 1] == '.' || mas[mas.Length - 1] == '?' || mas[mas.Length - 1] == '!')
                {
                    countproposals++;
                }  
            }
            return countproposals;
        }

        public static string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
