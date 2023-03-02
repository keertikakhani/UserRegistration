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
    }
}


