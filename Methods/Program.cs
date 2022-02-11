using System;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            var firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            var lastName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var favoriteBand = Console.ReadLine();

            Console.WriteLine("What is the first name of your best friend?");
            var bestFriendName = Console.ReadLine();

            Console.WriteLine($"Excerpt from the logs of captain {firstName} {lastName}. Captains Log, day X.  Ensign {bestFriendName} came onto the bridge today wearing a " +
                $"{favoriteColor} shirt with a {favoriteAnimal} on it.  When I began to inquire as to why the ensign was out of uniform I was interrupted by {favoriteBand} blaring " +
                $"over the comms.  I fear the crew is becoming too lax and our sanity is slipping away little by little every day.");
        }

    }
}
