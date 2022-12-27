using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNewValueInSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int SizeOfArray = Convert.ToInt32(Console.ReadLine());
            int[] OriginalArray=new int[SizeOfArray];
            Console.WriteLine("Enter the elements of array");
            for(int i=0; i<SizeOfArray; i++)
            {
                OriginalArray[i]=Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(OriginalArray);
            Console.WriteLine("Enter the Number to be inserted");
            int InsertingNumber=Convert.ToInt32(Console.ReadLine());
            int[] ArrayAfterNumberInsert=new int[SizeOfArray+1];
            int j=0;
                for(int k=0; k<SizeOfArray+1; k++)
                {
                    if (InsertingNumber > OriginalArray[k])
                    {
                        ArrayAfterNumberInsert[j]+=OriginalArray[k];
                        j++;
                    }
                    else if(InsertingNumber < OriginalArray[k])
                    {
                        if (j == k)
                        {
                            ArrayAfterNumberInsert[j]+=InsertingNumber;
                            j++;
                        }
                        else
                        {
                            k--;
                            ArrayAfterNumberInsert[j-1] += OriginalArray[k];
                            k++;

                        }
                    j++;
                    }
                }

            
            for (int i=0; i<ArrayAfterNumberInsert.Length; i++)
            {
                Console.WriteLine(ArrayAfterNumberInsert[i]);
            }
            Console.ReadLine();
        }
    }
}
