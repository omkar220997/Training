using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void addition(int a, int b);
    public delegate void substarction(int a, int b);
    public class Operatrion
    {
        

        public void sum(int a, int b)
        {
            Console.WriteLine("Addition of a and b is " + (a + b));
        }
        public void sub(int a,int b)
        {
            Console.WriteLine("Substraction a nd b is " +(a-b));
        }

    }
    public class Program
    {
        
        static void Main(string[] args)
        {
            Operatrion operatrion = new Operatrion();

            addition del_operation1 = new addition(operatrion.sum);
            substarction del_operation2 = new substarction(operatrion.sub);

            del_operation1(100, 40);
            del_operation2(100, 40);
            Console.ReadLine();
        }
    }
}
