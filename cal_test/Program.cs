using System;

namespace cal_test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a 1st number:
            Console.WriteLine("Welcome to the coolest Calculator. Please enter your first number: ");

            //TODO - add data validation to make sure we got a valid number as input? 

            //Convert input from string to int and store in a variable:
            double firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            // Ask the user to enter a math operator:
            Console.WriteLine("Please enter a math operator ( +, -, *, /, % ): ");

            // Store math operator as a string
            string mathOperator = Console.ReadLine();

            Console.Clear();

            // Ask the user to enter a second number
            Console.WriteLine("Please enter your second number: ");

            //Convert input from string to int and store in a variable:
            double secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            // Display the math expression:
            Console.WriteLine($"You entered {firstNumber} {mathOperator} {secondNumber}");

            // Perform the calculation (a method outside of Main)
            // & output the result to the user:

            Console.Write("Your result is: ");
            Calculation(mathOperator, firstNumber, secondNumber);

            //TODO - add the option of calculating more numbers
            //TODO - add more math operators 
        }

       
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
