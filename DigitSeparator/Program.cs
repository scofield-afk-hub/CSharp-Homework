Console.Write("Enter a 3-digit number: ");

int number = Convert.ToInt32(Console.ReadLine());

int hundreds = number / 100;
int tens = (number / 10) % 10;
int ones = number % 10;

Console.WriteLine($"Hundreds: {hundreds}");
Console.WriteLine($"Tens: {tens}");
Console.WriteLine($"Ones: {ones}");
