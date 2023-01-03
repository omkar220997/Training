using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        Student student = new Student();

        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Name = name;
            IsWeighted = isWeighted;
        }
        public RankedGradeBook()
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (student.Grades.Count < 5)
            {
                throw new InvalidOperationException("Student count is less than 5");
            }
            else if(averageGrade >= 80)
            {
                return 'A';
            }
            else if (averageGrade >= 60 && averageGrade < 80)
            {
                return 'B';
            }
            else if (averageGrade >= 40 && averageGrade < 60)
            {
                return 'C';
            }
            else if (averageGrade >= 20 && averageGrade < 40)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
        public override void CalculateStatistics()
        {
            if (student.Grades.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");

            }
            else
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (student.Grades.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");

            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}