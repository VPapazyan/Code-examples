using System;


namespace Bubblesort_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 6, 5, 4, 7, 1, 3 };
            int emptyVar;

            Console.Write("Sorted array: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        emptyVar = array[i];
                        array[i] = array[j];
                        array[j] = emptyVar;
                    }
                }
                
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
