using System;

namespace CodeForces
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = Console.ReadLine().ToLower().Trim();
            var string2 = Console.ReadLine().ToLower().Trim();
            if (string1.Length == string2.Length)
            {
                if (string1 == string2)
                {
                    Console.WriteLine("0");
                    return;
                }
                for (int i = 0; i < string1.Length; i++)
                {
                    if (string1[i] > string2[i])
                    {
                        Console.WriteLine("1");
                        break;
                    }
                    else if (string1[i] < string2[i])
                    {
                        Console.WriteLine("-1");
                        break;
                    }
                }
            }
        }
    }
}
