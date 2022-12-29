using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultSheetApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //Console.WriteLine("What is the Name of student?");
            //student.NameOfStudent=Console.ReadLine();

            //Console.WriteLine("What is the Exam number of student?");
            //string ExamNumberstring = Console.ReadLine();
            //student.ExamNumber = Convert.ToInt32(ExamNumberstring);

            Console.WriteLine("Type 'Add' to add student info and result");
            Console.WriteLine("Type 'Display' to display student's result");
            Console.WriteLine("Type 'Quit' to Quit from apllication");

            var score=true;
            Grade grade = new Grade();
            while (score)
            {
                Console.WriteLine("Add ,Display or Quit");
                var Action=Console.ReadLine();

                if (Action == "Add")
                {
                    grade.AddStudent();  
                }
                else if (Action.StartsWith("Add"))
                {
                    var argument=Action.Split(' ');
                    if (argument.Length == 6)
                    {
                        grade.AddStudent(argument[1], argument[2], argument[3], argument[4], argument[5]);
                    }
                    else
                    {
                        grade.AddStudent();
                    }
                }
                else if(Action == "Display")
                {
                    grade.DisplayResult();

                }
                else if(Action == "Quit")
                {
                    score = false;
                }
                else
                {
                    Console.WriteLine(Action + " is not a valid command");
                }
            }

        }
    }
}
