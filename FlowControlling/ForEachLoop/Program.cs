using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    public class Marks
    {
        public static int maximum(int[] marks)
        {
            int maxx = marks[0];
            foreach(int num in marks)
            {
                if(num > maxx)
                {
                    maxx = num;
                }
            }
            return maxx;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 20, 22, 25, 24, 27, 23 };
            int maxmum= Marks.maximum(marks);
            Console.WriteLine($"Highest marks is {maxmum}");
            Console.ReadLine();
            

        }
    }
}
