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
        public double DailyWages;
        public double MontlySalary;

        public void SalaryOfJuniorSoftwareEngineer()
        {
            Console.WriteLine("Basic salary for " + NameOfTeamLeader + " is " + BasicSalary);
            Console.WriteLine("Total Paid leaves " + NameOfTeamLeader + "  taken is " + PaidLeaves);
            Console.WriteLine("Total Non-Paid leaves " + NameOfTeamLeader + " taken is " + NonPaidLeaves);
            Console.WriteLine("Current Month salary of " + NameOfTeamLeader + " is " + MontlySalary);
        }
    }
}
