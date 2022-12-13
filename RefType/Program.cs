using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object created using new keyword
            child first = new child(5, "Akash");
            child second = new child(7, "Shubham");

            //object created using default constructor 
            child third = new child();

            // output
            Console.Write("Child First: ");
            first.ChildInfo();
            Console.Write("Child Second: ");
            second.ChildInfo();
            Console.Write("Child Third: ");
            third.ChildInfo();

            Console.ReadLine();
        }
    }
}
