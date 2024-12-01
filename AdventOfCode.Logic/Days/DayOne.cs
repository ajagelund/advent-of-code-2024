namespace AdventOfCode.Logic.Days;

public class DayOne : IDay
{
    private static (List<int> firstCol, List<int> secondCol) Prepare(string[] input)
    {
        var firstCol = new List<int>();
        var secondCol = new List<int>();
        
        foreach (var line in input)
        {
            var splits = line.Split("   ");
            firstCol.Add(int.Parse(splits[0]));
            secondCol.Add(int.Parse(splits[1]));
        }

        firstCol.Sort();
        secondCol.Sort();
        return (firstCol, secondCol);
    }

    public string PartOne(string[] input)
    {
        var ( firstCol, secondCol ) = Prepare(input);

        var sum = 0;
        for (int i = 0; i < firstCol.Count; i++)
        {
            sum += Math.Abs(firstCol[i] - secondCol[i]);
        }
        
        return sum.ToString();
    }

    public string PartTwo(string[] input)
    {
        var ( firstCol, secondCol ) = Prepare(input);

        var sum = 0;
        for (int i = 0; i < firstCol.Count; i++)
        {
            sum += firstCol[i] * CalculateOccurances(secondCol, firstCol[i]);

            int CalculateOccurances(List<int> ints, int i1)
            {
                if (!ints.Contains(i1)) return 0;
                return ints.LastIndexOf(i1)-ints.IndexOf(i1)+1;
            }
        }
        
        return sum.ToString();
    }
}