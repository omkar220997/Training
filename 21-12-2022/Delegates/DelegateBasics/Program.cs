using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBasics
{
    internal class Program
    {
        public delegate void AddNumbersDelegate(int x, int y);
        public delegate string NameDelegate(string namestr);
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("Addition of A nd b is " +(a+b));
        }
        public static string Name(string name)
        {
            return name;
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            AddNumbersDelegate AD= new AddNumbersDelegate(p.AddNumbers);
            AD(100, 50);
            NameDelegate ND = new NameDelegate(Name);
            string str = ND("Omkar Kadam");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
