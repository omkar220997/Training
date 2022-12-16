using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubStringWithoutRepeatingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here ");
            string InputString=Console.ReadLine();
            string OutputString=string.Empty;
            int LenghtOfLongestSubstring;
            for(int i = 0; i < InputString.Length; i++)
            {
                if (!OutputString.Contains(InputString[i]))
                {
                    OutputString += InputString[i];
                }

            }

            OutputString = OutputString.Replace(" ", "");
            Console.WriteLine(OutputString);
            LenghtOfLongestSubstring=OutputString.Length;
            Console.WriteLine(LenghtOfLongestSubstring);
            Console.ReadLine();
        }
    }
}
