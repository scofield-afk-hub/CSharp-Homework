using System.Globalization;

const string name = "Deniz Karayiğit";
const string department = "Computer Engineering";
const string year = "2nd Year";

Console.WriteLine("Hello C#");
Console.WriteLine(name);
Console.WriteLine(department);
Console.WriteLine(year);
Console.WriteLine(DateTime.Now);
Console.WriteLine();

Console.Write("Enter temperature in Celsius: ");
string? input = Console.ReadLine();
double celsius;

while (!TryReadTemperature(input, out celsius))
{
    Console.Write("Please enter a valid number for Celsius: ");
    input = Console.ReadLine();
}

double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine($"{celsius} Celsius = {fahrenheit:F2} Fahrenheit");

static bool TryReadTemperature(string? input, out double temperature)
{
    if (double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out temperature))
    {
        return true;
    }

    return double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out temperature);
}
