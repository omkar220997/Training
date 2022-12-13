using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace referenceType
{
    public class GradeBook
    {
        public GradeBook(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public void GetStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var numbers in grades)
            {
                highGrade = Math.Max(numbers, highGrade);
                lowGrade = Math.Min(numbers, lowGrade);
                result += numbers;
            }
            result /= grades.Count;
            Console.WriteLine("The average grade is " + result);
            Console.WriteLine("The highest grade is " + highGrade);
            Console.WriteLine("The lowest grade is " + lowGrade);

        }
        private List<double> grades;
        public string Name;



    }
}
