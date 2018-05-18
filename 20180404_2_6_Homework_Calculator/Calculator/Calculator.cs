using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180404_2_6_Homework_Calculator.Calculator
{
    class Calculator
    {
        public void Calculate(double firstNumber, double secondNumber, int operandChoice)
        {
            if (operandChoice == 1)
            {
                // three different options for displaying text - 
                // the resulting text is the same for all three examples -

                //Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
                //Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, (firstNumber + secondNumber));
                Console.WriteLine($"{firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
            }
            else if (operandChoice == 2)
            {
                Console.WriteLine($"{secondNumber} - {firstNumber} = " + (secondNumber - firstNumber));
            }
            else if (operandChoice == 3)
            {
                Console.WriteLine($"{firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
            }
            else if (operandChoice == 4)
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
            }
            else if (operandChoice == 5)
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
            }
            else if (operandChoice == 6)
            {
                Console.WriteLine($"{secondNumber} / {firstNumber} = " + (secondNumber / firstNumber));
            }
        }
    }
}
