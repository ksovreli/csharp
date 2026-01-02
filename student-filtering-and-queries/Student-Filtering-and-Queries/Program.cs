#region Filtering
using EighteenthConsoleApp;

static void Print<T>(IEnumerable<T> collection)
{
    foreach (T i in collection)
    {
        Console.WriteLine(i);
    }
}

List<Student> students = new List<Student>
{
    new Student { Name = "Alice Johnson", Age = 17, Grade = 4, City = "New York" },
    new Student { Name = "Brian Smith", Age = 18, Grade = 9, City = "Los Angeles" },
    new Student { Name = "Catherine Lee", Age = 16, Grade = 2, City = "Chicago" },
    new Student { Name = "Daniel Kim", Age = 15, Grade = 10, City = "Houston" },
    new Student { Name = "Emily Brown", Age = 17, Grade = 8, City = "Phoenix" },
    new Student { Name = "Frank Garcia", Age = 18, Grade = 2, City = "Philadelphia" },
    new Student { Name = "Grace Wilson", Age = 16, Grade = 3, City = "San Antonio" },
    new Student { Name = "Henry Martinez", Age = 15, Grade = 7, City = "San Diego" },
    new Student { Name = "Isabella Davis", Age = 17, Grade = 8, City = "Dallas" },
    new Student { Name = "Jack Miller", Age = 18, Grade = 5, City = "San Jose" },
    new Student { Name = "Karen Lopez", Age = 16, Grade = 7, City = "Austin" },
    new Student { Name = "Liam Gonzalez", Age = 15, Grade = 9, City = "Jacksonville" },
    new Student { Name = "Mia Perez", Age = 17, Grade = 11, City = "Fort Worth" },
    new Student { Name = "Noah Robinson", Age = 18, Grade = 12, City = "Columbus" },
    new Student { Name = "Olivia Walker", Age = 16, Grade = 10, City = "Charlotte" }
};

var topGrades = students.Where(a => a.Grade > 5).ToList();
Print(topGrades);

Console.WriteLine();
Console.WriteLine("==================================================");
Console.WriteLine();

var countryWithA = students.Where(a => a.City.StartsWith("a", StringComparison.OrdinalIgnoreCase));
Print(countryWithA);

#endregion