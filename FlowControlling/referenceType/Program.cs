using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new GradeBook("Omkar's Grade book");
            book.AddGrade(89.1);
            book.AddGrade(90.9);
            book.AddGrade(77.1);
            book.GetStatistics();

            Console.ReadLine();

            

           
        }
    }
}
