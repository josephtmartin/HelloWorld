using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var user = Console.ReadLine();

            Console.WriteLine($"Hello {user}, we've got some questions for you!");

            var vowels = new string[] { "a", "e", "i", "o", "u" };

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            var greetings = new string[] { "Southern", "Midwest", "Bahsten" };

            Console.WriteLine($@"
                   Pick a Greeting Below:
                   1) {greetings[0]}
                   2) {greetings[1]}
                   3) {greetings[2]}
                ");
            var chosenGreeting = Console.ReadLine();

            switch (chosenGreeting)
            {
                case "Southern":
                    Console.WriteLine($"Come on in! My ma cooked up some biscuits and gravy, you want some?");
                    break;
                case "Midwest":
                    Console.WriteLine("Ope, didn't see ya there bud. Sorry bout that.");
                    break;
                case "Bahsten":
                    Console.WriteLine("Ah, why don't ya go paak the cah down by tha arbor");
                    break;
                default:
                    Console.WriteLine("Come on in! My ma cooked up some biscuits and gravy, you want some?");
                    break;
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("What is your favorite color?");

            var userColor = Console.ReadLine();

            Random rnd = new Random();
            int index = rnd.Next(animals.Length);
            Console.WriteLine($@"Would you like to have a { userColor } { animals[index] } ?");
        }
    }
}
