using System;

namespace CalculatorProgram
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------");
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("----------");

            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;
                string calcOperator = "";

                Console.WriteLine("\n\nEnter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Operator: ");
                calcOperator = Console.ReadLine();

                switch (calcOperator)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {result}");
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {result}");
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {result}");
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                        break;

                    default:
                        Console.WriteLine("Please enter a valid operator");
                        break;
                }
                Console.Write("Do you want to use CALCULATOR again? (Y/N) ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thank you for using Calculator");


            Console.ReadKey();  
        }
    }
}