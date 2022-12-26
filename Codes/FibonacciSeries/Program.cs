using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number1 = 0;
            int Number2 = 1;
            int Number3, Target;
            Console.WriteLine("Enter the Series target here");
            Target=Convert.ToInt32(Console.ReadLine());
            Console.Write(Number1 + " " + Number2+" ");
            for(int i = 2; i < Target; ++i)
            {
                Number3 = Number1 + Number2;
                Console.Write(Number3+" ");
                Number1 = Number2;
                Number2=Number3;

            }
            Console.ReadLine();
        }
    }
}
