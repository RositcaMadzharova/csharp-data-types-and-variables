using System;

namespace Print_Part_of_the_ASCII_Table
{
    class PrintPartOfTheASCIITable
    {
        static void Main(string[] args)
        {
            byte start = byte.Parse(Console.ReadLine());
            byte end = byte.Parse(Console.ReadLine());

            for (byte i = start; i <= end; i++)
            {
                Console.WriteLine($"{(char) i}");
            }

            Console.WriteLine();
        }
    }
}
