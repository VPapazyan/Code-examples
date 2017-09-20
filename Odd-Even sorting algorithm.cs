using System;


namespace Odd_Even_sorting_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 3, 7, 5, 9, 6, 8, 1 };
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < array.Length - 1; j += 2)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }

                else
                {
                    for (int j = 1; j < array.Length - 1; j += 2)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
