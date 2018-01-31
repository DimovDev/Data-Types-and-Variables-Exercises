using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before: \n\ra = {a}\n\rb = {b}");
            int temp = a;
            a = b;
             b = temp;
            Console.WriteLine($"After: \n\ra = {a}\n\rb = {b}");

        }
    }
}
