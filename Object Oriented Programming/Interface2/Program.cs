using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    interface Grade
    {
        void Grades(string a);
        void Marks(int a);
        void Result(string a);
    }
    interface Student
    {
        void Name(string a);
        void Std(string a);
    }

    public class Student1 : Student,Grade
        
    {
        string name;
        string std;
        string grade;
        int marks;
        string result;

        public void Name(string newName)
        {
            name = newName;
        }
        public void Std(string newStd)
        {
            std= newStd;
        }
        public void Grades(string newGrade)
        {
            grade = newGrade;
        }
        public void Marks(int newMark)
        {
            marks = newMark;
        }
        public void Result(string newResult)
        {
            result = newResult;
        }
        public void Display()
        {
            Console.WriteLine($"{name} is in the {std} standard");
            Console.WriteLine($"{name} scored the {marks}% and get {grade} so the result is {result}");
        }
    }
    
    public  class Program
    {
        static void Main(string[] args)
        {
            Student1 s1 = new Student1();
            Console.WriteLine("data of student 1: ");
            s1.Name("Omkar Kadam");
            s1.Std("12th");
            s1.Marks(80);
            s1.Grades("A");
            s1.Result("pass");
            s1.Display();

            Student1 s2 = new Student1();
            Console.WriteLine("data of student 2: ");
            s2.Name("Suraj Saste");
            s2.Std("12th");
            s2.Marks(34);
            s2.Grades("F");
            s2.Result("fail");
            s2.Display();

            Console.ReadLine();
        }
    }
    
}
