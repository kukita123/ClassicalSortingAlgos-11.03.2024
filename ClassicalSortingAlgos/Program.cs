using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalSortingAlgos
{
    class Program
    {
        static void FillArrayData(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
        }
        static void DisplayArray(int[] array)
        {           
                Console.WriteLine("The array is:");
                Console.WriteLine(String.Join(", ",array));            
        }
        static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int index = i;
                int value = array[index];

                while (index > 0 && array[index - 1] >= value)
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = value;
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(3, 20);


            int[] array1 = new int[n];
            FillArrayData(array1);
            DisplayArray(array1);
            InsertionSort(array1);
            Console.WriteLine("Array after insertion sort:");
            DisplayArray(array1);

            Console.ReadKey();
        }
    }
}
