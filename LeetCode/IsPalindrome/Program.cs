using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    internal class Program
    {
        public bool IsPalindrome(int x)
        {
            int ReveresNumber = 0;
            int Remaining;
            bool result = true;
            while (x != 0)
            {
                Remaining = x % 10;
                ReveresNumber = ReveresNumber * 10 + Remaining;
                x /= 10;
            }
            if (ReveresNumber.Equals(x))
                
            {
                Console.WriteLine(result);

            }
            else
            {
                result = false;
                Console.WriteLine(result);

            }
            return result;

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int x = Convert.ToInt32(Console.ReadLine());
            p.IsPalindrome(x);
            Console.ReadLine();
        }
    }
}
