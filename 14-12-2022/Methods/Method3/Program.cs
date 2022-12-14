using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    public class Program
    {
        public int square()
        {
            int side = 20;
            int area = side * side;
            return area;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Area of square is :");
            Program p =new Program();
            Console.WriteLine(p.square());
            Console.ReadLine(); 
        }
    }
}
