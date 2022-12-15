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
            AddInfo addInfo = new AddInfo();

            Console.WriteLine("Type the 'Add','Salary Details' to enter details of Employee");
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
                        Console.WriteLine("Type 'Back' for go to main Menu");
                        var Action1 = Console.ReadLine();

                        if (Action1 == "Manager")
                        {
                            addInfo.AddManager();
                        }
                        else if (Action1 == "Department Head")
                        {
                            addInfo.AddDepartmentHead();
                        }
                        else if (Action1 == "Team Leader")
                        {
                            addInfo.AddTeamLeader();
                        }
                        else if (Action1 == "Senior Software Engineer")
                        {
                            addInfo.AddSeniorSoftwareEngineer();
                        }
                        else if (Action1 == "Junior Software Engineer")
                        {
                            addInfo.AddJuniorSoftwareEngineer();
                        }
                        else if (Action1 == "Back")
                        {
                            details1= false;
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid entry");
                        }
                      
                    }
                    Console.WriteLine("Type the 'Add','Salary Details' to enter details of Employee");
                    Console.WriteLine("Type'Quit' to exit from application");

                }
                else if (Action == "Salary Details")
                {
                    var details2 = true;
                    while (details2)
                    {
                        Console.WriteLine("Type the designation of Employee like 'Manager','Department Head','Team Leader','Senior Software Engineer','Junior Software Engineer' to show salary details");
                        Console.WriteLine("Type 'Return' for go to main Menu");
                        var Action2 = Console.ReadLine();

                        if (Action2 == "Manager")
                        {
                            addInfo.SalaryDetailOfManager();
                        }
                        else if (Action2 == "Department Head")
                        {
                            addInfo.SalaryDetailsOfDepartmentHead();
                        }
                        else if (Action2 == "Team Lead")
                        {
                            addInfo.SalaryDetailsOfTeamLeader();
                        }
                        else if (Action2 == "Senior Software Engineer")
                        {
                            addInfo.SalaryDetailsOfSeniorSoftwareEngineer();
                        }
                        else if (Action2 == "Junior Software Engineer")
                        {
                            addInfo.SalaryDetailsOfJuniorSoftwareEngineer();
                        }
                        else if(Action2 == "Return")
                        {
                            details2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid entry");
                        }

                    }
                    Console.WriteLine("Type the 'Add','Salary Details' to enter details of Employee");
                    Console.WriteLine("Type'Quit' to exit from application");

                }
                else if (Action == "Quit")
                {
                    details= false;
                }
                else
                {
                    Console.WriteLine("Enter a valid Command");
                }
            }
           
        }
    }
}
