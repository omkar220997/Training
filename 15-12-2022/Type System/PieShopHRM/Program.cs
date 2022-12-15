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
