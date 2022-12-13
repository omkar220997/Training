using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public class Operation
    {
        public void Addition(int x,int y)
        {
            int sum = x + y;
            Console.WriteLine("Addition of x and y is " +sum);
        }
        public void Addition(int x,int y,int z)
        {
            int sum = x + y+z;
            Console.WriteLine("Addition of x, y and z is " +sum);
        }
        public void Addition(float x,float y,float z)
        {
            float sum = x + y+z;
            Console.WriteLine("Addition of floating number x, y and z is " +sum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.Addition(10, 20);
            operation.Addition(20, 30,40);
            operation.Addition(25.5F, 24.5F, 50.0F);
            Console.ReadLine();
        }
    }
}
