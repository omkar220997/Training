using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLinesInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int start = 0;
            string InputString = "Hello \n Omkar kadam \n Good Morning.";
            while((start=InputString.IndexOf('\n', start)) != -1)
            {
                count++;
                start++;
            }
            Console.WriteLine("Numbers of line is " +count);
            Console.ReadLine();
        }
    }
}
