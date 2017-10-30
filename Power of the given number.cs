using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_the_given_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }
            Console.WriteLine($"The result is {result}");
            Console.ReadKey();
        }
    }
}
