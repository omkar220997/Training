using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsBasic
{
    static class StudentMobile
    {
        static double _StudentMobileNumber;
       public static void StudentMobileNumber(this StudentInfo studentInfo)
        {
            Console.WriteLine("Enter the Mobile number od student");
            _StudentMobileNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("MObile Number of Student is " +_StudentMobileNumber);    
        }
    }
}
