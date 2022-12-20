using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][][] Numbers = new int[][][]
            {
                new int[][]
                {
                    new int [] { 1, 1,1,1,1 },
                    new int [] { 2, 2,2,2,2,2, },
                    new int [] { 3, 3,3,3,3,3,3,3},
                    new int [] { 4,4,4,4 }
                },
                new int[][]
                {
                    new int [] { 5,5,5,5 },
                    new int [] { 6,6,6,6,6,6,6,6 },

                },
                new int[][]
                {
                    new int [] { 7,7,7 },
                    new int [] { 8,8,8,8,8,8 },
                    new int [] { 9,9,9,9,9},

                }
            };
            for(int i = 0; i < Numbers.Length; i++)
            {
                for(int j = 0; j < Numbers[i].Length; j++)
                {
                    for( int k = 0; k < Numbers[i][j].Length; k++)
                    {
                        Console.Write($"Values are at {i}{j}{k} " +Numbers[i][j][k]+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
    
