using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the method with specific arguments
        DisplayEvenSum(1, 2, 3, 4, 5, 6);
    }

    static void DisplayEvenSum(params int[] numb)
    {
        int sum = 0;

        foreach (int n in numb)
        {
            if (n % 2 == 0) // Check if the number is even
            {
                sum += n;
            }
        }

        Console.WriteLine("The sum of even numbers is:"+ sum);
    }
}
