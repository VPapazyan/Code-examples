using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 30, 10, 50 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length-i; j++)
                {
                    if(array[i] == array[j])
                    {
                        
                        Console.WriteLine($"array[{i}] and array[{j}] are identical");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
