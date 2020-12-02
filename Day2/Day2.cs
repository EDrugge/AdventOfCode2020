using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
    public class Day2
    {
        public void Run()
        {
            var passwordLines = File
                .ReadAllLines("Day2\\input.txt")
                .ToList();

            Part1(passwordLines);

            Console.WriteLine($"Number of valid passwords: {validPasswords}");
        }

        private void Part1(List<string> passwordLines)
        {
            var passwordParts = passwordLines.Split(' ');
            var occurrenceParts = passwordParts[0].Split('-');

            var policy = new MinMaxPolicy(
                int.Parse(occurrenceParts[0]), 
                int.Parse(occurrenceParts[1]), 
                passwordParts[1][0]);
            

        }
    }



    public class Password
    {
        public Password(string password, IPolicy policy)
        {
            Value = password

            Policy = new Policy(
                int.Parse(occurrenceParts[0]), 
                int.Parse(occurrenceParts[1]), 
                passwordParts[1][0]);
        }

        public string Value { get; }
        public IPolicy Policy { get; }

        public bool IsValid => Policy.IsValid(Value);
    }

    public interface IPolicy
    {
        bool IsValid(string password);
    }

    public class MinMaxPolicy : IPolicy
    {
        public MinMaxPolicy(int minOccurrence, int maxOccurrence, char letter)
        {
            MinOccurrence = minOccurrence;
            MaxOccurrence = maxOccurrence;
            Letter = letter;
        }

        public int MinOccurrence { get; }
        public int MaxOccurrence { get; }
        public char Letter { get; set; }

        public bool IsValid(string password)
        {
            var numberOfPolicyCharOccurrences = password.Count(x => x == Letter);

                return MinOccurrence <= numberOfPolicyCharOccurrences
                    && numberOfPolicyCharOccurrences <= MaxOccurrence;
        }
    }

}