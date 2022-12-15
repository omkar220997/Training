using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class TeamLeader
    {
        public string NameOfTeamLeader;
        public double BasicSalary;
        public double Bonus;
        public double PaidLeaves;
        public double NonPaidLeaves;
        public double DailyWage;
        public double MonthlySalary;

        public void SalaryOfTeamLeader()
        {
            Console.WriteLine("Basic salary for " + NameOfTeamLeader + " is " + BasicSalary);
            Console.WriteLine("Total Paid leaves of " + NameOfTeamLeader + "  taken is " + PaidLeaves);
            Console.WriteLine("Total Non-Paid leaves of " + NameOfTeamLeader + " taken is " + NonPaidLeaves);
            Console.WriteLine("Current Month salary of " + NameOfTeamLeader + " is " + MonthlySalary);
        }
    }
}
