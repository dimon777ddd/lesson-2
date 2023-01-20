using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = new int[123];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, 150);
        }

        int count = arr.Count(x => x >= 10 && x <= 99);
        Console.WriteLine(count);
    }
}

