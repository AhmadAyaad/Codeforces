using System;

namespace Anton_and_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfGames = Convert.ToInt32(Console.ReadLine());
            char[] gamesOutcome = new char[numberOfGames];
            gamesOutcome = Console.ReadLine().ToCharArray();
            int numberOfAntonWins = 0;
            int numberOfDanikWins = 0;
            foreach (var item in gamesOutcome)
            {
                if (item == 'A')
                    numberOfAntonWins++;
                else if (item == 'D')
                    numberOfDanikWins++;
            }
            if (numberOfAntonWins > numberOfDanikWins)
                Console.WriteLine("Anton");
            else if (numberOfAntonWins < numberOfDanikWins)
                Console.WriteLine("Danik");
            else
                Console.WriteLine("Friendship");
        }
    }
}
