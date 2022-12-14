using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method5
{
    public class Program
    {
        static string Student (string name)
        {
            Console.Write ("Name of student is : ");
            return name;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of student:");
            string name=Console.ReadLine();
            Console.WriteLine(Student (name));
            Console.ReadLine();
        }
    }
}
