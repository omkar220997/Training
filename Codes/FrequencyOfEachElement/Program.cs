using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfEachElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int SizeOfArray=Convert.ToInt32(Console.ReadLine());
            int[] Array=new int[SizeOfArray];
            int[] StoringArray=new int[SizeOfArray];
            Console.WriteLine("Enter the elements of array");
            for (int i = 0; i < SizeOfArray; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
                StoringArray[i] = -1;
            }
            for(int i = 0; i < Array.Length; i++)
            {
                int FrequencyCount = 1;

                for (int j=i+1; j < Array.Length; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        FrequencyCount++;
                        StoringArray[j] = 0;
                    }

                }
                if(StoringArray[i] != 0)
                {
                    StoringArray[i] = FrequencyCount;
                }
            }
            for(int i=0; i < Array.Length; i++)
            {
                if (StoringArray[i] != 0)
                {
                    Console.WriteLine($"Count of {Array[i]} is {StoringArray[i]}");

                }
            }
            Console.ReadLine();
        }
    }
}
