using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class Manager
    {
        public string NameOfManager;
        public double BasicSalary;
        public double Bonus;
        public double PaidLeaves;
        public double NonPaidLeaves;
        public double DailyWages;
        public double MontlySalary;

        public void SalaryOfJuniorSoftwareEngineer()
        {
            Console.WriteLine("Basic salary for " + NameOfManager + " is " + BasicSalary);
            Console.WriteLine("Total Paid leaves " + NameOfManager + "  taken is " + PaidLeaves);
            Console.WriteLine("Total Non-Paid leaves " + NameOfManager + " taken is " + NonPaidLeaves);
            Console.WriteLine("Current Month salary of " + NameOfManager + " is " + MontlySalary);
        }

    }
}
