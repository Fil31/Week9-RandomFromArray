using System;

namespace ForEachinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apples", "bananas", "oranges", "pears", "plums", "pine-apple" };

            foreach (string item in fruits) 
            {
                Console.WriteLine(item); 
                if (item == "oranges")
                {
                    Console.WriteLine($"Boo, I don't like {item}");
                }
            }
        }
    }
}