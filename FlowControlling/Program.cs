using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlling
{
    public class employee
    {
        private int id;
        private string name;

        public employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void EmployeeDetails()
        {
            if(id>0 && name != null) 
            {
                Console.WriteLine($" The employee id of {name} is {id}");
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee(0,"Pankaj");
            employee emp2 = new employee(1,"Suraj");
            employee emp3 = new employee(2,"Shubham");
            employee emp4 = new employee(3,null);


            Console.WriteLine("First Employee : ");
            emp1.EmployeeDetails(); 
            Console.WriteLine("Second Employee : ");
            emp2.EmployeeDetails(); 
            Console.WriteLine("Third Employee : ");
            emp3.EmployeeDetails();
            Console.WriteLine("forth Employee : ");
            emp4.EmployeeDetails(); 

            Console.ReadLine();
        }
    }
}
