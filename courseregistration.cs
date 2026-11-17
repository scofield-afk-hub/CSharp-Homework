using System;

class Course
{
    public string Code { get; init; }
    public string Name { get; set; }

    private int credits;

    public int Credits
    {
        get { return credits; }
        set
        {
            if (value >= 1 && value <= 10)
                credits = value;
            else
                throw new ArgumentException("Invalid credits");
        }
    }

    public Course(string code, string name, int credits)
    {
        Code = code;
        Name = name;
        Credits = credits;
    }

    public string Info()
    {
        return $"{Code} {Name} ({Credits} cr)";
    }
}

class Program
{
    static void Main()
    {
        Course[] courses =
        {
            new Course("CENG211", "Object Oriented Programming", 4),
            new Course("MATH211", "Linear Algebra", 3),
            new Course("EE205", "Circuit Analysis", 4),
            new Course("EE243", "Digital Logic", 3),
            new Course("MATH201", "Calculus", 4)
        };

        int totalCredits = 0;

        foreach (Course course in courses)
        {
            Console.WriteLine(course.Info());
            totalCredits += course.Credits;
        }

        Console.WriteLine("\nTotal Credits: " + totalCredits);

        string[] names = new string[courses.Length];

        for (int i = 0; i < courses.Length; i++)
        {
            names[i] = courses[i].Name;
        }

        Array.Sort(names);

        Console.WriteLine("\nAlphabetical Order:");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}