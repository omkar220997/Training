using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfConstructors
{
    internal class StaticConstructor
    {
        string type;
       
        internal StaticConstructor(string type)
        {
            Console.WriteLine(type+ " constructor is called");
            
        }
        static StaticConstructor()
        {
            Console.WriteLine("Static constructor is executed");
        }

    }
}
