using System;

namespace _05._Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            bool output = Convert.ToBoolean(input);
            if (output) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }
    }
}
