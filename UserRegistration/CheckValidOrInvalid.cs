using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CheckValidOrInvalid
    {
        public static void CheckInput(string pattern, string[] arr)
        {
            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is Valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is invalid", input);
                }
            }
        }

        // UC1
        public static void ValidFirstName()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] arr = { "keerti", "Keerti" };
            CheckInput(pattern, arr);
        }

        // UC2
        public static void ValidLastName()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] arr = { "kakhani", "Kakhani" };
            CheckInput(pattern, arr);
        }

        //UC3

        public static void ValidEmailAddress()
        {

            string pattern = "^[a-z]+([_+.-]?[a-z0-9]+)*[@][a-z0-9]+[.](com|net|com.au|com.com)$";
            string[] arr = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            CheckInput(pattern, arr);
        }

        // UC4
        public static void ValidMobileNumber()
        {
            string pattern = "^91[ ]{1}[6-9]{1}[0-9]{9}$";
            string[] arr = { "91 7726005633", "917742735615", "91 5231476823", "05234567812", "0 6234567823", "915231476823", "9191 7742720112" };
            CheckInput(pattern, arr);
        }

        // UC5
        public static void ValidPassword()
        {
            string pattern = "^[a-zA-Z0-9!=@?#$.%+&*_]{8,}$";
            string[] arr = { "abA01", "abcdAABC", "abc11ABC", "AAbc@%11&*" };
            CheckInput(pattern, arr);
        }
    }
}


