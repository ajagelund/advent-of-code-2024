// See https://aka.ms/new-console-template for more information

using AdventOfCode.Logic.Common;
using AdventOfCode.Logic.Days;

Console.WriteLine(" **** **** *** *** *** **** ****");
Console.WriteLine(" Advent of Code 2024 - C# Runner");
Console.WriteLine(" **** **** *** *** *** **** ****");
Console.WriteLine();

var dayOne = new DayOne();
var lines = FileReader.Read("Day01.txt");
var result = dayOne.PartOne(lines);
Console.WriteLine($"Day 01 - Part 1: {result}");

var resultDayOnePartTwo = dayOne.PartTwo(lines);
Console.WriteLine($"Day 01 - Part 2: {resultDayOnePartTwo}");