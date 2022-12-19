using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Students = new ArrayList();
            Students.Add("Omkar Kadam");
            Students.Add("Akash Gawade");
            Students.Add("Shubham Khaire");
            Students.Add("Sahil Shaikh");
            Students.Sort();
            var check = Students.Contains("Omkar Kadam");
            Console.WriteLine(check);
            foreach (Object names in Students)
            {
                
                Console.WriteLine(names);

            }
            Console.ReadLine();

        }
    }
}
