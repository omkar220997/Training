using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable Students=new Hashtable();
            Students.Add("Name1", "Omkar Kadam");
            Students.Add("Name2", "Pankaj Mahale");
            Students.Add("Name3", "Suraj Saste");
            Students.Add("Name4", "Shubham Jadhav");
            Students.Add("Name5", "Akshay Shinde");
            Students.Add("Student Id1", 1);
            Students.Add("Student Id2",2);
            Students.Add("Student Id3",3);
            Students.Add("Student Id4",4);
            Students.Add("Student Id5",5);
            Console.WriteLine(Students["Name1"]);
            foreach(Object obj in Students.Keys)
            {
                Console.WriteLine(obj+" " + Students[obj]);
                //Console.WriteLine(obj.GetHashCode());
            }
            Console.ReadLine();
        }
    }
}
