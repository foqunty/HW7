// Homework 2 - Course Registration

Course[] courses =
{
    new Course("CENG211", "Object Oriented Programming", 4),
    new Course("MAT251", "Linear Algebra", 3),
    new Course("CENG201", "Data Structures", 4),
    new Course("PHYS102", "Physics II", 5),
    new Course("ENG201", "Academic English", 2)
};

Console.WriteLine("All courses:");
foreach (Course c in courses)
{
    Console.WriteLine("- " + c.Info());
}

int totalCredits = 0;
foreach (Course c in courses)
{
    totalCredits += c.Credits;
}
Console.WriteLine();
Console.WriteLine($"Total credits: {totalCredits}");

string[] names = new string[courses.Length];
for (int i = 0; i < courses.Length; i++)
{
    names[i] = courses[i].Name;
}
Array.Sort(names);

Console.WriteLine();
Console.WriteLine("Course names (alphabetical):");
foreach (string name in names)
{
    Console.WriteLine("- " + name);
}

class Course
{
    private int credits;

    // Code cannot change after creation
    public string Code { get; init; }
    public string Name { get; set; }

    public int Credits
    {
        get { return credits; }
        set
        {
            if (value < 1 || value > 10)
                throw new ArgumentException("Credits must be between 1 and 10.");
            credits = value;
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
