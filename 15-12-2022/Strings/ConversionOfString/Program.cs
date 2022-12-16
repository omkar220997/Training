using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversion of string value to boolean value
            string BoolString = "true";
            bool BoolValue=Convert.ToBoolean(BoolString);
            Console.WriteLine(BoolValue);

            // Conversion of string vlue to int value
            String IntString = "2209";
            int IntValue=Convert.ToInt32(IntString);
            Console.WriteLine(IntValue);

            // Conversion of string value to double value
            string DoubleString = "505.303";
            double DoubleValue=Convert.ToDouble(DoubleString);
            Console.WriteLine(DoubleValue);

            //Conversion of string value to char value
            string CharString = "H";
            char CharValue= Convert.ToChar(CharString);
            Console.WriteLine(CharValue);

            //Conversion of String value to float vlaue
            string FloatString = "22.09";
            float FloatValue=Convert.ToSingle(FloatString);
            Console.WriteLine(FloatValue);

            Console.ReadLine();

        }
    }
}
