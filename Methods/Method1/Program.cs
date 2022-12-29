using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    public  class Program
    {
        public int sum (int x,int y)
        {
            Console.Write("Sum of x and y is : " );
            return (x + y);
        } 
        public int sub(int x,int y)
        {
            Console.Write("Sub of x and y is : " );

            return (x - y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value of x:");
            string xstr=Console.ReadLine();
            int x=int.Parse(xstr);
            Console.WriteLine("Enter a value of y:");
            string ystr=Console.ReadLine();
            int y =int.Parse(ystr);
            Program p = new Program();
            Console.WriteLine(p.sum(x,y));
            Console.WriteLine(p.sub(x,y));
            Console.WriteLine("Addition and Substraction");
            Console.ReadLine();

        }
    }
}
