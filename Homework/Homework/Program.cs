using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
   public  class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;

            Console.WriteLine("Hello! \nWe will have to insert two numbers and we will show you all the basic matematical operations :)\n");

            Console.WriteLine("Insert first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nThe sum of the numbers is: " + Add(firstNumber, secondNumber));
            Console.WriteLine("The difference of the numbers is: " + Substract(firstNumber, secondNumber));
            Console.WriteLine("The product of the numbers is: " + Multiply(firstNumber, secondNumber));
            Console.WriteLine("The ratio of the numbers is: " + Divide(firstNumber, secondNumber));

            Console.WriteLine("\nPress enter to quit the calculator...");
            Console.ReadKey();
        }
        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Substract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;

        }
    }
}
