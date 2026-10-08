using System;

Console.WriteLine("Hello C#");

Console.WriteLine("Deniz Karayiğit");
Console.WriteLine("Computer Engineering");
Console.WriteLine("2nd Year");

Console.WriteLine();
Console.WriteLine("Current Date and Time:");
Console.WriteLine(DateTime.Now);

Console.WriteLine();
Console.Write("Enter temperature in Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = celsius * 9 / 5 + 32;

Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2} °F");
