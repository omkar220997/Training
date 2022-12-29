using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a User Name");
            string UserName=Console.ReadLine();
            Console.WriteLine("Enter a Password");
            string Password=Console.ReadLine();
            Console.WriteLine("Re-Enter a Password");
            string ReEnterPassword=Console.ReadLine();
            bool Check=ReEnterPassword.Equals(Password);

            if(UserName==null && Password == null)
            {
                Console.WriteLine("UserName and Password cannot be Empty");
            }
            else if(UserName!=null && Password==null)
            {
                Console.WriteLine("Password cannot be Empty");
            }
            else if(UserName==null && Password != null)
            {
                Console.WriteLine("UserName cannot be Empty");
            }
            else if (Check==true)
            {
                Console.WriteLine("Password MAtched");
                Console.WriteLine("SignUp Finished Now you can Login");
            }
            else if (Check == false)
            {

                bool Check1=true;
                while (Check1)
                {
                    
                    Console.WriteLine("Password Not Matched Enter Password Again");
                    Password = Console.ReadLine();
                    Console.WriteLine("Re-Enter password again");
                    ReEnterPassword = Console.ReadLine();
                    bool Check2 = ReEnterPassword.Equals(Password);

                    if (Check2 == true)
                    {
                        Console.WriteLine("Password Matched Now you can Login");
                        Check1=false;
                    }

                }
                
            }
            else
            {
                Console.WriteLine("You are not eligible");
            }
            Console.ReadLine();
        }
    }
}
