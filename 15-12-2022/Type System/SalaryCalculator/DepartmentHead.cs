using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class DepartmentHead
    {
        public string NameOfDepartmentHead;
        public double BasicSalary;
        public double Bonus;
        public double PaidLeaves;
        public double NonPaidLeaves;
        public double DailyWage;
        public double MonthlySalary;

        public void SalaryOfDepartmentHead()
        {
            Console.WriteLine("Basic salary for " + NameOfDepartmentHead + " is " + BasicSalary);
            Console.WriteLine("Total Paid leaves of " + NameOfDepartmentHead + "  taken is " + PaidLeaves);
            Console.WriteLine("Total Non-Paid leaves of " + NameOfDepartmentHead + " taken is " + NonPaidLeaves);
            Console.WriteLine("Current Month salary of " + NameOfDepartmentHead + " is " + MonthlySalary);
        }
    }
}
