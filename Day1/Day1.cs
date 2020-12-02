using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Day1
{
    public class Day1
    {
        public void Run()
        {
            var numbers = File
                .ReadAllLines("Day1\\input.txt")
                .Select(int.Parse)
                .ToList();

            Part1(numbers);
            Part2(numbers);
        }

        public void Part1(IList<int> numbers)
        {
            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 0; j < numbers.Count; j++)
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

        public void Part2(IList<int> numbers)
        {
            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 0; j < numbers.Count; j++)
                {
                    if (j == i)
                        continue;

                    for (var k = 0; k < numbers.Count; k++)
                    {
                        if (k == i || k == j)
                            continue;
                        
                        var a = numbers[i];
                        var b = numbers[j];
                        var c = numbers[k];

                        var sum = a + b + c;
                        if (sum == 2020)
                        {
                            var product = a * b * c;
                            Console.WriteLine($"{a} * {b} * {c} = {product}");
                            return;
                        }
                    }
                }
            }
        }
    }
}