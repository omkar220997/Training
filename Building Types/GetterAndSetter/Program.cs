using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterAndSetter
{
    public class Employee
    {
        private string name;
        private int age ;

        public string Name
        {
            get 
            { 
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)) 
                {
                    name = value;
                }
                
            }

        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value > 0) 
                { 
                    age = value;
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Prasad";
            employee.Age = 25;
            Console.WriteLine($"Name of the employee is {employee.Name}");
            Console.WriteLine($"Age of the employee is {employee.Age}");
            Console.ReadLine();
        }
    }
}
