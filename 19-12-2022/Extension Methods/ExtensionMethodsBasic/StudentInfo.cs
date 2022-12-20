using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsBasic
{
    internal class StudentInfo
    {
        string StudentName;
        string StudentCity;
        int StudentID;

        public StudentInfo()
        {
            Console.WriteLine("Enter the name of Student");
            StudentName=Console.ReadLine();
            Console.WriteLine("Enter the City of Student");
            StudentCity=Console.ReadLine();
            Console.WriteLine("Enter the ID of Student");
            StudentID=Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayStudent()
        {
            Console.WriteLine("Name of Student is " +StudentName);
            Console.WriteLine("City of Student is " +StudentCity);
            Console.WriteLine("ID of Student is " +StudentID);
        }
    }
}
