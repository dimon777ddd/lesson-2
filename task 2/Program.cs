using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 100);
        }
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += arr[i];
            }
        }
        Console.WriteLine("Sum of elements at odd positions: " + sum);
    }
}
