﻿using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            string nonNullOperation=
                operation ?? throw new ArgumentNullException(nameof(operation));

            //if(operation is null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}

            if (nonNullOperation == "/")
            {
                return Divide(number1, number2);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation),"This Mathematical operator is not supported");
                //Console.WriteLine("Unknown operation.");
                // 0;
            }
        }

        private int Divide(int number, int divisor) => number / divisor;
    }
}

