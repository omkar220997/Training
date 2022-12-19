using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfConstructors
{
    internal class ParameterizedConstructor
    {
         string Name;
        double MobileNumber;

        internal ParameterizedConstructor(string name, double mobileNumber)
        {
            Console.WriteLine("My name on ID is " +(Name = name));
            Console.WriteLine("Emregency Contact number is "+(MobileNumber = mobileNumber));
        }
    }
}
