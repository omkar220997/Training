using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basicMonthlyWage = 15000;
            int months = 12;
            int bonus = 3000;
            bool isActive = true;
            double employeerating = 9.5;

            double ratePerHour = 68.18;
            double numberOfHoursWorked = 220;
            
            double currentMonthWage=ratePerHour*numberOfHoursWorked;
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            DateTime Joindate = new DateTime(2022, 12,05 ,09, 00, 0);
            Console.WriteLine(Joindate);

            double d = 245369.252;
            int x = Convert.ToInt32(d);
            Console.WriteLine("Value of x is " +x);

            int a = 10;
            double b = a;
            Console.WriteLine("value of b is " + b);
            if(numberOfHoursWorked > 200)
            {
                currentMonthWage+=bonus;
                Console.WriteLine(currentMonthWage);

            }
            else
            {
                Console.WriteLine(currentMonthWage);

            }
            Console.ReadLine();
        }
    }
}
