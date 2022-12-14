using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructors
{
    public class Rectangle
    {
        double lenght;
        double widht;
       
        public Rectangle ( double l , double b)
        {
            Lenght = l;
            widht = b;
        }

        public double Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }
        public double Widht
        {
            get { return widht; }
            set { widht = value; }
        }
       
    }

    public class Area : Rectangle
    {

        double area;

        public Area( double l, double b) : base(l,b)
        {
            area = l * b;  
        }

        public double Ar()
        {
            return area;
        }

        


    }

    public class Program
    {
        static void Main(string[] args)
        {
            Area a = new Area(10,8);
            a.Ar();
            Console.WriteLine("Lenght of Rectangle is " + a.Lenght);
            Console.WriteLine("Width of Rectangle is " + a.Widht);
           
            Console.WriteLine("Area of Rectangle is " + a.Ar());
            Console.ReadLine();
        }
    }
}
