using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int SizeOfArray=Convert.ToInt32(Console.ReadLine());
            int[] OriginalArray=new int[SizeOfArray];
            Console.WriteLine("Enter elements of array");
            for(int i=0; i<SizeOfArray; i++)
            {
                OriginalArray[i]=Convert.ToInt32(Console.ReadLine());
            }
            int SecondLargestElement = 0;
            int PositionOfLargestElement=0;
            for(int i=0; i<OriginalArray.Length; i++)
            {
                if (OriginalArray[i] == OriginalArray.Max())
                {
                    PositionOfLargestElement = i;  
                }
                
            }
            for (int i = 0; i < OriginalArray.Length; i++)
            {
                if (i == PositionOfLargestElement)
                {
                    i++;
                    i--;
                }
                else if (OriginalArray[i] > SecondLargestElement)
                {
                    SecondLargestElement=OriginalArray[i];
                }
            }
            Console.WriteLine("Second largest element is " + SecondLargestElement);

            Console.ReadLine();
        }
    }
}
