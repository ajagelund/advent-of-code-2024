using AdventOfCode.Logic.Common;
using AdventOfCode.Logic.Days;

namespace AdventOfCode.Tests.Days;

public class DayThreeTest
{
    private readonly string[] input = FileReader.Read("Day03-Sample.txt");
    private readonly IDay sut = new DayThree();

    [Fact]
    public void PartOneTest()
    {
        //Arrange
        var expected = "161";

        //Act
        var result = sut.PartOne(input);

        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void PartTwoTest()
    {
        //Arrange
        var expected = "48";

        //Act
        var result = sut.PartTwo(input);

        //Assert
        Assert.Equal(expected, result);
    }
}