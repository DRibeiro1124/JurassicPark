using System;

namespace JurassicPark
{

    public class Dinosaur
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public DateTime WhenAcquired { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }

        public Dinosaur(string name, string diet, int weight, int enclosure)
        {
            Name = name;
            DietType = diet;
            WhenAcquired = DateTime.Now;
            Weight = weight;
            EnclosureNumber = enclosure;
        }

        public void Description()
        {
            Console.WriteLine($"{Name} was acquired {WhenAcquired} and is a {DietType}. {Name} is in enclosure number {EnclosureNumber} and weights {Weight}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DinoGreeting greet = new DinoGreeting();
            greet.Greeting();

        }
    }
}
