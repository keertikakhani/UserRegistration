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
    }
}


