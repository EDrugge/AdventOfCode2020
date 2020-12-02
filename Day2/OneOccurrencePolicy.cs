namespace AdventOfCode2020.Day2
{
    public class OneOccurrencePolicy : IPolicy
    {
        public OneOccurrencePolicy(int firstPosition, int secondPosition, char letter)
        {
            FirstPosition = firstPosition;
            SecondPosition = secondPosition;
            Letter = letter;
        }

        public int FirstPosition { get; }
        public int SecondPosition { get; }
        public char Letter { get; set; }

        public bool IsValid(string password)
        {
            return password[FirstPosition] == Letter && password[SecondPosition] != Letter
                   || password[FirstPosition] != Letter && password[SecondPosition] == Letter;
            
        }
    }
}