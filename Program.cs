using System;

namespace JurassicPark
{
    partial class Program
    {
        static void Main(string[] args)
        {
            DinoGreeting greet = new DinoGreeting();
            greet.Greeting();

            bool keepGoing = true;
            string userInput = " ";

            while (keepGoing)
            {
                Console.WriteLine($"*==*==*==*==*==*==*==*==*==*==*==*==*==*==*==*+==*");
                Console.WriteLine($"Please choose one of the following menu options:");
                Console.WriteLine();
                Console.WriteLine($"(A)dd a Dinosaur to the database ");
                Console.WriteLine();
                Console.WriteLine($"(R)emove a Dinosaur from the database");
                Console.WriteLine();
                Console.WriteLine($"(T)ransfer a Dinosaur to a different enclosure");
                Console.WriteLine();
                Console.WriteLine($"(S)ummarize herbivore/carnivore count");
                Console.WriteLine();
                Console.WriteLine($"(V)iew the Dinosaurs in order");
                Console.WriteLine();
                Console.WriteLine($"(Q)uit to exit");
                Console.WriteLine();


                userInput = Console.ReadLine().ToUpper();

                switch (userInput)
                {
                    case "A":
                        string newName = " ";
                        string newDiet = " ";
                        int newWeight = 0;
                        int newEnclosure = 0;

                        Console.WriteLine($"What type is the Dinosaur? (H)erbivore or (C)arnivore");
                        string userResponse = Console.ReadLine().ToUpper();

                        if (userResponse == "H")
                        {
                            newDiet = "Herbivore";
                        }
                        else if (userResponse == "C")
                        {
                            newDiet = "Carnivore";
                        }
                        else
                        {
                            Console.WriteLine($"Invalid diet Type");
                            break;
                        }

                        Console.WriteLine($"What is the name of the Dinosaur?");
                        newName = Console.ReadLine();

                        Console.WriteLine($"What is the weight, in pounds, of the Dinosaur?");
                        newWeight = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Which enclosure # is {newName} going to be residing?");
                        newEnclosure = int.Parse(Console.ReadLine());

                        DinosaurDatabase.Add(newName, newDiet, newWeight, newEnclosure);
                        break;

                    case "R":
                        Console.WriteLine($"Which Dinosaur would you like to remove from the database?");
                        Dinosaur removeDinosaur = DinosaurDatabase.Remove(Console.ReadLine());

                        if (removeDinosaur != null)
                        {
                            Console.WriteLine($"{removeDinosaur.Name} has been removed from database");
                        }
                        else
                        {
                            Console.WriteLine($"This Dinosaur does not exist in our database");
                        }
                        break;

                    case "T":
                        Console.WriteLine($"What is the name of the Dinosaur you need to transfer?");
                        string transferDinosaur = Console.ReadLine();

                        Console.WriteLine($"What is the new enclosure number to transfer the Dinosaur?");
                        int newTransferEnclosure = int.Parse(Console.ReadLine());

                        Dinosaur transferringDino = DinosaurDatabase.Transfer(transferDinosaur, newTransferEnclosure);

                        if (transferringDino != null)
                        {
                            Console.WriteLine($"{transferringDino} has been transferred to its new enclosure.");
                        }
                        else
                        {
                            Console.WriteLine($"The Dinosaur does not exist in our database");
                        }

                        break;

                    case "S":
                        DinosaurDatabase.Summary();
                        break;

                    case "V":
                        Console.WriteLine($"Do you wish to view the Dinosaurs by (N)ame or by (E)nclosure?");
                        string userAnswer = Console.ReadLine();

                        if (userAnswer.ToUpper() == "N")
                        {
                            DinosaurDatabase.ViewDinosaur("Name");
                        }
                        else
                            if (userAnswer.ToUpper() == "E")
                        {
                            DinosaurDatabase.ViewDinosaur("Enclosure");
                        }

                        break;

                    case "Q":
                        keepGoing = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            Console.WriteLine($"Thank you for visiting Jurassic Park 🦖🦕");

        }
    }
}
