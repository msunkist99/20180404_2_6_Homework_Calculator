using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20180404_2_6_Homework_Calculator.CalcFunctions;

namespace _20180404_2_6_Homework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "20180404_2_6_Homework_Calculator";

            bool continueFirstLevelLoop = true;
            bool continueSecondLevelLoop = true;

            string firstNumberString;
            string secondNumberString;

            double firstNumberDouble = 0;
            double secondNumberDouble = 0;

            while (continueFirstLevelLoop == true)
            {
                continueSecondLevelLoop = true;

                while (continueSecondLevelLoop == true)
                {
                    Console.Write("\r\nEnter your first number - ");
                    firstNumberString = Console.ReadLine();

                    if (firstNumberString == "")
                    {
                        continueFirstLevelLoop = false;
                        Console.Write("Goodbye");
                        Console.Read();
                        break;
                    }

                    try
                    {
                        firstNumberDouble = Convert.ToDouble(firstNumberString);
                        continueSecondLevelLoop = false;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("FormatException");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Bad input - reenter your first number");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Bad input - reenter your first number");
                    }
                }

                if (continueFirstLevelLoop == false)
                {
                    // user entered nothing - say goodbye
                    break;
                }

                continueSecondLevelLoop = true;
                while(continueSecondLevelLoop == true)
                {
                    Console.Write("Enter your second number - ");
                    secondNumberString = Console.ReadLine();

                    if (secondNumberString == "")
                    {
                        continueFirstLevelLoop = false;
                        Console.Write("Goodbye");
                        Console.Read();
                        break;
                    }

                    try
                    {
                        secondNumberDouble = Convert.ToDouble(secondNumberString);
                        continueSecondLevelLoop = false;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("FormatException");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Bad input - reenter your second number");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Bad input - reenter your second number");
                    }
                }

                if (continueFirstLevelLoop == false)
                {
                    // user entered nothing - say goodbye
                    break;
                }

                continueSecondLevelLoop = true;
                while (continueSecondLevelLoop == true)
                {
                    Console.WriteLine($"\r\nYou entered {firstNumberDouble} and {secondNumberDouble}\r\n");
                    Console.WriteLine($"Enter 1 - to add {firstNumberDouble} + {secondNumberDouble}\r\n" +
                                      $"Enter 2 - to subtract {firstNumberDouble} from {secondNumberDouble}\r\n" +
                                      $"Enter 3 - to subtract {firstNumberDouble} from {secondNumberDouble}\r\n" +
                                      $"Enter 4 - to multiply {firstNumberDouble} * {secondNumberDouble}\r\n" +
                                      $"Enter 5 - to divide {firstNumberDouble} by {secondNumberDouble}\r\n" +
                                      $"Enter 6 - to divide {secondNumberDouble} by {firstNumberDouble}\r\n");

                    string userInputOperandOptionString;
                    int operandOptionInt = 0;

                    userInputOperandOptionString = Console.ReadLine();

                    if (userInputOperandOptionString == "")
                    {
                        continueFirstLevelLoop = false;
                        Console.Write("Goodbye");
                        Console.Read();
                        break;
                    }

                    try
                    {
                        operandOptionInt = Convert.ToInt32(userInputOperandOptionString);

                        if ((operandOptionInt < 1) || (operandOptionInt > 6))
                        {
                            Console.WriteLine("Invalid operand option - enter 1 - 6");
                        }
                        else
                        {
                            continueSecondLevelLoop = false;
                            Calculator calculator = new Calculator();
                            calculator.Calculate(firstNumberDouble, secondNumberDouble, operandOptionInt);
                            continueSecondLevelLoop = false;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("FormatException");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Bad input - reenter your operand option 1 - 6");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Bad input - reenter your operand option 1 - 6");
                    }
                }

                if (continueFirstLevelLoop == false)
                {
                    // user entered nothing - say goodbye
                    break;
                }
            }

            Console.Read();
        }
    }
}
