using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Day2
{
    public class Day2
    {
        public void Run()
        {
            var passwordLines = File
                .ReadAllLines("Day2\\input.txt")
                .ToList();

            Part1(passwordLines);
            Part2(passwordLines);
        }

        private static void Part1(IEnumerable<string> passwordLines)
        {
            var passwords = new List<Password>();

            foreach (var line in passwordLines)
            {
                var passwordParts = line.Split(' ');
                var occurrenceParts = passwordParts[0].Split('-');

                var policy = new MinMaxPolicy(
                    int.Parse(occurrenceParts[0]), 
                    int.Parse(occurrenceParts[1]), 
                    passwordParts[1][0]);
                
                passwords.Add(new Password(passwordParts[2], policy));
            }

            Console.WriteLine($"Part1 - Number of valid passwords: {passwords.Count(x => x.IsValid)}");
        }

        private static void Part2(IEnumerable<string> passwordLines)
        {
            var passwords = new List<Password>();

            foreach (var line in passwordLines)
            {
                var passwordParts = line.Split(' ');
                var occurrenceParts = passwordParts[0].Split('-');

                var policy = new OneOccurrencePolicy(
                    int.Parse(occurrenceParts[0]) - 1,
                    int.Parse(occurrenceParts[1]) - 1,
                    passwordParts[1][0]);

                passwords.Add(new Password(passwordParts[2], policy));
            }

            Console.WriteLine($"Part2 - Number of valid passwords: {passwords.Count(x => x.IsValid)}");
        }
    }

}