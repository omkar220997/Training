using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentInfo studentInfo = new StudentInfo();
            studentInfo.DisplayStudent();
            studentInfo.StudentMobileNumber();
            Console.ReadLine();

        }
    }
}
