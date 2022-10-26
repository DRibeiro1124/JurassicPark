using System;

namespace JurassicPark
{
    public class DinoGreeting
    {
        public void Greeting()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("🦖🦕 Welcome to Jurassic Park! 🦖🦕");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input ☠️");
                return userInput;
            }

        }
    }
}
