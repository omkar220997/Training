using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultSheetApplication
{
    public class Grade
    {
        
        public List<Student> Students= new List<Student>();

        public void AddStudent()
        {
            Grade grade = new Grade();
            Console.WriteLine("Name of the student is: ");
            var nameOfStudent=Console.ReadLine();
            Console.WriteLine("Exam number of student is: ");
            var examNumber = Console.ReadLine();
            
            Console.WriteLine("Marks of student is: ");
            
            var markScored=Console.ReadLine();
            Console.WriteLine("Grade of student is: ");
            var gradeScored=Console.ReadLine();
            Console.WriteLine("Result of student is: ");
            var result=Console.ReadLine();
            AddStudent( nameOfStudent,examNumber,markScored, gradeScored, result);

        }

        public void AddStudent( string nameOfStudent, string examNumber, string markScored, string gradeScored, string result)
        {
            var student = new Student();
            student.NameOfStudent= nameOfStudent;
            student.ExamNumber=examNumber;
            student.MarkScored= markScored;
            student.GradeScored= gradeScored;
            student.Result= result;
            Students.Add(student);
            Console.WriteLine("Result of " + student.NameOfStudent + " is added");

        }
        public void DisplayResult()
        {
            Console.WriteLine("Results of Students are: ");
            foreach(var student in Students)
            {
                student.DisplayStudent();
            }
        }
    }
}
