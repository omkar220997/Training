using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStoringElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Elements=new int[10];
            for(int i=0; i<Elements.Length; i++)
            {
                Console.WriteLine("Enter Value for the " + i + " position");
                Elements[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<Elements.Length; i++)
            {
                Console.Write(Elements[i] + " ");
                //Console.WriteLine($"Array element at {i} is {Elements[i]}");
            }
            Console.ReadLine();
        }
    }
}
