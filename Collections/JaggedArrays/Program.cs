using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[][] Numbers = new int[][]
            {
                new int[] { 11,12,13,14,15 },
                new int[] { 21,22,23,24,25,26,27},
                new int[] { 31,32,33,34,35,36},
                new int[] { 41,42,43 },
                new int[] { 51,52,53,54,55,56,57,58,59,60 }
            };
            for(int i = 0; i < Numbers.Length; i++)
            {
                for(int j = 0; j < Numbers[i].Length; j++)
                {
                    Console.Write(Numbers[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            
        }
    }
}
