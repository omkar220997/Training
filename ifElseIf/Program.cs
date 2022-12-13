using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseIf
{
    public class Greter
    {
        private int x;
        private int y;

        public Greter(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void numbers()
        {
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Enter a Values greater than 0");
            }
            else if (x > y)
            {
                Console.WriteLine($"{x} is greater than {y}");

            }
            else if (y > x)
            {
                Console.WriteLine($"{y} is greater than {x}");

            }
            else
            {
                Console.WriteLine("Both values are equal");
            }
        }


        public class Program
        {
            static void Main(string[] args)
            {

                Greter val1 = new Greter(0, 0);
                Greter val2 = new Greter(10, 20);
                Greter val3 = new Greter(20, 10);
                Greter val4 = new Greter(10, 10);

                val1.numbers();
                val2.numbers();
                val3.numbers();
                val4.numbers();
                Console.ReadLine();
            }
        }
    }
}
