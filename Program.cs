// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values.");
            Console.Write("First number: ");
            string firstUserNumber = Console.ReadLine();

            Console.Write("Second number: ");
            string secondUserNumber = Console.ReadLine();

            Console.WriteLine("Converting values in progress...");
            decimal firstNumber = Convert.ToDecimal(firstUserNumber);
            decimal secondNumber = Convert.ToDecimal(secondUserNumber);

            Console.WriteLine("Calculating results...");
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
        }
    }
}
