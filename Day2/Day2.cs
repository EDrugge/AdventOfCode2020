using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
    public class Day2
    {
        public void Run()
        {

            var validPasswords = File
                .ReadAllLines("Day2\\input.txt")
                .Select(x => new Password(x))
                .Count(x => x.IsValid);

            Console.WriteLine($"Number of valid passwords: {validPasswords}");
        }

        private class Password
        {
            public Password(string input)
            {
                var passwordParts = input.Split(' ');
                var occurrenceParts = passwordParts[0].Split('-');

                Value = passwordParts[2];

                Policy = new Policy(
                    int.Parse(occurrenceParts[0]), 
                    int.Parse(occurrenceParts[1]), 
                    passwordParts[1][0]);
            }

            public string Value { get; }
            public Policy Policy { get; }

            public bool IsValid
            {
                get
                {
                    var numberOfPolicyCharOccurrences = Value.Count(x => x == Policy.Letter);

                    return Policy.MinOccurrence <= numberOfPolicyCharOccurrences
                        && numberOfPolicyCharOccurrences <= Policy.MaxOccurrence;
                }
            }
        }

        
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