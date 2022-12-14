using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    interface Company
    {
        void  CompName(string a);
        void Address(string a);
    }

    interface Department
    {
        void DeptName(string a);

    }

    interface Manager
    {
        void ManName(string a);
    }

    interface TeamLead
    {
        void TlName(string a);
    }

    public class Employee : Company, Department, Manager, TeamLead
    {
        string compName;
        string compAddress;
        string deptName;
        string manName;
        string tlName;
        string empName;

        public void CompName(string compName)
        {
            this.compName = compName;
        }
        public void Address(string compAddress)
        {
            this.compAddress = compAddress;
        }
        public void DeptName(string deptName)
        {
            this.deptName = deptName;
        }
        public void ManName(string manName)
        {
            this.manName = manName;
        }
        public void TlName(string tlName)
        {
            this.tlName = tlName;
        }
        public void EmpName(string empName)
        {
            this.empName=empName;
        }
        public void Display()
        {
            Console.WriteLine("Name of the employee is " +empName);
            Console.WriteLine("Name of the company is " +compName);
            Console.WriteLine("Address of the company is " +compAddress);
            Console.WriteLine("Name of the Department is " +deptName);
            Console.WriteLine("Name of the MAnaager is " +manName);
            Console.WriteLine("Name of the Team Leader is " +tlName);
        } 
        
    }

    public  class Program
    {
        static void Main(string[] args)
        {
            Employee e1=new Employee();
            e1.EmpName("Omkar Kadam");
            e1.CompName("Klingelnberg");
            e1.Address("Bhosari MIDC Pune");
            e1.DeptName("IT");
            e1.ManName("Kapil");
            e1.TlName("Prashant");
            e1.Display();
            Console.ReadLine();
        }
    }
}
