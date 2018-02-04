﻿using System;
using System.Numerics;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            uint centuries = uint.Parse(Console.ReadLine());
            ulong years = centuries * 100;
            ulong days = (ulong)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;

            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = " +
                $"{years} years = " +
                $"{days} days = " +
                $"{hours} hours = " +
                $"{minutes} minutes = " +
                $"{seconds} seconds = " +
                $"{milliseconds} milliseconds = " +
                $"{microseconds} microseconds = " +
                $"{nanoseconds} nanoseconds");
        }
    }
}