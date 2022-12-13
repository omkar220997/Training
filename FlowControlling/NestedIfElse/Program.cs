using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfElse
{
    public class Smaller
    {
        private int x;
        private int y;
        private int z;

        public Smaller(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void GetValues()
        {
            if (x < y)
            {
                if (x < z)
                {
                    Console.WriteLine($"{x} is smaller than {y} and {z}");
                }
            }
            if (y < z)
            {
                if(y < x)
                {
                    Console.WriteLine($"{y} is smaller than {x} and {z}");

                }
            }
            if(z < x)
            {
                if(z < y)
                {
                    Console.WriteLine($"{z} is smaller than {x} and {y}");

                }
                
            }
            if(x==y)
            {
                if (y == z)
                {
                    Console.WriteLine("All three values are equal");

                }
            }

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Smaller number1 = new Smaller(15, 20, 25);
            Smaller number2 = new Smaller(19, 15, 25);
            Smaller number3 = new Smaller(15, 20, 2);
            Smaller number4 = new Smaller(15, 15, 15);

            number1.GetValues();
            number2.GetValues();
            number3.GetValues();
            number4.GetValues();
            Console.ReadLine(); 
        }
    }
}
