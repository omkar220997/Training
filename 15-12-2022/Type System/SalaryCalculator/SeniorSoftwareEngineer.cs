using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class SeniorSoftwareEngineer
    {
        public string NameOfSeniorSoftwareEngineer;
        public double BasicSalary;
        public double Bonus;
        public double PaidLeaves;
        public double NonPaidLeaves;
        public double DailyWage;
        public double MonthlySalary;

        public void SalaryOfSeniorSoftwareEngineer()
        {
            Console.WriteLine("Basic salary for " + NameOfSeniorSoftwareEngineer + " is " + BasicSalary);
            Console.WriteLine("Total Paid leaves of " + NameOfSeniorSoftwareEngineer + "  taken is " + PaidLeaves);
            Console.WriteLine("Total Non-Paid leaves of " + NameOfSeniorSoftwareEngineer + " taken is " + NonPaidLeaves);
            Console.WriteLine("Current Month salary of " + NameOfSeniorSoftwareEngineer + " is " + MonthlySalary);
        }
    }
}
