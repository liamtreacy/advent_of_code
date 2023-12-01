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

    [Fact]
    public void GetTwoDigitNumberFromString()
    {
        var sut = new CalibrationCalculator();

        var s = "abc1d6e7f";

        Assert.Equal(17, sut.GetTwoDigitNumberFromString(s));
    }

        [Fact]
    public void GetTwoDigitNumberFromLargerString()
    {
        var sut = new CalibrationCalculator();

        var s = "oodjdnm9abc1d6e7fhsdsdjhsdhjds8jjs77jhjj6";

        Assert.Equal(96, sut.GetTwoDigitNumberFromString(s));
    }


/*
    [Fact]
    public void DoDayOnePartOne()
    {
        var fileName = "input_day_one_part_one.txt";

        var sut = new CalibrationCalculator();

        var ret = sut.ReadFileAndSumCalibrationValues(fileName);

        Assert.Equal(55447, ret);
    }
    */

    [Fact]
    public void TestGetFirstNumberAsStringFromSpelledOut()
    {
        var sut = new CalibrationCalculator();

        var s = "onesevenf78threedzvlm1";

        Assert.Equal("one", sut.GetFirstNumberFromSpelledOut(s));
    }
}