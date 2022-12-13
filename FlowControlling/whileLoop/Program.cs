using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    public class Authority
    {
        private int x;

        public Authority(int x)
        {
            this.x = x;
        } 

        public void Value()
        {
            while (x < 18)
            {
                Console.WriteLine($"Not an adult at {x} age");
                x++;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Authority age = new Authority(10);
            age.Value();
            Console.ReadLine();
        }
    }
}
