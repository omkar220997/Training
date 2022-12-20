using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Marks = { { 32, 26, 37, 34, 25 }, { 25, 29, 32, 38, 22 }, { 36, 32, 35, 32, 31 } };
            for (int i = 0; i < Marks.GetLength(0); i++)
            {
                for (int j=0;j<Marks.GetLength(1); j++)
                {
                   // Console.Write(Marks[i,j]+" ");
                   

                    Console.WriteLine($" Marks for student {i + 1} in semister{j+1}  is {Marks[i, j]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
