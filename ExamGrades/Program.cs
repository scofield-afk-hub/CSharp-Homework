Console.Write("Enter first exam grade: ");
double grade1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second exam grade: ");
double grade2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter third exam grade: ");
double grade3 = Convert.ToDouble(Console.ReadLine());

double sum = grade1 + grade2 + grade3;
double average = sum / 3;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average:F2}");
Console.WriteLine($"Average is >= 60: {average >= 60}");
