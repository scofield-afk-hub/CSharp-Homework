using System;
class Program
{
    static void Main()
    {
        int count = 0;
        int sum = 0;
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine() ?? "0");

        while (number != 0)
        {
            count++;
            sum += number;
            
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine() ?? "0");

        }
        if (count == 0)
        {
            Console.WriteLine("No number entered.");

        }
        else
        {
            double average = (double)sum / count;

            Console.WriteLine("Count: " + count);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

        }
    }
}        



