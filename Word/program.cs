using System;

namespace CodeForces
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            int lowerCounter = 0;
            int upperCounter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i]))
                    lowerCounter++;
                else
                    upperCounter++;
            }
            if (lowerCounter >= upperCounter)
                Console.WriteLine(s.ToLower());
            else
                Console.WriteLine(s.ToUpper());
        }
    }
}
