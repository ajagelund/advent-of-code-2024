using AdventOfCode.Logic.Common;
using AdventOfCode.Logic.Days;

namespace AdventOfCode.Tests.Days;

public class DayOneTest
{
    private readonly string[] input = FileReader.Read("Day01-Sample.txt");
    private readonly IDay sut = new DayOne();

    [Fact]
    public void PartOneTest()
    {
        //Arrange
        var expected = "11";

        //Act
        var result = sut.PartOne(input);

        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void PartTwoTest()
    {
        //Arrange
        var expected = "31";

        //Act
        var result = sut.PartTwo(input);

        //Assert
        Assert.Equal(expected, result);
    }
}