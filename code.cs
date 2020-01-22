using System;

namespace CodingChallenge
{
    class Program
    {
        static void Main()
        {
            Wordsalad wordsalad = new Wordsalad();
            Console.WriteLine(Wordsalad.Randomness());
            Console.ReadKey();
        }
    }

    class Wordsalad
    {
        string DesiredName = "Mr. T";
        string KoolAidFlavor = "Mountain Blue";
        string Color = "blue";

        Random RandomNumber = new Random();
        string[] adjectives = { "bitter", "icy", "shaky", "melodic", "majestic", "fleet, "paltry", "abrubt" };
        string[] nouns = { "physics", "papers", "calendars", "professors", "houses" };

        public Wordsalad()
        {
            string title = "Hello";
            Console.Title = title;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(title);
            Console.ResetColor();
        }

        public string Randomness()
        {
            string output = "";

            Console.WriteLine("What name should we call you?");
            DesiredName = Console.ReadLine();
            Console.WriteLine("Favorite Flavor of Koolaid?");
            KoolAidFlavor = Console.ReadLine();
            Console.WriteLine("Favorite Color?");
            Color = Console.ReadLine();
            Console.WriteLine("\n\n\n");

            output += "Here is your serving of word salad.\n\n\n";
            output += "To" + adjectives[RandomNumber.Next(adjectives.Length)] + " " + DesiredName + "\n\n";
            output =  DesiredName + ", I'm sometimes" + adjectives[RandomNumber.Next(adjectives.Length)] + ", like some kind of" + Color + " " + nouns[RandomNumber.Next(nouns.Length)] + "\n";
            output += "or " + KoolAidFlavor + ". A " + adjectives[RandomNumber.Next(adjectives.Length)] + ", " + adjectives[RandomNumber.Next(adjectives.Length)] + " smell.";
            output += "\n\nQuite the mad Mad Lib\n(press enter to quit)";

            return output;
        }

    }
}
