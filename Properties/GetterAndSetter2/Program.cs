using GetterAndSetter2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerProperties customerProperties = new CustomerProperties();
            //Console.WriteLine(customerProperties.CustomerName);
            //Only Value getting is applicable Bcoz it is a readonly property.
            Console.BackgroundColor= ConsoleColor.Magenta;
            customerProperties.CustomerDisplay();
            Console.ReadLine();
        }
    }
}
