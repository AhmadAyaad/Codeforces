using System;
namespace Team
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfProblems = Convert.ToInt32(Console.ReadLine());
            int numberOfProblemsWillBeSolved = 0;
            for (int i = 0; i < numberOfProblems; i++)
            {
                var line = Console.ReadLine();
                var splittedLine = line.Split(" ");
                if (Convert.ToInt32(splittedLine[0]) + Convert.ToInt32(splittedLine[1]) + Convert.ToInt32(splittedLine[2]) >= 2)
                {
                    numberOfProblemsWillBeSolved++;
                }
            }
            Console.WriteLine(numberOfProblemsWillBeSolved);
        }

    }
}
