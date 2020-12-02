using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
    public class Day1
    {
        public void Run()
        {
            var numbers = File.ReadAllLines("Day1\\input.txt").Select(x => int.Parse(x)).ToList();

            for (int i = 0; i < numbers.Count(); i++)
            {
                for (int j = 0; j < numbers.Count(); j++)
                {
                    if (i == j)
                        continue;
                    
                    var a = numbers[i];
                    var b = numbers[j];

                    var sum = a + b;
                    if (sum == 2020)
                    {
                        var product = a * b;
                        Console.WriteLine($"{a} * {b} = {product}");
                        return;
                    }
                }
            }
        }
    }
}