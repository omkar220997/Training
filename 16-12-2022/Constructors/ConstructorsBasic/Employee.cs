using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsBasic
{
    internal class Employee
    {
        string EmployeeName;
        int EmployeeId;

        protected internal Employee()
        {
            Console.WriteLine("Enter a name of Employee");
            EmployeeName =Console.ReadLine();
            Console.WriteLine("Enter employee id of Employee");
            EmployeeId = Convert.ToInt32(Console.ReadLine());
        }
        protected internal void Details()
        {
            
            Console.WriteLine("Name of the employee is " + EmployeeName);
            Console.WriteLine("Employee id of employee is " +EmployeeId);
        }
    }
}
