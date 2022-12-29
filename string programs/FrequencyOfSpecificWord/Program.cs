using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyOfSpecificWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your String Here");
            string InputString = Console.ReadLine();
            Console.WriteLine("Enter a word to find Frequency");
            string InputCharacter = Console.ReadLine();
            string OutputString = string.Empty;
            for (int i = 0; i < InputString.Length; i++)
            {
                if (InputString.Contains(InputCharacter))
                {
                    OutputString+=InputString[i];
                }
            }
            Console.WriteLine(OutputString);
            int FrequencyCount = OutputString.Length;
            
            Console.WriteLine($"Frquency of {InputCharacter} is {FrequencyCount}");
            Console.ReadLine();
        }
    }
}
