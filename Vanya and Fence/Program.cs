using System;

namespace Vanya_and_Fence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = input.Split(" ");
            var numberOfPersons = Convert.ToInt32(data[0]);
            var fenceHeight = Convert.ToInt32(data[1]);
            var personsData = Console.ReadLine();
            var personsHeight = personsData.Split(" ");
            int counter = 0;
            var heights = Array.ConvertAll<string, int>(personsHeight, (item) =>
            {
                int personHeight = Convert.ToInt32(item);
                if (personHeight > fenceHeight)
                    counter += 2;
                else
                    counter++;
                return personHeight;
            });
            Console.WriteLine(counter);
        }
    }
}
