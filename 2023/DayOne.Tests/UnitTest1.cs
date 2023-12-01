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
}