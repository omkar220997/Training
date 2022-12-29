using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class CalculationException : Exception
    {
        private const string DefaultMessage = " An error occured during calculation. Ensure that the operator is supported and values are correct";

        public CalculationException() : base(DefaultMessage)
        {

        }
        public CalculationException(string message): base(message)
        {

        }
        public CalculationException(string message, Exception innerException): base(DefaultMessage, innerException)
        {
        
        }
    }
}
