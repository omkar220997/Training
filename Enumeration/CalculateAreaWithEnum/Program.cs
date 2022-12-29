using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaWithEnum
{
    internal class Program
    {
        private enum Shapes
        {
            Circle,
            square
        }
        private void Area(int val, Shapes s)
        {
            if (s == 0)
            {
                Console.WriteLine("Area of Circle is " +3.14*val*val);
            }
            else
            {
                Console.WriteLine("Area of Square is " + 4 * val);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Area(10, Shapes.Circle);
            p.Area(5, Shapes.square);
            Console.ReadLine();
        }
    }
}
