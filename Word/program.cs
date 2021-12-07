using System;

namespace CodeForces
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            var lowerS = s.ToLower();
            var upperS = s.ToUpper();
            int lowerCounter = 0;
            int upperCounter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == lowerS[i])
                    lowerCounter++;
                else if (s[i] == upperS[i])
                    upperCounter++;
            }
            if (lowerCounter > upperCounter)
                Console.WriteLine(lowerS);
            else if (upperCounter > lowerCounter)
                Console.WriteLine(upperS);
            else
                Console.WriteLine(lowerS);
        }
    }
}
