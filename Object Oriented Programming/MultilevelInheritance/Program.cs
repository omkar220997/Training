using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class College
    {
        public string clgName;
        public string clgAddress;

        public void ClgDetails(string clgName, string clgAddress)
        {
            this.clgName = clgName;
            this.clgAddress = clgAddress;
            Console.WriteLine("Name of college is " + clgName);
            Console.WriteLine("Address of college is " + clgAddress);
        }
    }

    public class Streams : College
    {
        public string strmName;
        public int strmTime;

        public void StrmDetails(string strmName, int strmTime)
        {
            this.strmName = strmName;
            this.strmTime = strmTime;   
            Console.WriteLine("Name of the Stream is " +strmName);
            Console.WriteLine("Required time of the Stream is " +strmTime);
        }
    }

    public class Teacher : Streams
    {
        public string teacherName;
        public string teacherSubject;

        public void TeacherDetails(string teacherName, string teacherSubject)
        {
            this.teacherName = teacherName;
            this.teacherSubject = teacherSubject;    
            Console.WriteLine("Name of teacher is " +teacherName);
            Console.WriteLine("Subject of teacher is " +teacherSubject);
        }
    }
    public class Student : Teacher
    {
        public string studentName;
        public int studentYear;

        public void StudentDetails(string studentName, int studentYear)
        {
            this.studentName = studentName; 
            this.studentYear = studentYear;
            Console.WriteLine("Name of Student is " +studentName);
            Console.WriteLine("Year of Student is " +studentYear);
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            //College clg = new College();
            //clg.ClgDetails("PICT", "Pimri-Chinchwad Pune");
            Student s = new Student();
            s.ClgDetails("Sinhgad Academy of Engineering" ,"Kondhwa Pune");
            s.StrmDetails("Mechanical", 4);
            s.TeacherDetails("Adhik Patil", "Mechanics");
            s.StudentDetails("Omkar Kadam", 2);
            Console.ReadLine(); 
        }
    }
}
