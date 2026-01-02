namespace EighteenthConsoleApp
{
    internal class Student
    {
        public string Name { get; set; } = string.Empty;
        public uint Age { get; set; }
        public uint Grade { get; set; }
        public string City { get; set; } = string.Empty;

        public override string ToString()
        {
            return
                $"{Name}," +
                $"Age: {Age}," +
                $"Grade: {Grade}," +
                $"City: {City}";
        }
    }
}
