using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    internal class Program
    {
        public delegate void RectDelegate(double Length, double Width);
        public void GetRectArea(double Length, double Width)
        {
            Console.WriteLine("Area of the rectangle is " + (Length * Width));
        }
        public void GetRectPerimeter(double Length, double Width)
        {
            Console.WriteLine("Perimeter of rectangle is " +(2*(Length+ Width)));
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            RectDelegate RD = p.GetRectArea;
            RD += p.GetRectPerimeter;
            RD(10, 15);
            RD(100, 150);
            Console.ReadLine();
        }
    }
}
