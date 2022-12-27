using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of 2D-Array");
            int FirstSize =Convert.ToInt32(Console.ReadLine());
            int SecondSize =Convert.ToInt32(Console.ReadLine());
            int[,] Original2DArray = new int[FirstSize,SecondSize];
            Console.WriteLine("Enter the elements of 2D-Array");
            for( int i = 0; i < FirstSize; i++)
            {
                for( int j = 0; j < SecondSize; j++)
                {
                    Console.WriteLine($"Enter the element for {i} , {j} position");
                    Original2DArray[i,j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int i = 0; i < FirstSize; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < SecondSize; j++)
                {
                    Console.Write("{0}\t",Original2DArray[i, j]);

                }
            }
            Console.ReadLine();

        }
    }
}
