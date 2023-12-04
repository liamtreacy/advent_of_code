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

        var ret = sut.ReadFileAndSumCalibrationValuesPartOne(fileName);

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

    [Fact]
    public void TestGetFirstNumberEightAsStringFromSpelledOut()
    {
        var sut = new CalibrationCalculator();

        var s = "abcdeightonesevenf78threedzvlm1";

        Assert.Equal("one", sut.GetFirstNumberFromSpelledOut(s));
    }

    [Fact]
    public void TestGetFirstNumberFromSpelledOutIndexNoNumer()
    {
        var sut = new CalibrationCalculator();

        var s = "abcdef";
        
        Assert.Equal(-1, sut.GetFirstNumberFromSpelledOutIndex(s));
    }

    [Fact]
    public void TestGetFirstNumberFromSpelledOutIndexEight()
    {
        var sut = new CalibrationCalculator();

        var s = "aeightabcdef";
        
        Assert.Equal(1, sut.GetFirstNumberFromSpelledOutIndex(s));
    }

    [Fact]
    public void TestGetLastNumberFromSpelledOutIndexNoNumber()
    {
        var sut = new CalibrationCalculator();

        var s = "aeitabcdef";
        
        Assert.Equal(-1, sut.GetLastNumberFromSpelledOutIndex(s));
    }

    [Fact]
    public void TestGetLastNumberFromSpelledOutIndexSeven()
    {
        var sut = new CalibrationCalculator();

        var s = "aeightaonebcdsevenef";
        
        Assert.Equal(13, sut.GetLastNumberFromSpelledOutIndex(s));
    }

    [Fact]
    public void TestGetFirstNumberFromDigitIndexNoNumber()
    {
        var sut = new CalibrationCalculator();

        var s = "aeightaonebcdsevenef";
        
        Assert.Equal(-1, sut.GetFirstNumberFromDigitIndex(s));
    }

    [Fact]
    public void TestGetFirstNumberFromDigitIndexNine()
    {
        var sut = new CalibrationCalculator();

        var s = "ae9ighta6oneb7cdseven8ef";
        
        Assert.Equal(2, sut.GetFirstNumberFromDigitIndex(s));
    }

    [Fact]
    public void TestGetLastNumberFromDigitIndexNoNumber()
    {
        var sut = new CalibrationCalculator();

        var s = "aeightaonebcdsevenef";
        
        Assert.Equal(-1, sut.GetLastNumberFromDigitIndex(s));
    }

    [Fact]
    public void TestGetLastNumberFromDigitIndexNine()
    {
        var sut = new CalibrationCalculator();

        var s = "ae9ighta6oneb7cdseven8e7f";
        
        Assert.Equal(23, sut.GetLastNumberFromDigitIndex(s));
    }

    [Fact]
    public void TestGetTwoDigitNumberFromStringPartTwoOnlyDigits()
    {
        var sut = new CalibrationCalculator();

        var s = "12";
        
        Assert.Equal(12, sut.GetTwoDigitNumberFromStringPartTwo(s));
    }

    [Fact]
    public void TestGetTwoDigitNumberFromStringPartTwoOnlySpelledNumbers()
    {
        var sut = new CalibrationCalculator();

        var s = "threesix";
        
        Assert.Equal(36, sut.GetTwoDigitNumberFromStringPartTwo(s));
    }
/*
    [Fact]
    public void TestGetTwoDigitNumberFromStringPartTwoMix()
    {
        var sut = new CalibrationCalculator();

        var s = "three4";
        
        Assert.Equal(34, sut.GetTwoDigitNumberFromStringPartTwo(s));
    }

    [Fact]
    public void TestGetTwoDigitNumberFromStringPartTwoMixOthers()
    {
        var sut = new CalibrationCalculator();

        var s = "onethree45";
        
        Assert.Equal(15, sut.GetTwoDigitNumberFromStringPartTwo(s));
    }
    */
}