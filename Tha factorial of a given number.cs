using System;


namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // The factorial of a given number
            int num = int.Parse(Console.ReadLine());
                       
            Console.WriteLine($"The result is {Factorial(num)}");
            Console.ReadLine();
        }

        static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
