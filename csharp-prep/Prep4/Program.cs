using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber != 0)

        {
            Console.Write("Enter a number: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Compute the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        // Find the max

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");



        // Find the smallest positive number
        int smallestPositive = numbers.Where(x => x > 0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");



        // Sort the numbers
        numbers.Sort();
        Console.WriteLine("The sorted list is: " + string.Join(", ", numbers));



    }
}
