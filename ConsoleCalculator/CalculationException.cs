using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class CalculationException : Exception
    {
        private static readonly string DefaultMessage = "An error occured during calculation. Ensure that the operator is supported and that values are within the valid ranges for the requested operation.";

        public CalculationException()
            : base(DefaultMessage)
        {
        }

        public CalculationException(string message)
            : base(message)
        {
        }

        public CalculationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public CalculationException(Exception innerException)
            : base(DefaultMessage, innerException)
        {
        }
    }
}
