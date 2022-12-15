using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    internal class Information
    {
        string firstName;
        string lastName;
        string email;
        string MobileNumber;
        public void FormDetails()
        {
            Console.WriteLine("Enter a first name");
             firstName = Console.ReadLine();
            Console.WriteLine("Enter a last name");
             lastName = Console.ReadLine();
            Console.WriteLine("Enter a Email");
             email = Console.ReadLine();
            Console.WriteLine("Enter a Mobile Number");
             MobileNumber= Console.ReadLine();
        }

        public void ShowDetails()
        {
            Console.WriteLine("First name is :" + firstName);
            Console.WriteLine("Last name is :" + lastName);
            Console.WriteLine("Email is " + email);
            Console.WriteLine("Mobile Number is " + MobileNumber);

        }
    }
}
