using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] sizes = { 5, 10, 50, 100 };
        foreach (var size in sizes)
        {
            int[] arr = GenerateRandomArray(size);
            Stopwatch stopwatch = new Stopwatch();
            
            stopwatch.Start();
            SelectionSort(arr);
            stopwatch.Stop();
            
            Console.WriteLine($"Размер массива: {size}, Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIdx])
                    minIdx = j;
            }

            int temp = arr[minIdx];
            arr[minIdx] = arr[i];
            arr[i] = temp;
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, 100);
        }
        return arr;
    }
}