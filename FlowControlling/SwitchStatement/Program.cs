using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    public class Work
    {
        double year = 0;
       public double Basic()
        {
            Console.WriteLine("you haven't completed your training period");
            return year;
        }
        public double Moderate()
        {
            Console.WriteLine("Congratulations you successfully completed you training");
            return year;
        }
        public double Advance()
        {
            Console.WriteLine("You have completed 3+ years in company");
            return year;
        }
        public double Exellent()
        {
            Console.WriteLine("You have completted 5+ years in comapny");
            return year;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you time of working in company in years");

            string yearstr=Console.ReadLine();
            double year= Convert.ToDouble(yearstr);

            Work time=new Work();
            Console.WriteLine("Enter basic if yor time is less than 0.5 years");
            Console.WriteLine("Enter moderate if yor time is more than 0.5 years but less than 3 year");
            Console.WriteLine("Enter advance if yor time is more than 3 years but less than 5 years");
            Console.WriteLine("Enter exellent if yor time is more than 5 years");
            string timestr=Console.ReadLine();
            switch (timestr)
            {
                case "basic":
                    Console.WriteLine(time.Basic());
                    break;
                case "moderate":
                    Console.WriteLine(time.Moderate());
                    break;
                case "advance":
                    Console.WriteLine(time.Advance());
                    break;
                case "exellent":
                    Console.WriteLine(time.Exellent());
                    break;
            }
            Console.ReadLine();
        }
    }
}
