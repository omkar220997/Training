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
        double MobileNumber;
        int lenght;
        string FIRSTNAME;
        string firstname;
        bool isPresent;
        string StringConcat;
        string hobby = "bikes";


        public void FormDetails()

        {
            Console.WriteLine("Enter a first name");
             firstName = Console.ReadLine();
            Console.WriteLine("Enter a last name");
             lastName = Console.ReadLine();
            Console.WriteLine("Enter a Email");
             email = Console.ReadLine();
            Console.WriteLine("Enter a Mobile Number");
             String MobileNumberstr= Console.ReadLine();
            MobileNumber=Convert.ToDouble(MobileNumberstr);
        }

        public void ShowDetails()
        {
            Console.WriteLine("First name is :" + firstName);
            Console.WriteLine("Last name is :" + lastName);
            Console.WriteLine("Email is " + email);
            Console.WriteLine("Mobile Number is " + MobileNumber);
            Console.WriteLine("hello " + firstName + " " + lastName + " Good Morning");
           string StringFormat=string.Format("hello {0} {1} Good Afternoon", firstName, lastName);
            
            Console.WriteLine(StringFormat);
            Console.WriteLine($"Hello {firstName} {lastName} Good Evening");
            Console.WriteLine(hobby);

        }
        public void Methods()
        {
            lenght=firstName.Length;
            FIRSTNAME=firstName.ToUpper();
            firstname=firstName.ToLower();
            isPresent = firstName.Contains("o");
            StringConcat=String.Concat(firstName,lastName);
            string Hobby = hobby.Substring(0, 1);
            string HobbyUpperCase=Hobby.ToUpper();
            string Hobby1=hobby.Substring(1, 4);
            Console.WriteLine(String.Concat(HobbyUpperCase, Hobby1));


        }
        public void ShowMethodds()
        {
            Console.WriteLine(lenght);
            Console.WriteLine(FIRSTNAME);
            Console.WriteLine(firstname);
            Console.WriteLine(isPresent);
            Console.WriteLine(firstName + lastName);
            Console.WriteLine(StringConcat);
        }
    }
}
