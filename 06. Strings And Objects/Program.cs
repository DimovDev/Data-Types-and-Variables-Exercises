using System;
using System.Linq;

namespace _06._Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + str2;
            Console.WriteLine($"{str1} {str2}");
        }
    }
}
