using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    
    public abstract class Shape
    {
        public abstract void Area();
    }
    
    public class Circle : Shape
    {
        public override void Area()
        {
            double a = 3.14 * rad * rad;
            Console.WriteLine("Area of circle is " +a);
            
        }

        public int rad;
      
         public int Rad { get; set; }
        

        public Circle( int rad)
        {
            this.rad = rad;
            
            Console.WriteLine("Radius of circle is " + rad);
            
            
            
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            c.Area();
            Console.ReadLine();

        }
    }
}
