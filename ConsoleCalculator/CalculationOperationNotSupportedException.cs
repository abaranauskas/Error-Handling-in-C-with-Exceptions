using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        public CalculationOperationNotSupportedException()
            : base("Specified operation was out of the range of valid values.")
        {
        }

        public CalculationOperationNotSupportedException(string operation)
            : this()
        {
            Operation = operation;
        }

        public CalculationOperationNotSupportedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public CalculationOperationNotSupportedException(string message, string operation)
            : base(message)
        {
            Operation = operation;
        }

        public string Operation { get; }

        public override string Message => Operation is null ? base.Message : $"{base.Message}{Environment.NewLine} Unsupportrd operation:{Operation}";
    }
}
