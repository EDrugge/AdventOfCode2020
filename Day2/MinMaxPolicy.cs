using System.Linq;

namespace AdventOfCode2020.Day2
{
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