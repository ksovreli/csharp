namespace InversionOfControlHw.Models
{
    internal class Bear: Animal
    {
        public Bear(string name, uint weight): base(name, weight)
        {
            
        }

        public override void Sound()
        {
            Console.WriteLine("Roarrrr!");
        }
    }
}
