using InversionOfControlHw.Models;

namespace InversionOfControlHw.Output
{
    internal class FileOutput
    {
        private readonly List<Animal> _animals = new List<Animal>();
        private void SaveData()
        {
            string projectDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? string.Empty;
            string folderPath = Path.Combine(projectDir, "FileData");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using StreamWriter writer = new StreamWriter(Path.Combine(folderPath, "animals.txt"));
        }
    }
}
