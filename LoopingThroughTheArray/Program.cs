using System;

namespace LoopingThroughTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apples", "bananas", "oranges", "pears", "plums", "pine-apple" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "oranges")
                {
                    fruits[i] = "tangerines";
                }
            }
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}