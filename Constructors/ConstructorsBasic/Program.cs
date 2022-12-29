using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsBasic
{
    internal class Program
    {
        int i; bool b;
        static void Main(string[] args)
        {
            Program p=new Program();
            //the value of i and b is defined by implicit constructor
            // which is implicitly created by the compiler.
            Console.WriteLine("Value of i is " +p.i);
            Console.WriteLine("Value of b is " +p.b);
            // the value of EmployeeName and EmployeeId is assigned by programmer 
            // in explicitly called constructor and the Details method is used to display the values.
            Employee employee = new Employee();
            employee.Details();



            Console.ReadLine();
        }
    }
}
