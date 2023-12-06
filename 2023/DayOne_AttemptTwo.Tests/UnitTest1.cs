namespace DayOne_AttemptTwo.Tests;

public class UnitTest1
{
    [Fact]
    public void FindDigitsInString()
    {
        var sut = new DayOneCalcultor();

        var s = "abc8d6e7f";

        var ret = sut.GetTwoDigitNumberFromString(s);

        Assert.Equal(87, ret);
    }

    [Fact]
    public void DoDayOnePartOne()
    {
        var sut = new DayOneCalcultor();

        var ret = sut.DoDayOnePartOne();

        Assert.Equal(55447, ret);
    }

    [Fact]
    public void TestFromInputFile()
    {
        string input = "dfdf1threehd7nine";
        int expected = 19;

        var sut = new DayOneCalcultor();

        var ret = sut.GetTwoDigitNumberFromStringWithDigitAndNumberSpelledOut(input);

        Assert.Equal(expected, ret);
    }
/*
    [Fact]
    public void DoDayOnePartTwo()
    {
        string input = "dfdf1threehd7nine";
        int expected = 19;

        var sut = new DayOneCalcultor();

        var ret = sut.DoDayOnePartTwo();

        Assert.Equal(expected, ret);
    }
    */
}