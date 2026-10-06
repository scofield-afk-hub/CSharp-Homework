Console.Write("Enter temperature in Celsius: ");

double celsius = Convert.ToDouble(Console.ReadLine());

double kelvin = celsius + 273.15;
double fahrenheit = celsius * 9 / 5 + 32;

Console.WriteLine($"Kelvin: {kelvin:F2}");
Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
