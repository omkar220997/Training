using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    public class Greeting
    {
        private int time;

        public Greeting(int time)
        {
            this.time = time;
        }

        public void GetTime()
        {
            for(int i = 0; i < time; i++)
            {
                if (i < 12)
                {
                    Console.WriteLine($"Good Morning at {i}");
                }
                else if (i>=12 && i<16)
                {
                    Console.WriteLine($"Good afternoon at {i}");
                }
                else if (i>=16 && i<21)
                {
                    Console.WriteLine($"Good Evening at {i}");
                }
                else if (i>=21 && i<24)
                {
                    Console.WriteLine($"Good night at {i}");
                }
            }
            
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            
            Greeting greet4 = new Greeting(24);

          
            greet4.GetTime();
            Console.ReadLine();
        }
    }
}
