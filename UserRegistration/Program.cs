using System;

namespace UserRegistration
{
    class Program
    {
       public static void Main(string[] args)
       {
            Console.WriteLine("Welcome to User Registration Program");

            CheckValidOrInvalid.ValidFirstName();
            CheckValidOrInvalid.ValidLastName();

            Console.ReadLine();
       }
    }
}
