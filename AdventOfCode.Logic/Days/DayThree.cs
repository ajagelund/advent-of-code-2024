using System.Text.RegularExpressions;

namespace AdventOfCode.Logic.Days;

public class DayThree : IDay
{
    // private static readonly Regex Rex = new(@"(mul\()([0-9]+)(,)([0-9]+)(\))");
    private static readonly Regex Rex = new(@"(do(n't)?\(\))|(mul\()([0-9]+)(,)([0-9]+)(\))");
    private static int Calculate(string[] input, bool applyRules)
    {
        var data = string.Join("", input);
        var matches = Rex.Matches(data);
        var sum = 0;
        var doMultiply = true;
        for (var i = 0; i < matches.Count; i++)
        {
            if (applyRules && matches[i].Groups[1].Value != "")
            {
                if (matches[i].Groups[1].Value == "do()")
                {
                    doMultiply = true;
                }
                else if (matches[i].Groups[1].Value == "don't()")
                {
                    doMultiply = false;
                }
            }
            if (!doMultiply || matches[i].Groups[3].Value != "mul(")
            {
                continue;
            }
            sum += int.Parse(matches[i].Groups[4].Value) * int.Parse(matches[i].Groups[6].Value);
        }

        return sum;
    }

    public string PartOne(string[] input)
    {
        return Calculate(input, false).ToString();
    }

    public string PartTwo(string[] input)
    {
        return Calculate(input, true).ToString();
    }
}