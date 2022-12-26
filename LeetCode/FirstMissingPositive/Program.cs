using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMissingPositive
{
    internal class Program
    {
        public int FirstMissingPositivenumber(int[] InputArray)
        {
            int length=InputArray.Length;
             Array.Sort(InputArray);
            int[] OutputArray=new int[length];
                       
            for (int i=0; i<length-1; i++)
            {
                if (InputArray[i] == 0)
                {
                    OutputArray[i]=InputArray[i+1];
                     if (InputArray[i] > 0)
                     {
                        if (InputArray[i] < 0 && InputArray[i + 1] == InputArray[i] + 1)
                        {
                            OutputArray[i] += InputArray[i+1];
                        }
                        else if (InputArray[i] > 0 && InputArray[i + 1] == InputArray[i] + 1)
                        {
                            OutputArray[i] += InputArray[i+1];
                        }
                        else
                        {
                            Console.WriteLine(InputArray[i] + 1);
                        }

                    }
                }
                else 
                {
                    if (InputArray[i] > 0)
                    {
                        if (InputArray[i] < 0 && InputArray[i + 1] == InputArray[i] + 1)
                        {
                            OutputArray[i] += InputArray[i];
                        }
                        else if (InputArray[i] > 0 && InputArray[i + 1] == InputArray[i] + 1)
                        {
                            OutputArray[i] += InputArray[i];
                        }
                        else
                        {
                            Console.WriteLine(InputArray[i] + 1);
                        }
                    }
                }
              
            }
            return OutputArray.Length;
        }
        static void Main(string[] args)
        {
            int[] InputArray = { 2,1,0 };
            Program p =new Program();
            p.FirstMissingPositivenumber(InputArray);
            Console.ReadLine();

        }
    }
}
