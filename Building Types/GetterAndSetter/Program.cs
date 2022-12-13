using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterAndSetter
{
    public class Employee
    {
        public const int salary=25000;
        private string name;
        private int age;
        public readonly string company;
        public Employee()
        {
            company = "Klingelnberg";
            Console.WriteLine("Company name of employees is " + company);
            Console.WriteLine("Salary of employee is " + salary);
        }
        
        
        public string Name
        {
            get;
            set;

        }
        public int Age
        {
            get;
            set;
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            employee1.Name = "Prasad";
            employee1.Age = 25;
            
            employee2.Name = "Pankaj";
            employee2.Age = 27;
            employee3.Name = "Kunal";
            employee3.Age = 32;
           
            Console.WriteLine($"Name of the employee1 is {employee1.Name}");
            Console.WriteLine($"Age of the employee1 is {employee1.Age}");
            Console.WriteLine($"Name of the employee2 is {employee2.Name}");
            Console.WriteLine($"Age of the employee2 is {employee2.Age}");
            Console.WriteLine($"Name of the employee3 is {employee3.Name}");
            Console.WriteLine($"Age of the employee3 is {employee3.Age}");
            Console.ReadLine();
        }
    }
}
