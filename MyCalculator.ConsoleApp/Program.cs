using System;
using MyCalculator.ConsoleApp.Operations;

namespace MyCalculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            int option;

            Console.WriteLine();
            Console.WriteLine("         WELCOME TO MYCALCULATOR SYSTEM");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Follow the instructions bellow to do your calcs.");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine();
                Console.WriteLine("     1 - Addition");
                Console.WriteLine("     2 - Subtraction");
                Console.WriteLine("     3 - Multiplication");
                Console.WriteLine("     4 - Division");
                Console.WriteLine("     0 - Exit");
                option = int.Parse(Console.ReadLine());

                if (option == 0)
                {
                    Console.WriteLine("Closing the system.");
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Now insert the numbers:");

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Insert the first number:");
                    num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Insert the second number:");
                    num2 = float.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (option == 4 && num2 == 0)
                        Console.WriteLine("A number cannot be divided by zero, please start over.");

                } while (option == 4 && num2 == 0);

                if (option == 1)
                {
                    Addition operation = new Addition();
                    float result = operation.doAddition(num1, num2);
                    Console.WriteLine("The result of the operation (" + num1 + " + " + num2 + ") is " + result + ".");
                }
                else if (option == 2)
                {
                    Subtraction operation = new Subtraction();
                    float result = operation.doSubtraction(num1, num2);
                    Console.WriteLine("The result of the operation (" + num1 + " - " + num2 + ") is " + result + ".");
                }
                else if (option == 3)
                {
                    Multiplication operation = new Multiplication();
                    float result = operation.doMultiplication(num1, num2);
                    Console.WriteLine("The result of the operation (" + num1 + " * " + num2 + ") is " + result + ".");
                }
                else if (option == 4)
                {
                    Division operation = new Division();
                    float result = operation.doDivision(num1, num2);
                    Console.WriteLine("The result of the operation (" + num1 + " / " + num2 + ") is " + result + ".");
                }
                else
                {
                    Console.WriteLine("Closing the system.");
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to execute another operation?");
                Console.WriteLine("Type 'yes' to continue.");
                string answer = Console.ReadLine();

                if (answer == "yes")
                    option = 11;
                else
                {
                    option = 0;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using MyCalculator.");
                    Console.WriteLine("Closing the system.");
                }

            } while (option > 10);

        }
    }
}
