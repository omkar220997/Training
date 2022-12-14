using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class Student
    {
        public string stdName;
        public int strYear;

        public void StdDetails(string stdName,int stdYear)
        {
            this.stdName = stdName;
            
            this.strYear = stdYear;
            Console.WriteLine("NAme of the student is " + stdName);
            Console.WriteLine("Year of student in college is " + stdYear);
        }
    }
    
    public class Hobby : Student
    {
        public string hobbyName;
         public void HobbyDetails(string hobbyName)
        {
            this.hobbyName = hobbyName;
            Console.WriteLine("Hobby of student is " +hobbyName);
        }
    }

    public class Education : Student
    {
        public string branchName;
        public int percentage;

        public void eduDetails(string branchName, int percentage)
        {
            this.branchName = branchName;
            this.percentage = percentage;
            Console.WriteLine("branch of student is " +branchName);
            Console.WriteLine("Last percentage of student is " +percentage);
        }
    }

    public class Sport : Student
    {
        public string sportName;
        public void SportDetails(string sportName)
        {
            this.sportName = sportName;
            Console.WriteLine("Name of sport is " +sportName);
        }
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            Sport sport = new Sport();
            sport.StdDetails("Omkar Kadam", 4);
            sport.SportDetails("Boxing");

            Education education = new Education();
            education.eduDetails("Mechanical", 62);

            Hobby hobby = new Hobby();
            hobby.HobbyDetails("trekking");

            Console.ReadLine(); 

        }
    }
}
