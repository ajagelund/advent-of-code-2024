namespace AdventOfCode.Logic.Common;

public class FileReader
{
    public static string[]Read(string filename)
    {
        //create file path from current directory
        string filePath = Path.Combine($"{Directory.GetCurrentDirectory()}/Inputs", filename);

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException(filePath);
        }

        return File.ReadAllText(filePath).Split(Environment.NewLine);
    }
}