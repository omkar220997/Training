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
        public int Bonus;
        public int PaidLeaves;
        public int NonPaidLeaves;
        public double DailyWages;
        public int MontlySalary;

        public void SalaryOfJuniorSoftwareEngineer()
        {
            Console.WriteLine("Basic salary for " + NameOfJuniorSoftwareEngineer + " is " + BasicSalary);
            Console.WriteLine("Total Paid leaves " +NameOfJuniorSoftwareEngineer+ "  taken is " +PaidLeaves);
            Console.WriteLine("Total Non-Paid leaves " +NameOfJuniorSoftwareEngineer+ " taken is "+NonPaidLeaves);
            Console.WriteLine("Current Month salary of " + NameOfJuniorSoftwareEngineer + " is " + MontlySalary);
        }
    }
}
