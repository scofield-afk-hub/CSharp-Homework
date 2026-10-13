
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-10): ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n >= 1 && n <= 10)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }
}
