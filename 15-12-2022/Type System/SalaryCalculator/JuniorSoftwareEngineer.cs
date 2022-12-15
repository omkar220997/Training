using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class JuniorSoftwareEngineer
    {
        public string NameOfJuniorSoftwareEngineer;
        public double BasicSalary;
        public double Bonus;
        public double PaidLeaves;
        public double NonPaidLeaves;
        public double DailyWage;
        public double MonthlySalary;

        public void SalaryOfJuniorSoftwareEngineer()
        {
            Console.WriteLine("Basic salary for " + NameOfJuniorSoftwareEngineer + " is " + BasicSalary);
            Console.WriteLine("Total Paid leaves of " +NameOfJuniorSoftwareEngineer+ "  taken is " +PaidLeaves);
            Console.WriteLine("Total Non-Paid leaves of " +NameOfJuniorSoftwareEngineer+ " taken is "+NonPaidLeaves);
            Console.WriteLine("Current Month salary of " + NameOfJuniorSoftwareEngineer + " is " + MonthlySalary);
        }
    }
}
