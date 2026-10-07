Console.WriteLine("Name: Deniz Karayiğit");
Console.WriteLine("Department: Computer Engineering");
Console.WriteLine("Year: 2");
Console.WriteLine("Date: " + DateTime.Now);
Console.Write("Enter Celsius: ");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine("Fahrenheit: " + fahrenheit);
