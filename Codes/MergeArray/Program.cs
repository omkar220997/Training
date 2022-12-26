using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size Arrays...");
            int SizeOfArrays=Convert.ToInt32(Console.ReadLine());
            int[] Array1=new int[SizeOfArrays];
            int[] Array2 = new int[SizeOfArrays];
            int[] MergedArray = new int[2*SizeOfArrays];
            int SizeOfMergedArray=MergedArray.Length;
            Console.WriteLine("Enter the elements of First Array");

            for (int i=0; i<SizeOfArrays; i++)
            {
                Array1[i] = Convert.ToInt32(Console.ReadLine());
                MergedArray[i] += Array1[i];
            }
            Console.WriteLine("Enter the elements of Second Array");
            for(int j=0; j<SizeOfArrays; j++)
            {
                Array2[j]=Convert.ToInt32(Console.ReadLine());
                MergedArray[j+ SizeOfArrays] += Array2[j];

            }
            Array.Sort(MergedArray);
            Console.WriteLine("Merged and sorted array is ");
            for(int i=0; i<SizeOfMergedArray; i++)
            {
                Console.WriteLine(MergedArray[i]+" ");

            }
            Console.ReadLine();
        }
    }
}
