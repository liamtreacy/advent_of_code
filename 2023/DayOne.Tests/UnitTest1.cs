namespace DayOne.Tests;

public class UnitTest1
{
    [Fact]
    public void FindFirstDigitStringWithNoNumbersReturnsMinusOne()
    {
        var sut = new CalibrationCalculator();

        var s = "aa";
        Assert.Equal(-1, sut.GetFirstDigit(s));
    }

    [Fact]
    public void FindFirstDigitStringWithOneNumber()
    {
        var sut = new CalibrationCalculator();

        var s = "5";
        //Console.WriteLine($"\n=====\n{sut.GetFirstDigit(s)}\n=====\n");
        Assert.Equal(5, sut.GetFirstDigit(s));
    }

    
    [Fact]
    public void FindFirstDigitStringWithOneNumberAndLetters()
    {
        var sut = new CalibrationCalculator();

        var s = "abc8def";

        Assert.Equal(8, sut.GetFirstDigit(s));
    }

        [Fact]
    public void FindLastDigitStringWithNoNumbersReturnsMinusOne()
    {
        var sut = new CalibrationCalculator();

        var s = "aa";
        Assert.Equal(-1, sut.GetLastDigit(s));
    }

    [Fact]
    public void FindLastDigitStringWithOneNumber()
    {
        var sut = new CalibrationCalculator();

        var s = "456";
  
        Assert.Equal(6, sut.GetLastDigit(s));
    }

    
    [Fact]
    public void FindLastDigitStringWithOneNumberAndLetters()
    {
        var sut = new CalibrationCalculator();

        var s = "abc8de9f";

        Assert.Equal(9, sut.GetLastDigit(s));
    }
}