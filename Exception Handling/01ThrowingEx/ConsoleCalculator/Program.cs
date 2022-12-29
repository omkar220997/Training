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

            try
            {
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                WriteLine($"Operation was not provided {ex}");
            }
            catch (ArgumentNullException ex)
            {
                WriteLine($"An argument was null {ex}");
            }
            catch (CalculationOperationNotSupportedExceptionp ex)
            {
                WriteLine($"CalculationOperationNotSupportedExceptionp caught {ex.Operation}");
                WriteLine(ex);
            }
            catch(CalculationException ex)
            {
                WriteLine($"CalculationException caught");
                WriteLine(ex);
            }
            catch (Exception ex)
            {
                WriteLine($"Sorry, something went wrong {ex}");
            }

            finally
            {
                WriteLine("...finally block executed...");
            }

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