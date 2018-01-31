using System;

namespace _15._Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int toCheck = 2; toCheck <= number; toCheck++)
            {
                bool isPrime = true;
                for (int current = 2; current <= Math.Sqrt(toCheck); current++)
                {
                    if (toCheck % current == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{toCheck} -> {isPrime}");
            }
        }
    }
}
