using System;
using System.Reflection.Metadata.Ecma335;

namespace Methods_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks the user to input a number and converts that number to an integer
            Console.WriteLine("Please enter full number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another full number.");
            int y = Convert.ToInt32(Console.ReadLine());

            //multiplies both numbers
            Console.WriteLine(Multiply(x, y));

            //asks the user for their name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //welcome message
            WelcomeUser(name);

            //goodbye message
            Goodbye();

        }

        /// <summary>
        /// multiplies the inputed number by the other inputed number
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>

        static int Multiply(int num1, int num2) 
        {
            return num1 * num2;
        }

        /// <summary>
        /// prints a welcome message to the console
        /// </summary>
        /// <param name="username"></param>

        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! It's wonderful to meet you!");
        }


        /// <summary>
        /// prints a goodbye message to the console
        /// </summary>



        static void Goodbye()
        {
            Console.WriteLine("Have a fantastic day, user!");
        }


    }
}