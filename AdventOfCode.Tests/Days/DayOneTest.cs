using AdventOfCode.Logic.Common;
using AdventOfCode.Logic.Days;

namespace AdventOfCode.Tests.Days;

public class DayOneTest
{
    private readonly string[] input = FileReader.Read("Day01-Sample.txt");

    [Fact]
    public void PartOneTest()
    {
        //Arrange
        var expected = "11";
        var sut = new DayOne();

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
        var sut = new DayOne();

        //Act
        var result = sut.PartTwo(input);

        //Assert
        Assert.Equal(expected, result);
    }
}