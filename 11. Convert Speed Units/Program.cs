using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int sekonds = int.Parse(Console.ReadLine());
            int time = sekonds + minutes * 60 + hours * 3600;
            float metterPerSeconds = (float) (distance) / time;
            float kmPerHour =((float)distance/ 1000) /( (float)time /3600);
            float milesPerHour =((float)distance / 1609) / ((float) time / 3600);
            Console.WriteLine($"{metterPerSeconds:0.#######}");
            Console.WriteLine($"{kmPerHour:0.#######}");
            Console.WriteLine($"{milesPerHour:0.#######}");

        }
    }
}
