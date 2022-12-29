using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class CalculationOperationNotSupportedExceptionp:CalculationException
    {
        private const string DefaultMessage = "Specified operation was out of the range of valid values";

        public string Operation { get; }

        public CalculationOperationNotSupportedExceptionp(): base(DefaultMessage)
        {
        }
        public CalculationOperationNotSupportedExceptionp(string operation): base(DefaultMessage)
        {
            Operation = operation;

        }
        public CalculationOperationNotSupportedExceptionp(string message , Exception innerException) : base(DefaultMessage, innerException)
        {

        }
        public override string ToString()
        {
            if(Operation == null)
            {
                return base.ToString();

            }
            return base.ToString() + Environment.NewLine+ $"Unsupported operation {Operation}";
        }
        
    }
}
