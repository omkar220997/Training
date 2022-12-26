using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumbersinArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size here");
            int ArraySize = Convert.ToInt32(Console.ReadLine());
            int[] Elements = new int[ArraySize];
            int[] DuplicateElements = new int[ArraySize];
            for (int i = 0; i < Elements.Length; i++)
            {
                Console.WriteLine("Enter Value for the " + i + " position");
                Elements[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Elements.Length; i++)
            {
                Console.Write(Elements[i] + " ");

                //Console.WriteLine($"Array element at {i} is {Elements[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("Unique Values in Array are: ");
            for (int i = 0; i < Elements.Length; i++)
            {
                for (int j = 0; j < Elements.Length; j++)
                {
                    if (!Elements.Contains(Elements[j]))
                    {
                        DuplicateElements[j] = Elements[j];
                        Console.Write(DuplicateElements[j] + " ");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
