using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            DepartmentHead departmentHead = new DepartmentHead();
            TeamLeader teamLeader = new TeamLeader();
            SeniorSoftwareEngineer seniorSoftwareEngineer = new SeniorSoftwareEngineer();
            JuniorSoftwareEngineer juniorSoftwareEngineer = new JuniorSoftwareEngineer();
            Calculator calculator = new Calculator();
            Console.WriteLine("Type the 'Add','Salary details' to enter details of Employee");
            Console.WriteLine("Type'Quit' to exit from application");
            var details = true;
            while (details)
            {
                var Action = Console.ReadLine();
               
                 
                if (Action == "Add")
                {
                    var details1 = true;
                    while (details1)
                    {
                        Console.WriteLine("Type the designation of Employee like 'Manager','Department Head','Team Leader','Senior Software Engineer','Junior Software Engineer' to add details");
                        var Action1 = Console.ReadLine();

                        if (Action1 == "Manager")
                        {
                            calculator.AddManager();
                        }
                        else if (Action1 == "Department Head")
                        {
                            calculator.AddDepartmentHead();
                        }
                        else if (Action1 == "Team Leader")
                        {
                            calculator.AddTeamLeader();
                        }
                        else if (Action1 == "Senior Software Engineer")
                        {
                            calculator.AddSeniorSoftwareEngineer();
                        }
                        else if (Action1 == "Junior Software Engineer")
                        {
                            calculator.AddJuniorSoftwareEngineer();
                        }
                         

                    }


                }
            }
            Console.ReadLine();
        }
    }
}
