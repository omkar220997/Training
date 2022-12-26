using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of Array");
            int SizeOfArray=Convert.ToInt32(Console.ReadLine());
            int[] MixedArray=new int[SizeOfArray];
            int[] OddArray=new int[SizeOfArray];
            int[] EvenArray=new int[SizeOfArray];
            Console.WriteLine("Enter Elements of Array");
            for(int i=0; i<SizeOfArray; i++)
            {
                MixedArray[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<SizeOfArray; i++)
            {

                
                    if (MixedArray[i] % 2 == 0)
                    {
                        EvenArray[i] += MixedArray[i];
                    }
                    else
                    {
                        OddArray[i] = MixedArray[i];
                    }
            }
            Array.Sort(OddArray);
            Array.Sort(EvenArray);
            Console.WriteLine("Array Elements Are...");
            for(int i =0; i<SizeOfArray; i++)
            {
                Console.WriteLine(MixedArray[i]);
                
            }
            Console.WriteLine("Even Array Elements Are...");
            for (int i =0; i<SizeOfArray; i++)
            {
                if(EvenArray[i] != 0)
                {
                    Console.WriteLine(EvenArray[i]);

                }

            }
            Console.WriteLine("Odd Array Elements Are...");
            for (int i =0; i<SizeOfArray; i++)
            {
                if(OddArray[i] != 0)
                {
                    Console.WriteLine(OddArray[i]);

                }
            }
            Console.ReadLine();

        }
    }
}
