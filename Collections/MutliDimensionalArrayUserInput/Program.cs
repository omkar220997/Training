using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutliDimensionalArrayUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        { 
         int[,] Marks = new int[5,5];
            for (int i = 0; i < Marks.GetLength(0); i++)
            {
                for (int j = 0; j < Marks.GetLength(1); j++)
                {
                    Console.WriteLine($" Enter the Marks of student {i + 1} in semister{j + 1} :");
                    Marks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i<Marks.GetLength(0); i++)
            {
                for (int j=0;j<Marks.GetLength(1); j++)
                {
                   Console.Write(Marks[i,j]+" ");
                   

                   // Console.WriteLine($" Marks for student {i + 1} in semister{j+1}  is {Marks[i, j]}");
                }
    Console.WriteLine();
            }
Console.ReadLine();
        }
    }
}
