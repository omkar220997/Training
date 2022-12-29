using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimewnsionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] numbers=new int[3,3,3];
            for(int i=0; i<numbers.GetLength(0); i++)
            {
                for(int j=0; j<numbers.GetLength(1); j++)
                {
                    for(int d=0; d<numbers.GetLength(2); d++)
                    {
                        Console.WriteLine($"Enter the value for the {i},{j},{d}");
                        numbers[i,j,d]=Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    for (int d = 0; d < numbers.GetLength(2); d++)
                    {
                        Console.Write(numbers[i,j,d]+" ");
                        //Console.WriteLine($" value for the {i},{j},{d} is {numbers[i,j,d]}");
                        
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
