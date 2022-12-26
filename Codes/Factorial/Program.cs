using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Factorial = 1;
            Console.WriteLine("Enter Your Number Here:");
            int Number=Convert.ToInt32(Console.ReadLine());
            if (Number == 0)
            {
                Console.WriteLine("Factorial of 0 is 1");
            }
            else if(Number == 1)
            {
                Console.WriteLine("Factorial of 1 is 1");
            }
            else if (Number > 1)
            {
                for(int i = 1; i <= Number; i++)
                {
                    Factorial*=i;
                }
                Console.WriteLine($"Factorial of {Number} is {Factorial}");

            }
            Console.ReadLine();
        }
    }
}
