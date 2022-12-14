using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructors
{
    public class Shape
    {
        double lenght;
        double widht;
       

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

    public class Cuboid : Shape
    {
        double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Cuboid(double l , double b , double h)
        {
            Lenght = l;
            Widht = b;
            Height = h;
        }

        public double Volume()
        {
            return Lenght*Widht*height;
        }


    }

    public class Program
    {
        static void Main(string[] args)
        {
            Cuboid cube = new Cuboid(10,8,5);
            cube.Volume();
            Console.WriteLine("Lenght of cuboid is " + cube.Lenght);
            Console.WriteLine("Width of cuboid is " + cube.Widht);
            Console.WriteLine("Height of cuboid is " + cube.Height);
            Console.WriteLine("Volume of cuboid is " + cube.Volume());
            Console.ReadLine();
        }
    }
}
