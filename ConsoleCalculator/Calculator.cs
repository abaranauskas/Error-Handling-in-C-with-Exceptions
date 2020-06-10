using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            //C#7 or above
            string nonNullOperation = operation ??
                                      throw new ArgumentNullException(nameof(operation));

            //below C#7
            //if (operation is null) throw new ArgumentNullException(nameof(operation));

            if (operation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                //catch (DivideByZeroException e)
                catch (ArithmeticException e)
                {
                    throw new CalculationException("An error occured during calculation", e);


                    //Console.WriteLine(e);
                    //throw;

                    //throw new ArithmeticException("An error occur during calculation", e);
                }
            }
            else
            {
                throw new CalculationOperationNotSupportedException(operation);
                //throw new CalculationOperationNotSupportedException();
               
                //throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported.");

                //Console.WriteLine("Unknown operation.");
                //return 0;
            }
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}

