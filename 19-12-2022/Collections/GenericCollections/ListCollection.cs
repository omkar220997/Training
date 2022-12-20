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
        internal void AddMarks()
        {
            Console.WriteLine("Enter marks of student1 ");
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter marks of student2 ");
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter marks of student3 ");
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter marks of student4 ");
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter marks of student5 ");
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
        }
        internal void DisplyMarks()
        {
            for(int i = 0; i < Marks.Count; i++)
            {
                Console.WriteLine($"Marks for student {i+1} is {Marks[i]}");
            }
        }


    }
}
