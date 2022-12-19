using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefaultConstructor defaultConstructor = new DefaultConstructor();
            ParameterizedConstructor parameterizedConstructor1 = new ParameterizedConstructor("omkar kadam", 8080770371);
            ParameterizedConstructor parameterizedConstructor2 = new ParameterizedConstructor("Digvijay Nalage", 9022845203);
            CopyConstructor copyConstructor = new CopyConstructor("Klingelnberg");
            CopyConstructor copyConstructor1 = new CopyConstructor(copyConstructor);
            copyConstructor.Display();
            copyConstructor1.Display();
            Console.ReadLine();
        }
    }
}
