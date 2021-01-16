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

            Console.WriteLine("Type some random characters");
            var characters = Console.ReadLine();
            string newString = string.Empty;
            var counter = 1;
            foreach (char a in characters)
            {
                for (int i = 0; i < counter; i++)
                {
                    newString += a;
                }
                newString += "-";
                counter++;
            }
            Console.WriteLine($"Here is the new string {newString.TrimEnd('-')}");

            var operators = new string[] { "*", "/", "+", "^2" };
            Console.WriteLine($@"
                   Type the operator you want to use for the calculator below:
                   1) {operators[0]}
                   2) {operators[1]}
                   3) {operators[2]}
                   4) {operators[3]}
                ");

            Console.WriteLine("Type your operator then enter a comma separated list of numbers (example:* 1,2,3)");
            var numbers = Console.ReadLine();
            string[] seperateOperator = numbers.Split(" ");
            string[] splitArray = seperateOperator[1].Split(",");
            var product = 1;
            var sum = 0;
            var quotient = 0;
            string square = "";
            if (seperateOperator[0] == "*")
            {
                foreach (var n in splitArray)
                {
                    product *= int.Parse(n);
                }
                Console.WriteLine($"The Product = {product}");

            }
            if (seperateOperator[0] == "^2")
            {
                foreach (var n in splitArray)
                {
                    int Int = int.Parse(n);
                    int squaredInt = Int *= Int;
                    string squaredString = squaredInt.ToString();
                    square += $"{squaredString},";
                }
                Console.WriteLine($"Your squared numbers are {square.TrimEnd(',')}");
            }
            if (seperateOperator[0] == "+")
            {
                foreach (var n in splitArray)
                {
                    int Int = int.Parse(n);
                    sum += Int;
                }
                Console.WriteLine($"The sum of your numbers is {sum}");
            }
            if (seperateOperator[0] == "/")
            {
                foreach (var n in splitArray)
                {

                }
            }



        }
    }
}
