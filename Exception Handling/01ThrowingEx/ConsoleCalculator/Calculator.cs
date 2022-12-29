using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            throw new ArgumentNullException(paramName: nameof(number1));
            string nonNullOperation =
                operation ?? throw new ArgumentNullException(nameof(operation));

            //if(operation is null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("...logging...");
                    //throw;
                    throw new ArithmeticException("An error occured during calculation.", ex);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "This Mathematical operator is not supported");
                //Console.WriteLine("Unknown operation.");
                // 0;
            }
        }

        private int Divide(int number, int divisor) => number / divisor;
    }
}