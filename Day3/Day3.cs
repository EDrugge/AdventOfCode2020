using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Day3
{
	public class Day3
	{
		public void Run()
		{
			var lines = File
				.ReadAllLines("Day3\\input.txt")
				.ToList();

			Part1(lines);
			Part2(lines);
		}

		private static void Part1(IList<string> lines)
		{
			var numberOfTrees = Move(0, 3, 1, lines);
			Console.WriteLine($"Part1 - Answer: {numberOfTrees}");
		}

		private static void Part2(IList<string> lines)
		{
			var numberOfTrees1 = Move(0, 1, 1, lines);
			var numberOfTrees2 = Move(0, 3, 1, lines);
			var numberOfTrees3 = Move(0, 5, 1, lines);
			var numberOfTrees4 = Move(0, 7, 1, lines);
			var numberOfTrees5 = Move(0, 1, 2, lines);

			var numberOfTrees = numberOfTrees1
			                * numberOfTrees2
			                * numberOfTrees3
			                * numberOfTrees4
			                * numberOfTrees5;

			Console.WriteLine($"Part2 - Answer: {numberOfTrees}");
		}

		private static int Move(int currentStep, int rightStep, int downStep, IList<string> lines)
		{
			var currentRow = currentStep * downStep;
			if (currentRow >= lines.Count)
			{
				return 0;
			}

			var column = currentStep * rightStep;
			var currentLine = lines[currentRow];

			var multiplier = column / currentLine.Length + 1;
			var multipliedLine = "";
			for (var i = 0; i < multiplier; i++)
			{
				multipliedLine += currentLine;
			}

			var isTree = multipliedLine[column] == '#';
			
			return (isTree ? 1 : 0) + Move(++currentStep, rightStep, downStep, lines);
		}
	}
}