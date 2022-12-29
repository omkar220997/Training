using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    public  class Program
    {
        public void car(string name)
        {
            Console.WriteLine("Name of car is " +name);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.car("Swift");
            Console.ReadLine(); 
        }
    }
}
