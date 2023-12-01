namespace DayOne.Tests;

public class UnitTest1
{
    [Fact]
    public void FindFirstDigitStringWithNoNumbersReturnsMinusOne()
    {
        var sut = new CalibrationCalculator();

        var s = "aa";

        string first, last;
        sut.GetFirstAndLastDigits(s, out first, out last);
        Assert.Equal("", first);
        Assert.Equal("", last);
    }

    [Fact]
    public void FindFirstDigitStringWithOneNumber()
    {
        var sut = new CalibrationCalculator();

        var s = "5";

        string first, last;
        sut.GetFirstAndLastDigits(s, out first, out last);
        Assert.Equal("5", first);
        Assert.Equal("5", last);
    }

    
    [Fact]
    public void FindFirstDigitStringWithOneNumberAndLetters()
    {
        var sut = new CalibrationCalculator();

        var s = "abc8d6e7f";

        string first, last;
        sut.GetFirstAndLastDigits(s, out first, out last);
        Assert.Equal("8", first);
        Assert.Equal("7", last);
    }
/*
    [Fact]
    public void doDayOnePartOne()
    {
        var fileName = "input_day_one_part_one.txt";

        var sut = new CalibrationCalculator();

        var ret = sut.ReadFileAndSumCalibrationValues(fileName);

        Assert.Equal(0, ret);
    }
    */
}