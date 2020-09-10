using System;
using System.IO.Pipes;

namespace Assignment_Sinead_Jacobsson_Sept_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world's best calculator!");

            // create menu 

            bool runMenu = true;
            do
            {
                Console.Clear();
                Console.Write("----menu----\nEnter one of the following options: ?\nAdd.\nSubtract.\nMultipy.\nDivide.\nQuit.\nSelection: ");

                string userInput = Console.ReadLine();

                double numberOne;
                double numberTwo;
                double result;


                switch (userInput)
                {

                    case "add":

                        Console.Write("Please enter first number: ");
                        numberOne = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Please enter a second number: ");
                        numberTwo = Convert.ToDouble(Console.ReadLine());

                        result = comAddition(numberOne, numberTwo);
                        Console.WriteLine("Your answer is: " + result);
                        break;

                    case "subtract":

                        Console.Write("Please enter first number: ");
                        numberOne = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Please enter a second number: ");
                        numberTwo = Convert.ToDouble(Console.ReadLine());

                        result = comSubtract(numberOne, numberTwo);
                        Console.WriteLine("Your answer is: " + result);
                        break;


                   case "multiply":

                        Console.Write("Please enter first number: ");
                        numberOne = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Please enter a second number: ");
                        numberTwo = Convert.ToDouble(Console.ReadLine());

                        result = comMultiply(numberOne, numberTwo);
                        Console.WriteLine("Your answer is: " + result);
                        break;

                    case "divide":

                        Console.Write("Please enter first number: ");
                        numberOne = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Please enter a second number: ");
                        numberTwo = Convert.ToDouble(Console.ReadLine());

                        result = comDivide(numberOne, numberTwo);
                        Console.WriteLine("Your answer is: " + result);
                        break;
                   

                    case "quit":
                        runMenu = false;
                        break;

                    default:
                        Console.WriteLine("not a valid input.");
                        break;

                }

                Console.Write("press a key to continue.");
                Console.ReadKey();

            } while (runMenu);

            // method for addition

            static double comAddition(double numberOne, double numberTwo)
            {
                double addition = numberOne + numberTwo;

                return addition;

            }

                
             static double comSubtract(double numberOne, double numberTwo)
            {
                double subtract = numberOne - numberTwo;

                return subtract;

            }


            static double comMultiply(double numberOne, double numberTwo)
             {
                double multiply = numberOne * numberTwo;

                return multiply;

             }

             static double comDivide(double numberOne, double numberTwo)
              {
                  double divide = numberOne / numberTwo;

                   return divide;

                    }
                    





                }
            }
        }

    