using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArray
{
    internal class Program
    {
      
        public double FindMedianSortedArrays(int[] Array1, int[] Array2 )
        {

            double Median;
            double[] Result = new double[Array1.Length + Array2.Length];
            int IndexOfArray1 = 0;
            int IndexOfArray2 = 0;
            int IndexOfResult = 0;

            while (IndexOfArray1 < Array1.Length)
            {
                Result[IndexOfResult] =Array1[IndexOfArray1];
                IndexOfResult++;
                IndexOfArray1++;
            }
            while(IndexOfArray2 < Array2.Length)
            {
                Result[IndexOfResult] = Array2[IndexOfArray2];
                IndexOfResult++;
                IndexOfArray2++;
            }
            Array.Sort(Result);
            int length= Result.Length;
            if(length%2 == 1)
            {
                  Median = Result[Convert.ToInt32((length / 2))];
                
            }
            else
            {
                  Median = (Result[length / 2 - 1]+ Result[length / 2])/2;
                 
            }

            
            return Median;

        }




        static void Main(string[] args)
        {
            Program p =new Program();
            int[] Array1 = { 1, 3 ,5};
            
            int[] Array2 = { 2,4,6}; 
            
            Console.WriteLine("Median of Two sorted array is ");
            Console.WriteLine(p.FindMedianSortedArrays(Array1, Array2));
            Console.ReadLine();


        }
    }
}
