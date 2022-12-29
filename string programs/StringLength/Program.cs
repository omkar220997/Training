using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your String here");
            string InputString=Console.ReadLine();
            int LengthOfString=InputString.Length;
            Console.WriteLine("Length of string is " +LengthOfString);
            Console.ReadLine();
        }
    }
}
