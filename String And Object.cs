using System;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            object obj = first + " " + second;
            Console.WriteLine((string)obj);
        }
    }
}
