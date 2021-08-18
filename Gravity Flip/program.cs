using System;

namespace Gravity_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfColumns = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[numberOfColumns];
            var numberOfCubes = Console.ReadLine();
            var splitted = numberOfCubes.Split(' ');
            for (int i = 0; i < splitted.Length; i++)
            {
                arr[i] = Convert.ToInt32(splitted[i]);
            }

            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
