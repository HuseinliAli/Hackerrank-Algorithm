using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int measure;
            int[] arr;
            InputArray(out measure, out arr); 
            SelectionSort(measure, arr); 
            Output(measure, arr); Console.WriteLine();
            BubbleSort(measure, arr); 
            Output(measure, arr); Console.WriteLine();
            InsertionSort(measure, arr); 
            Output(measure, arr); Console.WriteLine();
        }

        private static void InsertionSort(int measure, int[] arr)
        {
            Console.WriteLine("Insertion Sort: ");
            for (int i = 1; i<measure; i++)
            {
                int key = arr[i];
                int j = i-1;
                while (j >=0&&arr[j]>key)
                {
                    arr[j+1]=arr[j];
                    j=j-1;
                }
                arr[j+1]=key;
            }
        }

        private static void BubbleSort(int measure, int[] arr)
        {
            Console.WriteLine("Bubble Sort: ");
            for (int i = 0; i <measure-1; i++)
            {
                for (int j = 0; j<measure-1-i; i++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }

        private static void Output(int measure, int[] arr)
        {
            for (int i = 0; i<measure; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }

        private static void SelectionSort(int measure, int[] arr)
        {
            Console.WriteLine("Selection Sort: ");
            for (int i = 0; i <measure; i++)
            {
                int min = i;
                for (int j = i + 1; j < measure; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }

        private static void InputArray(out int measure, out int[] arr)
        {
            Console.Write("Size Of Array: ");
            measure=int.Parse(Console.ReadLine());
            Console.WriteLine("Array: ");
            arr=new int[measure];
            for (int i = 0; i <measure; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
        }
    }
}