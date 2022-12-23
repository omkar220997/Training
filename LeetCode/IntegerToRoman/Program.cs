using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToRoman
{
    internal class Program
    {
        public string IntToRoman(int Number)
        {
            string RomanNumber=string.Empty;
            while(Number >= 1000)
            {
                RomanNumber += "M";
                Number= Number - 1000;
               
            }
            while(Number<1000 && Number >= 900)
            {
                RomanNumber += "CM";
                Number= Number - 900;
               
            }
            while(Number<900 && Number >= 500)
            {
                RomanNumber += "D";
                Number= Number - 500;
               
            }
            while(Number<500 && Number >= 400)
            {
                RomanNumber += "CD";
                Number= Number - 400;
             
            }
            while(Number<400 && Number >= 100)
            {
                RomanNumber += "C";
                Number= Number - 100;
             
            }
            while(Number<100 && Number >= 90)
            {
                RomanNumber += "XC";
                Number= Number - 90;
                
            }
            while(Number<90 && Number >= 50)
            {
                RomanNumber += "L";
                Number= Number - 50;
                
            }
            while(Number<50 && Number >= 40)
            {
                RomanNumber += "XL";
                Number= Number - 40;
               
            }
            while(Number<40 && Number >= 10)
            {
                RomanNumber += "X";
                Number= Number - 10;
               
            }
            while(Number<10 && Number >= 9)
            {
                RomanNumber += "IX";
                Number= Number - 9;
               
            } 
            while(Number<9 && Number >= 5)
            {
                RomanNumber += "V";
                Number= Number - 5;
               
            }
            while(Number<5 && Number >= 4)
            {
                RomanNumber += "IV";
                Number= Number - 4;
               
            }
            while(Number<5 && Number >= 1)
            {
                RomanNumber += "I";
                Number= Number - 1;
               
            }
            return RomanNumber;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter a Number here");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.IntToRoman(Number));
            Console.ReadLine();
        }
    }
}
