using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithNoReturn
{
    
    public class Program
    {
        public void Area(int l, int b)
        {
            {
                int a = l * b;
                Console.WriteLine("Area of rectangle is " + a);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght of rectangle");
            string lstr=Console.ReadLine();
            int l=Convert.ToInt32(lstr);
            Console.WriteLine("Enter width of rectangle");
            string bstr=Console.ReadLine();
            int b=Convert.ToInt32(bstr);

            Program p=new Program();
            p.Area(l, b);
            Console.ReadLine();
        }
    }
}
