using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementFromPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sixe of array");
            int SizeOfArray=Convert.ToInt32(Console.ReadLine());
            int[] OriginalArray=new int[SizeOfArray];
            Console.WriteLine("Enter the elements of array");
            for(int i=0; i<SizeOfArray; i++)
            {
                OriginalArray[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the position of element desire to be deletes");
            int PositionOfElement=Convert.ToInt32(Console.ReadLine());
            int[] ArrayAfterElementDelete=new int[SizeOfArray-1];
            int j = 0;
            for(int i=0; i<SizeOfArray; i++)
            {
                if(i== PositionOfElement)
                {
                    ArrayAfterElementDelete[j] = 0;
                    j--;
                }
                else if (i != PositionOfElement)
                {
                    ArrayAfterElementDelete[j]+=OriginalArray[i];
                }
                j++;

            }
            for (int i=0; i<SizeOfArray-1; i++)
            {
                Console.WriteLine(ArrayAfterElementDelete[i]);

            }
            Console.ReadLine();
        }
    }
}
