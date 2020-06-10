using System;
using static System.Console;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //global exeption handler for Console app
            var currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException += CurrentAppDomain_UnhandledException;

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
            //catch (CalculationOperationNotSupportedException ex)
            //{
            //    WriteLine(ex);
            //}
            catch (CalculationException ex)
            {
                WriteLine(ex);
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "operation") //exception filter c#6
            {
                //Log.Error(ex);
                WriteLine($"Operation was not provided. {ex}");
            }
            catch (ArgumentNullException ex)
            {
                //Log.Error(ex);
                WriteLine($"An Argument was null. {ex}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                WriteLine($"Operation is not supported. {ex}");
            }
            catch (Exception ex)
            {
                WriteLine($"Sorry, something went wrong. {ex}");
                //throw;
            }
            finally
            {
                WriteLine(".....Finally...");
            }


            WriteLine("\nPress enter to exit.");
            ReadLine();
        }

        private static void CurrentAppDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // could be logging 
            WriteLine($"Sorry there was problem and we need to close. Details {e.ExceptionObject}");
        }

        private static void DisplayResult(int result)
        {
            WriteLine($"Result is: {result}");
        }
    }
}
