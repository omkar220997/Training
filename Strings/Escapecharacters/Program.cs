using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escapecharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Omkar";
            string lastName = "Kadam";
            // showing file path
            string FilePath = "C:\\desktop\\Training\\String.sln";
            Console.WriteLine("first name is " +firstName);
            Console.WriteLine("last name is " +lastName);
            Console.WriteLine($"{firstName} {lastName}");
            Console.WriteLine($"Welcom\n{firstName} \t{lastName}\nGood Morning");
            Console.WriteLine("Path of the file is " +FilePath);
           
            Console.ReadLine();
        }
    }
}
