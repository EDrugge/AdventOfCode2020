﻿using System;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You must pass in which day to run, 1 to 24...");
                return;
            }

            switch (args[0])
            {
                case "1":
                    new Day1.Day1().Run();
                    break;
                case "2":
                    new Day2.Day2().Run();
                    break;
                case "3":
	                new Day3.Day3().Run();
	                break;
                default:
                    Console.WriteLine($"Day {args[0]} is not yet implemented!");
                    break;
            }
        }
    }
}
