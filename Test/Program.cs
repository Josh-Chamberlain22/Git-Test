using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a number between 0 and 100");
            Random rnd = new Random();
            Console.WriteLine("Pick the lowest number in the range: ");
            int lowerBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick the highest number in the range: ");
            int upperBound = Convert.ToInt32(Console.ReadLine());
            int value = rnd.Next(lowerBound, upperBound);
            Console.Write("Guess Number: ");
            int userValue = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (value != userValue) { 
                if (value < userValue)
                {
                    Console.WriteLine("The number is too high. Please guess again");
                    userValue = Convert.ToInt32(Console.ReadLine());
                    counter++;
                }
                else
                {
                    Console.WriteLine("The number is too low. Please guess again");
                    userValue = Convert.ToInt32(Console.ReadLine());
                    counter++;
                }
            }
            Console.WriteLine("You guessed Correct!");
        }
    }
}
