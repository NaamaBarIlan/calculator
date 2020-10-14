using System;

namespace cal_test
{
    class Program
    {
        /// <summary>
        /// Requests the user for input
        /// passes that input into the calculation method
        /// and outputs the result of the calculation to the console. 
        /// </summary>
        /// <param name="args">Default Main method</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the coolest Calculator. Please enter your first number: ");

            //TODO - add data validation

            //Convert input from string to int and store in a variable:
            double firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            Console.WriteLine("Please enter a math operator ( +, -, *, /, % ): ");

            // Store math operator as a string
            string mathOperator = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please enter your second number: ");

            //Convert input from string to int and store in a variable:
            double secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"You entered {firstNumber} {mathOperator} {secondNumber}");

            Console.Write("Your result is: ");
            Calculation(mathOperator, firstNumber, secondNumber);

            //TODO - add the option of calculating more numbers
            //TODO - add more math operators 
        }

       
        /// <summary>
        /// Performs a math calculation based on the two double numbers and math operator passed as parameters.
        /// </summary>
        /// <param name="mathOperator">The math operator to be executed in the calculation</param>
        /// <param name="firstNumber">The first double number to be used in the calculation</param>
        /// <param name="secondNumber">The second double number to be used in the calculation</param>
        static void Calculation(string mathOperator, double firstNumber, double secondNumber)
        {
            if (mathOperator == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);
            } 
            else if (mathOperator == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            else if (mathOperator == "*")
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
            else if (mathOperator == "/")
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            else if(mathOperator == "%")
            {
                Console.WriteLine(firstNumber % secondNumber);
            }
            else
            {
                Console.WriteLine($"{mathOperator} is not a valid math operator. Please try again.");
            }
        }
        
    }
}
