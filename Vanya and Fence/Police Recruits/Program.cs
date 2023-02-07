using System;

namespace Vanya_and_Fence.Police_Recruits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var totalEvents = Convert.ToInt32(Console.ReadLine());
            var splittedEvents = Console.ReadLine().Split(" ");
            var events = Array.ConvertAll(splittedEvents, s => int.Parse(s));
            var untreated = 0;
            var freeOfficersCount = 0;
            for (int i = 0; i < events.Length; i++)
            {
                if (events[i] != -1)
                    freeOfficersCount += events[i];
                else if (events[i] == -1 && freeOfficersCount == 0)
                    untreated++;
                else if (events[i] == -1 && freeOfficersCount > 0)
                    freeOfficersCount--;
            }
            Console.WriteLine(untreated);
        }
    }
}
