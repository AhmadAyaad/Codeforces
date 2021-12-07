using System;

namespace CodeForces
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine().Trim();
            var finalName = String.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                if (finalName.Contains(name[i]))
                    continue;
                else
                    finalName += name[i];
            }
            if (finalName.Length % 2 == 0)
                Console.WriteLine("CHAT WITH HER!");
            else
                Console.WriteLine("IGNORE HIM!");
        }
    }
}
