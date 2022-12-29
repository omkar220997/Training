using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationBasic
{
    enum Month
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        June,
        Jul,
        Aug,
        Sep,
        Oct,
        Nove,
        Dec
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value of jan in Months " + "enum is " +(int)Month.Jan);
            Console.WriteLine("The value of feb in Months " + "enum is " + (int)Month.Feb);
            Console.WriteLine("The value of mar in Months " + "enum is " + (int)Month.Mar);
            Console.WriteLine("The value of apr in Months " + "enum is " + (int)Month.Apr);
            Console.WriteLine("The value of may in Months " + "enum is " + (int)Month.May);
            Console.WriteLine("The value of jun in Months " + "enum is " + (int)Month.June);
            Console.WriteLine("The value of july in Months " + "enum is " + (int)Month.Jul);
            Console.WriteLine("The value of aug in Months " + "enum is " + (int)Month.Aug);
            Console.WriteLine("The value of sep in Months " + "enum is " + (int)Month.Sep);
            Console.WriteLine("The value of oct in Months " + "enum is " + (int)Month.Oct);
            Console.WriteLine("The value of nove in Months " + "enum is " + (int)Month.Nove);
            Console.WriteLine("The value of dec in Months " + "enum is " + (int)Month.Dec);
            Console.ReadLine();
            

        }
    }
}
