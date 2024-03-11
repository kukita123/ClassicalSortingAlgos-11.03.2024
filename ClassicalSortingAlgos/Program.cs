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
            Console.WriteLine(String.Join(", ", array));
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

        static void BubbleSort1(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int swap = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swap;
                    }
                }
            }
        }
        static int[] BubbleSort2(int[] array)
        {
            bool flag = true;
            while(flag)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    flag = false;
                    if (array[i] > array[i + 1])
                    {
                        int swap = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = swap;
                        flag = true;
                    }
                }
            }
            return array;
        }

        static void SelectionSort1(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int swap = array[i];
                array[i] = array[minIndex];
                array[minIndex] = swap;
            }
        }        
        static int[] SelectionSort2(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            { 
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }   
            }
            return array;
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
            Console.WriteLine();

            n = random.Next(3, 20); 
            int[] array2 = new int[n];
            FillArrayData(array2);
            DisplayArray(array2);
            BubbleSort1(array2);
            Console.WriteLine("Array after bubble sort:");
            DisplayArray(array2);
            Console.WriteLine();

            n = random.Next(3, 20);
            int[] array3 = new int[n];
            FillArrayData(array3);
            DisplayArray(array3);
            array3 = BubbleSort2(array3);
            Console.WriteLine("Array after bubble sort:");
            DisplayArray(array3);
            Console.WriteLine();

            n = random.Next(3, 20);
            int[] array4 = new int[n];
            FillArrayData(array4);
            DisplayArray(array4);
            SelectionSort1(array4);
            Console.WriteLine("Array after selection sort:");
            DisplayArray(array4);
            Console.WriteLine();

            n = random.Next(3, 20);
            int[] array5 = new int[n];
            FillArrayData(array5);
            DisplayArray(array5);
            array5 = SelectionSort2(array5);
            Console.WriteLine("Array after selection sort:");
            DisplayArray(array5);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
