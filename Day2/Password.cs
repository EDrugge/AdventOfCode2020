namespace AdventOfCode2020.Day2
{
    public class Password
    {
        public Password(string password, IPolicy policy)
        {
            Value = password;
            Policy = policy;
        }

        public string Value { get; }
        public IPolicy Policy { get; }

        public bool IsValid => Policy.IsValid(Value);
    }

}