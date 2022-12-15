using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class AddInfo
    {
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
            AddManager(nameOfManager, basicSalary, bonus, paidLeaves, nonPaidLeaves);
           


        }
        public void AddManager(string nameOfManager,double basicSalary,double bonus,double paidLeaves,double nonPaidLeaves)
        {
            var manager=new Manager();
            manager.NameOfManager=nameOfManager;
            manager.BasicSalary=basicSalary;
            manager.Bonus=bonus;
            manager.PaidLeaves=paidLeaves;
            manager.NonPaidLeaves=nonPaidLeaves;
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
            AddDepartmentHead(nameOfDepartmentHead,basicSalary, bonus, paidLeaves, nonPaidLeaves);
        }
        public void AddDepartmentHead(string nameOfDepartmentHead, double basicSalary, double bonus, double paidLeaves, double nonPaidLeaves)
        {
            var departmentHead = new DepartmentHead();
            departmentHead.NameOfDepartmentHead = nameOfDepartmentHead;
            departmentHead.BasicSalary = basicSalary;
            departmentHead.Bonus = bonus;
            departmentHead.PaidLeaves = paidLeaves;
            departmentHead.NonPaidLeaves = nonPaidLeaves;
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
            AddTeamLeader(nameOfTeanLeader, basicSalary, bonus, paidLeaves, nonPaidLeaves);

        }
        public void AddTeamLeader(string nameOfTeamLeader, double basicSalary, double bonus, double paidLeaves, double nonPaidLeaves)
        {
            var teamLeader = new TeamLeader();
            teamLeader.NameOfTeamLeader = nameOfTeamLeader;
            teamLeader.BasicSalary = basicSalary;
            teamLeader.Bonus = bonus;
            teamLeader.PaidLeaves = paidLeaves;
            teamLeader.NonPaidLeaves = nonPaidLeaves;
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
            AddSeniorSoftwareEngineer(nameOfSeniorSoftwareEngineer, basicSalary, bonus, paidLeaves, nonPaidLeaves);
        }
        public void AddSeniorSoftwareEngineer(string nameOfSeniorSoftwareEngineer, double basicSalary, double bonus, double paidLeaves, double nonPaidLeaves)
        {
            var seniorSoftwareEngineer = new SeniorSoftwareEngineer();
            seniorSoftwareEngineer.NameOfSeniorSoftwareEngineer = nameOfSeniorSoftwareEngineer;
            seniorSoftwareEngineer.BasicSalary = basicSalary;
            seniorSoftwareEngineer.Bonus = bonus;
            seniorSoftwareEngineer.PaidLeaves = paidLeaves;
            seniorSoftwareEngineer.NonPaidLeaves = nonPaidLeaves;
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
            AddJuniorSoftwareEngineer(nameOfJuniorSoftwareEngineer, basicSalary, bonus, paidLeaves, nonPaidLeaves);

        }
        public void AddJuniorSoftwareEngineer(string nameOfJuniorSoftwareEngineer, double basicSalary, double bonus, double paidLeaves, double nonPaidLeaves)
        {
            var juniorSoftwareEngineer = new JuniorSoftwareEngineer();
            juniorSoftwareEngineer.NameOfJuniorSoftwareEngineer = nameOfJuniorSoftwareEngineer;
            juniorSoftwareEngineer.BasicSalary = basicSalary;
            juniorSoftwareEngineer.Bonus = bonus;
            juniorSoftwareEngineer.PaidLeaves = paidLeaves;
            juniorSoftwareEngineer.NonPaidLeaves = nonPaidLeaves;
            JuniorSoftwareEngineers.Add(juniorSoftwareEngineer);
            Console.WriteLine("Junior Software engineer " + juniorSoftwareEngineer.NameOfJuniorSoftwareEngineer + " is added");
           

        }

    }
}
