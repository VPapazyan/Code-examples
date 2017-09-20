using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 30, 40, 50 };
            int average =0;

            for (int i = 0; i < array.Length; i++)
            {                
                average += array[i];
            }
            average /= array.Length;

            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
