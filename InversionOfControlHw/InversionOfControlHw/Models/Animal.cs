namespace InversionOfControlHw.Models
{
    internal abstract class Animal(string name, uint weight)
    {
        public string Name { get; set; } = name;
        public uint Weight { get; set; } = weight;
        public abstract void Sound();
    }
}
