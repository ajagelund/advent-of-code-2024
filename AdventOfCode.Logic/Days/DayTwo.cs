namespace AdventOfCode.Logic.Days;

public class DayTwo : IDay
{
    private bool IsSafe(string[] row)
    {
        if (row.Length < 2)
        {
            return false;
        }
        
        var firstDirection = int.Parse(row[1])-int.Parse(row[0]);
        var errorCount = 0;
        
        for (int i = 0; i < row.Length-1; i++)
        {
            var currentLevel = int.Parse(row[i]);
            var nextLevel = int.Parse(row[i+1]);
            var direction = nextLevel-currentLevel;
            var diff = Math.Abs(direction);

            errorCount += IsDiffOk(diff) && IsDirectionOk(direction) ? 0 : 1;

            if (errorCount > 0)
            {
                return false;
            }
        }

        return true;

        bool IsDiffOk(int diff)
        {
            return diff >= 1 && diff <= 3;
        }

        bool IsDirectionOk(int direction)
        {
            return firstDirection * direction > 0;
        }
    }

    public string PartOne(string[] input)
    {
        var safeReports = 0;
        foreach (var line in input)
        {
            var row = line.Split(" ");
            safeReports += IsSafe(row) ? 1 : 0;
        }

        return safeReports.ToString();
    }

    public string PartTwo(string[] input)
    {
        var safeReports = 0;
        foreach (var line in input)
        {
            var row = line.Split(" ");
            var isSafe = IsSafe(row);
            safeReports += isSafe ? 1 : 0;
            
            if (!isSafe)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    var tempRow = row.Where((x, index) => index != i).ToArray();
                    isSafe = IsSafe(tempRow);
                    safeReports += isSafe ? 1 : 0;
                    if (isSafe)
                    {
                        break;
                    }
                }
            }
        }

        return safeReports.ToString();
    }
}