using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            tal[0] = 5;
            tal[1] = 9;
            Console.WriteLine("Skriv in tredje heltalet.");
            tal[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Här är de 3 talen");
            Console.WriteLine($"{tal[0]}, {tal[1]}, {tal[2]}");

        }
    }
}
            




