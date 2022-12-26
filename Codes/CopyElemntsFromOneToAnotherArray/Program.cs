using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyElemntsFromOneToAnotherArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size here");
            int ArraySize = Convert.ToInt32(Console.ReadLine());
            int[] Elements1 = new int[ArraySize];
            int[] Elements2 = new int[ArraySize];
            for (int i = 0; i < Elements1.Length; i++)
            {
                Console.WriteLine("Enter Value for the " + i + " position");
                Elements1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of original Array ");

            for (int i =0; i < Elements1.Length; i++)
            {
                Console.WriteLine(Elements1[i]+ " ");
                //Console.WriteLine($"Array element at {i} is {Elements[i]}");
            }
            Console.WriteLine("Elements of Copied Array ");
            for (int i = 0; i < Elements1.Length; i++)
            {
                Elements2[i] = Elements1[i];
                Console.WriteLine(Elements2[i] + " ");

            }
            Console.ReadLine();
        }
    }
}
