using System;
using System.Linq;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (char.IsDigit(symbol)) Console.WriteLine("digit");
            else if ("aeiouy".Contains(symbol)) Console.WriteLine("vowel");
            else Console.WriteLine("other");
        }
    }
}
