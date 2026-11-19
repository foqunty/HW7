class Course
{
    private int credits;

    public string Code { get; init; }
    public string Name { get; set; }

    public int Credits
    {
        get { return credits; }
        set
        {
            if (value >= 1 && value <= 10)
                credits = value;
            else
                throw new ArgumentException("Credits must be between 1 and 10");
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
        return Code + " " + Name + " (" + Credits + " cr)";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Course[] courses = new Course[5];
        courses[0] = new Course("CENG211", "Object Oriented Programming", 4);
        courses[1] = new Course("MAT251", "Linear Algebra", 3);
        courses[2] = new Course("CENG201", "Data Structures", 4);
        courses[3] = new Course("PHYS102", "Physics II", 5);
        courses[4] = new Course("ENG201", "Academic English", 2);

        foreach (Course c in courses)
        {
            Console.WriteLine(c.Info());
        }

        int total = 0;
        foreach (Course c in courses)
        {
            total += c.Credits;
        }
        Console.WriteLine();
        Console.WriteLine("Total credits: " + total);

        string[] names = new string[courses.Length];
        for (int i = 0; i < courses.Length; i++)
        {
            names[i] = courses[i].Name;
        }
        Array.Sort(names);

        Console.WriteLine();
        Console.WriteLine("Sorted names:");
        foreach (string n in names)
        {
            Console.WriteLine(n);
        }
    }
}
