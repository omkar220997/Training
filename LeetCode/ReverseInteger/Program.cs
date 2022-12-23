using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    internal class Program
    {
        public int ReverseIntegerNumber(int Number)
        {
            string Numberstr=Convert.ToString(Number);
            string ReverseNumberstr = string.Empty;
            string Sign="";
            if (Numberstr.Contains("-"))
            {
                 Sign = "-";
                for (int i = Numberstr.Length - 1; i > 0; i--)
                {

                    ReverseNumberstr += Numberstr[i];
                }

            }
            else
            {
                for (int i = Numberstr.Length - 1; i >= 0; i--)
                {

                    ReverseNumberstr += Numberstr[i];
                }
            }
            
            int ReverseNumber=Convert.ToInt32(ReverseNumberstr);
            Console.WriteLine(Sign+""+ReverseNumber);
            return ReverseNumber;
        }
        static void Main(string[] args)
        {
            Program p =new Program();
            Console.WriteLine("Enter a Number:");
            int Number=Convert.ToInt32(Console.ReadLine());
            p.ReverseIntegerNumber(Number);
            Console.ReadLine();
        }
    }
}
