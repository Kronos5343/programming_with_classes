using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the random number guesser game!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        
        int intguess = 0;

        while (intguess != number )
        {
            Console.Write("Guess a number: ");
            string guess = Console.ReadLine();
            intguess = int.Parse(guess);
            if (intguess < number)
            {
                Console.WriteLine("Higher!");
            }
            if (intguess > number)
            {
                Console.WriteLine("Lower!");
            }
            if (intguess == number)
            {
                Console.WriteLine("You got it!");

            }

        }










    }
}