using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class ListCollection
    {
        List<int> Marks=new List<int>();
        List<string> Names = new List<string>();
        
        internal void AddStudentInfo()
        {
            Console.WriteLine("Enter Name of student1 ");
            Names.Add(Console.ReadLine());
            Console.WriteLine("Enter marks of student1 ");
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Name of student2 ");
            Names.Add(Console.ReadLine());
            Console.WriteLine("Enter marks of student2 ");
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Name of student3 ");
            Names.Add(Console.ReadLine());
            Console.WriteLine("Enter marks of student3 ");
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Name of student4 ");
            Names.Add(Console.ReadLine());
            Console.WriteLine("Enter marks of student4 ");
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Name of student5 ");
            Names.Add(Console.ReadLine());
            Console.WriteLine("Enter marks of student5 ");
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
        }
        internal void DisplyStudentInfo()
        {

            for(int i = 0; i < Marks.Count; i++)
            {
                Console.WriteLine($"Marks for {Names[i]} is {Marks[i]}");
            }
        }


    }
}
