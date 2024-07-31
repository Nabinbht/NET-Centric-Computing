using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Method to check if a number is even
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static void Main(string[] args)
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Use LINQ to filter even numbers using the IsEven method
        var evenNumbers = numbers.Where(IsEven);

        // Print the result
        Console.WriteLine("Even numbers:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
