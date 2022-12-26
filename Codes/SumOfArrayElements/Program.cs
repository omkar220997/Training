using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter array size here");
            int ArraySize = Convert.ToInt32(Console.ReadLine());
            int[] Elements = new int[ArraySize];
            int Sum = 0;
            for (int i = 0; i < Elements.Length; i++)
            {
                Console.WriteLine("Enter Value for the " + i + " position");
                Elements[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = Elements.Length - 1; i >= 0; i--)
            {
               Sum += Elements[i];
            }
            Console.WriteLine("Sum of all Array elemnts is " +Sum);
            Console.ReadLine();
        }
    }
}
