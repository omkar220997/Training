using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Information details = new Information();
            details.FormDetails();
            details.ShowDetails();
            details.Methods();
            details.ShowMethodds(); 
            
            Console.ReadLine();

        }
    }
}
