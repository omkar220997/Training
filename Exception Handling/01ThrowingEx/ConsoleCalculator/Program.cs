﻿using System;
using static System.Console;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter first number");
            int number1 = int.Parse(ReadLine());

            WriteLine("Enter second number");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter operation");
            string operation = ReadLine().ToUpperInvariant();


            var calculator = new Calculator();
            int result = calculator.Calculate(number1, number2, operation);
            DisplayResult(result);


            WriteLine("\nPress enter to exit.");
            ReadLine();
        }

        private static void DisplayResult(int result) => WriteLine($"Result is: {result}");
    }
}


// FROM C# 9 "Top-level statements":

//using ConsoleCalculator;
//using static System.Console;


//WriteLine("Enter first number");
//int number1 = int.Parse(ReadLine());

//WriteLine("Enter second number");
//int number2 = int.Parse(ReadLine());

//WriteLine("Enter operation");
//string operation = ReadLine().ToUpperInvariant();


//var calculator = new Calculator();
//int result = calculator.Calculate(number1, number2, operation);
//DisplayResult(result);


//WriteLine("\nPress enter to exit.");
//ReadLine();


//void DisplayResult(int result)
//{
//    WriteLine($"Result is: {result}");
//}


