
using System;

class Program
{
    static void Main()
    {
        int count = 0, sum = 0;
        int highest = 0, lowest = 0;

        while (true)
        {
            Console.Write("Enter grade (-1 to stop): ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade == -1)
                break;

            if (count == 0)
            {
                highest = grade;
                lowest = grade;
            }

            if (grade > highest)
                highest = grade;

            if (grade < lowest)
                lowest = grade;

            sum += grade;
            count++;
        }

        if (count > 0)
        {
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + (double)sum / count);
            Console.WriteLine("Highest: " + highest);
            Console.WriteLine("Lowest: " + lowest);
        }
        else
        {
            Console.WriteLine("No grades entered.");
        }
    }
}
