using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Program
    {
        public int Addition(int x, int y)
        {
            Console.WriteLine("Addition of x and y is ");
            return x + y;
        }
        public int Addition(int x,int y,int z)
        {
            Console.WriteLine("Addition of x,y and z is ");
            return x+y+z;
        }
        public double Addition(double x1, double y1, double z1)
        {
            Console.WriteLine("addition of double x,y,and z is ");
            return x1+y1+z1;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a value of x: ");
            string xstr=Console.ReadLine();
            Console.WriteLine("Enter a value of x1: ");

            string x1str =Console.ReadLine();
            int x=int.Parse(xstr);
            double x1=double.Parse(x1str);
            Console.WriteLine("Enter a value of y: ");
            string ystr=Console.ReadLine();
            Console.WriteLine("Enter a value of y1: ");

            string y1str =Console.ReadLine();
            int y=int.Parse(ystr);
            double y1 = double.Parse(y1str);

            Console.WriteLine("Enter a value of z: ");
            string zstr=Console.ReadLine();
            Console.WriteLine("Enter a value of z1: ");

            string z1str =Console.ReadLine();
            int z=int.Parse(zstr);
            double z1 = double.Parse(z1str);


            Program p =new Program();
           Console.WriteLine(p.Addition(x,y));
           Console.WriteLine(p.Addition(x,y,z));
           Console.WriteLine(p.Addition(x1,y1,z1));
            Console.ReadLine();
        


        }
    }
}
