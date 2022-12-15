using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class AddInfo
    {
        public double dailyWage;
        public double monthlySalary;
        public List<Manager> Managers=new List<Manager>();
        public List<DepartmentHead> DepartmentHeads = new List<DepartmentHead>();
        public List<TeamLeader> TeamLeaders= new List<TeamLeader>();
        public List<SeniorSoftwareEngineer> SeniorSoftwareEngineers = new List<SeniorSoftwareEngineer>();
        public List<JuniorSoftwareEngineer> JuniorSoftwareEngineers = new List<JuniorSoftwareEngineer>();
        
        public void AddManager()
        {
            AddInfo addInfo = new AddInfo();
            Console.WriteLine("Name of the Manager is ");
            var nameOfManager=Console.ReadLine();
            Console.WriteLine("Basic Salary of Manager is ");
            string basicSalaryString=Console.ReadLine();
            var basicSalary=Convert.ToDouble(basicSalaryString);
            Console.WriteLine("Bonus of Manager is ");
            string bonusString = Console.ReadLine();
            var bonus = Convert.ToDouble(bonusString);
            Console.WriteLine("Paid leaves of Manager is ");
            string paidLeavesString = Console.ReadLine();
            var paidLeaves = Convert.ToDouble(paidLeavesString);
            Console.WriteLine("Non-Paid leaves of Manager is ");
            string nonPaidLeavesString = Console.ReadLine();
            var nonPaidLeaves = Convert.ToDouble(nonPaidLeavesString);
            Console.WriteLine("Daily Wage of Manager is ");
            var dialyWage = basicSalary / 30;
            Console.WriteLine("Monthly Salary of Manager is ");
            var monthlySalary = basicSalary + bonus - (dailyWage * nonPaidLeaves);
            
            AddManager(nameOfManager, basicSalary, bonus, paidLeaves, nonPaidLeaves,dialyWage,monthlySalary);
           


        }
        public void AddManager(string nameOfManager,double basicSalary,double bonus,double paidLeaves,double nonPaidLeaves,double dailyWage,double monthlySalary)
        {
            var manager=new Manager();
            manager.NameOfManager=nameOfManager;
            manager.BasicSalary=basicSalary;
            manager.Bonus=bonus;
            manager.PaidLeaves=paidLeaves;
            manager.NonPaidLeaves=nonPaidLeaves;
            manager.DailyWage=dailyWage;
            manager.MonthlySalary = monthlySalary;
            Managers.Add(manager);
            Console.WriteLine("Manager " + manager.NameOfManager + " is added");
          

        }
        public void AddDepartmentHead()
        {
            AddInfo addInfo = new AddInfo();

            Console.WriteLine("Name of the Department Head is ");
            var nameOfDepartmentHead = Console.ReadLine();
            Console.WriteLine("Basic Salary of Department Head is ");
            string basicSalaryString = Console.ReadLine();
            var basicSalary = Convert.ToDouble(basicSalaryString);
            Console.WriteLine("Bonus of  Department Head is ");
            string bonusString = Console.ReadLine();
            var bonus = Convert.ToDouble(bonusString);
            Console.WriteLine("Paid leaves of  Department Head is ");
            string paidLeavesString = Console.ReadLine();
            var paidLeaves = Convert.ToDouble(paidLeavesString);
            Console.WriteLine("Non-Paid leaves of  Department Head is ");
            string nonPaidLeavesString = Console.ReadLine();
            var nonPaidLeaves = Convert.ToDouble(nonPaidLeavesString);
            Console.WriteLine("Daily Wage of  Department Head is ");
            var dialyWage = basicSalary / 30;
            Console.WriteLine("Monthly Salary of  Department Head is ");
            var monthlySalary = basicSalary + bonus - (dailyWage * nonPaidLeaves);
            AddDepartmentHead(nameOfDepartmentHead,basicSalary, bonus, paidLeaves, nonPaidLeaves, dialyWage, monthlySalary);
        }
        public void AddDepartmentHead(string nameOfDepartmentHead, double basicSalary, double bonus, double paidLeaves, double nonPaidLeaves, double dailyWage, double monthlySalary)
        {
            var departmentHead = new DepartmentHead();
            departmentHead.NameOfDepartmentHead = nameOfDepartmentHead;
            departmentHead.BasicSalary = basicSalary;
            departmentHead.Bonus = bonus;
            departmentHead.PaidLeaves = paidLeaves;
            departmentHead.NonPaidLeaves = nonPaidLeaves;
            departmentHead.DailyWage= dailyWage;
            departmentHead.MonthlySalary = monthlySalary;
            DepartmentHeads.Add(departmentHead);
            Console.WriteLine("Department Head "+departmentHead.NameOfDepartmentHead+ " is added");
           

        }
        public void AddTeamLeader()
        {
            AddInfo addInfo = new AddInfo();

            Console.WriteLine("Name of the Team Leader is ");
            var nameOfTeanLeader = Console.ReadLine();
            Console.WriteLine("Basic Salary of Team Leader is ");
            string basicSalaryString = Console.ReadLine();
            var basicSalary = Convert.ToDouble(basicSalaryString);
            Console.WriteLine("Bonus of Team Leader is ");
            string bonusString = Console.ReadLine();
            var bonus = Convert.ToDouble(bonusString);
            Console.WriteLine("Paid leaves of Team Leader is ");
            string paidLeavesString = Console.ReadLine();
            var paidLeaves = Convert.ToDouble(paidLeavesString);
            Console.WriteLine("Non-Paid leaves of Team Leader is ");
            string nonPaidLeavesString = Console.ReadLine();
            var nonPaidLeaves = Convert.ToDouble(nonPaidLeavesString);
            Console.WriteLine("Daily Wage of Team Leader is ");
            var dialyWage = basicSalary / 30;
            Console.WriteLine("Monthly Salary of Team Leader is ");
            var monthlySalary = basicSalary + bonus - (dailyWage * nonPaidLeaves);
            AddTeamLeader(nameOfTeanLeader, basicSalary, bonus, paidLeaves, nonPaidLeaves, dialyWage, monthlySalary);

        }
        public void AddTeamLeader(string nameOfTeamLeader, double basicSalary, double bonus, double paidLeaves, double nonPaidLeaves, double dailyWage, double monthlySalary)
        {
            var teamLeader = new TeamLeader();
            teamLeader.NameOfTeamLeader = nameOfTeamLeader;
            teamLeader.BasicSalary = basicSalary;
            teamLeader.Bonus = bonus;
            teamLeader.PaidLeaves = paidLeaves;
            teamLeader.NonPaidLeaves = nonPaidLeaves;
            teamLeader.DailyWage = dailyWage;
            teamLeader.MonthlySalary = monthlySalary;
            TeamLeaders.Add(teamLeader);
            Console.WriteLine("TeamLeader " +teamLeader.NameOfTeamLeader+ " is added");
          
        }
        public void AddSeniorSoftwareEngineer()
        {
            AddInfo addInfo = new AddInfo();

            Console.WriteLine("Name of the Senior Software Engineer is ");
            var nameOfSeniorSoftwareEngineer = Console.ReadLine();
            Console.WriteLine("Basic Salary of Senior Software Engineer is ");
            string basicSalaryString = Console.ReadLine();
            var basicSalary = Convert.ToDouble(basicSalaryString);
            Console.WriteLine("Bonus of Senior Software Engineer is ");
            string bonusString = Console.ReadLine();
            var bonus = Convert.ToDouble(bonusString);
            Console.WriteLine("Paid leaves of Senior Software Engineer is ");
            string paidLeavesString = Console.ReadLine();
            var paidLeaves = Convert.ToDouble(paidLeavesString);
            Console.WriteLine("Non-Paid leaves of Senior Software Engineer is ");
            string nonPaidLeavesString = Console.ReadLine();
            var nonPaidLeaves = Convert.ToDouble(nonPaidLeavesString);
            Console.WriteLine("Daily Wage of Senior Software Engineer is ");
            var dialyWage = basicSalary / 30;
            Console.WriteLine("Monthly Salary of Senior Software Engineer is ");
            var monthlySalary = basicSalary + bonus - (dailyWage * nonPaidLeaves);
            AddSeniorSoftwareEngineer(nameOfSeniorSoftwareEngineer, basicSalary, bonus, paidLeaves, nonPaidLeaves, dialyWage, monthlySalary);
        }
        public void AddSeniorSoftwareEngineer(string nameOfSeniorSoftwareEngineer, double basicSalary, double bonus, double paidLeaves, double nonPaidLeaves, double dailyWage, double monthlySalary)
        {
            var seniorSoftwareEngineer = new SeniorSoftwareEngineer();
            seniorSoftwareEngineer.NameOfSeniorSoftwareEngineer = nameOfSeniorSoftwareEngineer;
            seniorSoftwareEngineer.BasicSalary = basicSalary;
            seniorSoftwareEngineer.Bonus = bonus;
            seniorSoftwareEngineer.PaidLeaves = paidLeaves;
            seniorSoftwareEngineer.NonPaidLeaves = nonPaidLeaves;
            seniorSoftwareEngineer.DailyWage = dailyWage;
            seniorSoftwareEngineer.MonthlySalary = monthlySalary;
            SeniorSoftwareEngineers.Add(seniorSoftwareEngineer);
            Console.WriteLine("Senior Software Engineer " + seniorSoftwareEngineer.NameOfSeniorSoftwareEngineer + " is added");
            
        }
        public void AddJuniorSoftwareEngineer()
        {
            AddInfo addInfo = new AddInfo();

            Console.WriteLine("Name of the Junior Software Engineer is ");
            var nameOfJuniorSoftwareEngineer = Console.ReadLine();
            Console.WriteLine("Basic Salary of Junior Software Engineer is ");
            string basicSalaryString = Console.ReadLine();
            var basicSalary = Convert.ToDouble(basicSalaryString);
            Console.WriteLine("Bonus of Junior Software Engineer is ");
            string bonusString = Console.ReadLine();
            var bonus = Convert.ToDouble(bonusString);
            Console.WriteLine("Paid leaves of Junior Software Engineer is ");
            string paidLeavesString = Console.ReadLine();
            var paidLeaves = Convert.ToDouble(paidLeavesString);
            Console.WriteLine("Non-Paid leaves of Junior Software Engineer is ");
            string nonPaidLeavesString = Console.ReadLine();
            var nonPaidLeaves = Convert.ToDouble(nonPaidLeavesString);
            Console.WriteLine("Daily Wage of Junior Software Engineer is ");
            var dialyWage = basicSalary / 30;
            Console.WriteLine("Monthly Salary of Junior Software Engineer is ");
            var monthlySalary = basicSalary + bonus - (dailyWage * nonPaidLeaves);
            AddJuniorSoftwareEngineer(nameOfJuniorSoftwareEngineer, basicSalary, bonus, paidLeaves, nonPaidLeaves, dialyWage, monthlySalary);

        }
        public void AddJuniorSoftwareEngineer(string nameOfJuniorSoftwareEngineer, double basicSalary, double bonus, double paidLeaves, double nonPaidLeaves, double dailyWage, double monthlySalary)
        {
            var juniorSoftwareEngineer = new JuniorSoftwareEngineer();
            juniorSoftwareEngineer.NameOfJuniorSoftwareEngineer = nameOfJuniorSoftwareEngineer;
            juniorSoftwareEngineer.BasicSalary = basicSalary;
            juniorSoftwareEngineer.Bonus = bonus;
            juniorSoftwareEngineer.PaidLeaves = paidLeaves;
            juniorSoftwareEngineer.NonPaidLeaves = nonPaidLeaves;
            juniorSoftwareEngineer.DailyWage = dailyWage;
            juniorSoftwareEngineer.MonthlySalary = monthlySalary;
            JuniorSoftwareEngineers.Add(juniorSoftwareEngineer);

            Console.WriteLine("Junior Software engineer " + juniorSoftwareEngineer.NameOfJuniorSoftwareEngineer + " is added");
           

        }

        public void SalaryDetailOfManager()
        {
            Console.WriteLine("Salalry Details of Manager is ");
            foreach(var manager in Managers)
            {
                manager.SalaryOfManager();
            }
        }

        public void SalaryDetailsOfDepartmentHead()
        {
            Console.WriteLine("Salalry Details of Department Head is ");
            foreach (var departmentHead in DepartmentHeads)
            {
                departmentHead.SalaryOfDepartmentHead();
            }
        }
        public void SalaryDetailsOfTeamLeader()
        {
            Console.WriteLine("Salalry Details of Team Leader is ");
            foreach (var teamLeader in TeamLeaders)
            {
                teamLeader.SalaryOfTeamLeader();
            }
        }
        public void SalaryDetailsOfSeniorSoftwareEngineer()
        {
            Console.WriteLine("Salalry Details of Senior Software Engineer is ");
            foreach (var seniorSoftwareEngineer in SeniorSoftwareEngineers)
            {
                seniorSoftwareEngineer.SalaryOfSeniorSoftwareEngineer();
            }
        }
        public void SalaryDetailsOfJuniorSoftwareEngineer()
        {
            Console.WriteLine("Salalry Details of Junior Software Engineer is ");
            foreach (var juniorSoftwareEngineer in JuniorSoftwareEngineers)
            {
                juniorSoftwareEngineer.SalaryOfJuniorSoftwareEngineer();
            }
        }
    }
}
