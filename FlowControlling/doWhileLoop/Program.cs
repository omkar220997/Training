using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileLoop
{
    public class Age
    {
        private int x;

        public Age(int x)
        {
            this.x = x;
        }   

        public void GetAge()
        {
            do
            {
                Console.WriteLine($"you are only {x} years old After the age of 18 years you are an adult");
                x++;
            }
            while (x<18);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Age child = new Age(15);

            child.GetAge();
            Console.ReadLine();
        }
    }
}
