using System;

class ArrayDifference
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of array: ");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size))
        {
            Console.WriteLine("Invalid input. Please enter an integer value.");
        }

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter the element at index {0}: ", i);
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
            }
        }

        int max = numbers[0];
        int min = numbers[0];

        for (int i = 1; i < size; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
            if (numbers[i] < min)
                min = numbers[i];
        }

        int difference = max - min;
        Console.WriteLine("Difference between max and min: " + difference);
    }
}


