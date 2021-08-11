using System;

namespace Bear_and_Big_Brother
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splittedInput = input.Split(" ");
            var limakWeight = Convert.ToInt32(splittedInput[0]);
            var bobWeight = Convert.ToInt32(splittedInput[1]);
            int numberOfYears = 0;
            while (limakWeight <= bobWeight)
            {
                limakWeight *= 3;
                bobWeight *= 2;
                numberOfYears++;
            }
            Console.WriteLine(numberOfYears);
        }
    }
}
