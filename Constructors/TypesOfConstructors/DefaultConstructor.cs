using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfConstructors
{
    internal class DefaultConstructor
    {
        int x = 10;
        string name = "Omkar";

        internal DefaultConstructor()
        {
            Console.WriteLine("My name is " + name);
            Console.WriteLine("My roll number is " + x);
        }
    }
}
