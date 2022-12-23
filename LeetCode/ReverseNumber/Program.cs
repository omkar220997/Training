using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        public int ReverseNumbers(int Number)
        {
            int ReveresNumber=0;
            int Remaining;
            while(Number != 0)
            {
                Remaining = Number % 10;
                ReveresNumber= ReveresNumber * 10+ Remaining;
                Number /= 10;
            }
            Console.WriteLine("Reverse number is " +ReveresNumber);
            return ReveresNumber;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.ReverseNumbers(Number));
            Console.ReadLine();

        }
    }
}
