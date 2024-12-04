// See https://aka.ms/new-console-template for more information

using AdventOfCode.Logic.Common;
using AdventOfCode.Logic.Days;

Console.WriteLine(" **** **** *** *** *** **** ****");
Console.WriteLine(" Advent of Code 2024 - C# Runner");
Console.WriteLine(" **** **** *** *** *** **** ****");
Console.WriteLine();

#region Day 1
// var dayOne = new DayOne();
// var lines = FileReader.Read("Day01.txt");
// var result = dayOne.PartOne(lines);
// Console.WriteLine($"Day 01 - Part 1: {result}");
//
// var resultDayOnePartTwo = dayOne.PartTwo(lines);
// Console.WriteLine($"Day 01 - Part 2: {resultDayOnePartTwo}");
#endregion

#region Day 2
// var dayTwo = new DayTwo();
// var linesDayTwo = FileReader.Read("Day02.txt");
// var resultDayTwoPartOne = dayTwo.PartOne(linesDayTwo);
// Console.WriteLine($"Day 02 - Part 1: {resultDayTwoPartOne}");
// var resultDayTwoPartTwo = dayTwo.PartTwo(linesDayTwo);
// Console.WriteLine($"Day 02 - Part 2: {resultDayTwoPartTwo}");
#endregion

#region Day 3
var dayThree = new DayThree();
var linesDayThree = FileReader.Read("Day03.txt");
var resultDayThreePartOne = dayThree.PartOne(linesDayThree);
Console.WriteLine($"Day 03 - Part 1: {resultDayThreePartOne}");
var resultDayThreePartTwo = dayThree.PartTwo(linesDayThree);
Console.WriteLine($"Day 03 - Part 2: {resultDayThreePartTwo}");
#endregion
