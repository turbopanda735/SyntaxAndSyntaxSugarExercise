using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxAndSyntaxSugarExercise
{
    internal class Program
    {
        static void Main()
        {
            var firstName = "Joel";
            var myAge = 24;
            var myDouble = 19.99;

            Console.WriteLine($"Hello, my name is {firstName}. I am {myAge}. Every week I pay {myDouble} for groceries.");

            Console.WriteLine("Welcome to which number is bigger...");
            Console.WriteLine("enter TWO numbers...");
            var userInputOne = Console.ReadLine();
            var userInputTwo = Console.ReadLine();
            var variableOne = int.Parse(userInputOne);
            var variableTwo = int.Parse(userInputTwo);
            var result = (variableOne > variableTwo) ? True() : False();
            Console.WriteLine(result);
            Exercise2();
            Console.ReadLine();
        }
        static string True()
        {
            var largerNumber = "First number is larger.";
            return largerNumber;
        }
        static string False()
        {
            var smallerNumber = "First number is smaller.";
            return smallerNumber;
        }
        static void Exercise2()
        {
            Console.WriteLine("please enter a number");
            var answer = int.Parse(Console.ReadLine());
            var response = (answer > 9 ? answer + " is less than nine" : answer + " is greater than or equal to nine");
            Console.WriteLine(response);
        }
    }
}
