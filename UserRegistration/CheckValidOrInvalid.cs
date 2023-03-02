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
        public static void ValidFirstName()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] arr = { "keerti", "Keerti" };

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is Valid First Name", input);
                }
                else
                {
                    Console.WriteLine("{0} is invalid First Name", input);
                }
            }
        }
    }
}
