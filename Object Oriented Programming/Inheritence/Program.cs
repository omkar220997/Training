using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Company
    {
        public string companyName;
        public string companyAddress;

        public void CompDetails(string companyName, string companyAddress)
        {
            this.companyName = companyName;
            this.companyAddress = companyAddress;
            Console.WriteLine("Name of the company is " +companyName);
            Console.WriteLine("Address of the company is " +companyAddress);

        }
    }

    public class Employee : Company
    {
        public string empName;
        public int empAge;
        public int empSalary;

        public void EmpDetails(string empName, int empAge, int empSalary)
        {
            
            this.empName = empName;
            this.empAge = empAge;   
            this.empSalary = empSalary;
            Console.WriteLine("Name of employee is " + empName);
            Console.WriteLine("Age of employee is " + empAge);
            Console.WriteLine("Salary of employee is " + empSalary);
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company Details: ");
            Company comp = new Company();
            comp.CompDetails("Klingelnberg", "Bhosari MIDC Pume");
            Console.WriteLine("......................................................");
            Console.WriteLine("Employee Details : ");
            Employee emp = new Employee();
            emp.CompDetails("Klingelnberg", "Bhosari MIDC Pune");
            emp.EmpDetails("Omkar Kadam", 25, 25000);
            Console.ReadLine();
        }
    }
}
