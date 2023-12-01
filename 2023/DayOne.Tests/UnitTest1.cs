namespace DayOne.Tests;

public class UnitTest1
{
    [Fact]
    public void FindFirstDigitStringWithNoNumbersReturnsMinusOne()
    {
        var sut = new CalibrationCalculator();

        var s = "aa";

        int first, last = -1;
        sut.GetFirstAndLastDigits(s, out first, out last);
        Assert.Equal(-1, first);
        Assert.Equal(-1, last);
    }

    [Fact]
    public void FindFirstDigitStringWithOneNumber()
    {
        var sut = new CalibrationCalculator();

        var s = "5";

        int first, last = -1;
        sut.GetFirstAndLastDigits(s, out first, out last);
        Assert.Equal(5, first);
        Assert.Equal(5, last);
    }

    
    [Fact]
    public void FindFirstDigitStringWithOneNumberAndLetters()
    {
        var sut = new CalibrationCalculator();

        var s = "abc8d6e7f";

        int first, last = -1;
        sut.GetFirstAndLastDigits(s, out first, out last);
        Assert.Equal(8, first);
        Assert.Equal(7, last);
    }
}