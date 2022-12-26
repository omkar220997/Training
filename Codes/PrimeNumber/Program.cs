using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter Number Here To Check");
            Number=Convert.ToInt32(Console.ReadLine());
            if (Number == 0 || Number == 1)
            {
                Console.WriteLine("O or 1 is not a Prime Number Enter value greater than 1");
            }
            else if (Number % 2 == 0)
            {
                Console.WriteLine("Entered Number is Not Prime");
            }
            else
            {
                Console.WriteLine("Entered Number is Prime");
            }
            Console.ReadLine();
        }
    }
}
