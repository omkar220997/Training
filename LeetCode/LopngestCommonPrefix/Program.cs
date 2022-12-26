using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    internal class Program
    {
        public string LongestCommonPrefixAtStrings(string[] InputArray)
        {
            if (InputArray.Length == 0)
            {
                return "";
            }
            string OutputString = InputArray[0];
            for(int i = 0; i < InputArray.Length; i++)
            {
                while (InputArray[i].IndexOf(OutputString) != 0)
                {
                    OutputString=OutputString.Substring(0,OutputString.Length-1);
                    if(OutputString.Length == 0)
                    {
                        return "";
                    }
                }
            }
            return OutputString;
        }
        static void Main(string[] args)
        {
            string[] InputArray = { "flower", "flow", "flight" };
            Program program = new Program();
            program.LongestCommonPrefixAtStrings(InputArray);
            Console.ReadLine(); 
        }
    }
}
