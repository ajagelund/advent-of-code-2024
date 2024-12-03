using AdventOfCode.Logic.Common;
using AdventOfCode.Logic.Days;

namespace AdventOfCode.Tests.Days;

public class DayTwoTest
{
    private readonly string[] input = FileReader.Read("Day02-Sample.txt");
    private readonly IDay sut = new DayTwo();

    [Fact]
    public void PartOneTest()
    {
        //Arrange
        var expected = "2";

        //Act
        var result = sut.PartOne(input);

        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void PartTwoTest()
    {
        //Arrange
        var expected = "4";

        //Act
        var result = sut.PartTwo(input);

        //Assert
        Assert.Equal(expected, result);
    }
}