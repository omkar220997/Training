using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterAndSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.RadiusProperty = 10;
            double radius = c.RadiusProperty;
            Console.WriteLine(radius);
            Console.ReadLine();
        }
    }
}
