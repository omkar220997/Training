using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultSheetApplication
{
    public class Student
    {
        public string NameOfStudent;
        public string ExamNumber; 
        public string MarkScored;
        public string GradeScored;
        public string Result;

        public void DisplayStudent()
        {
            Console.WriteLine(NameOfStudent+ " have exam number is  " +ExamNumber);
            Console.WriteLine("Marks of " + NameOfStudent + " is " + MarkScored); 
            Console.WriteLine("Grade of " + NameOfStudent + " is " + GradeScored); 
            Console.WriteLine("Result of " + NameOfStudent + " is " + Result); 
        }
    }
}
