namespace DayFour.Tests;

public class UnitTest1
{
    [Fact]
    public void LineTest()
    {
        string input = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
        int expected = 0;

        var sut = new CardCalculator();
        sut.DoStuff(input);
        var ret = sut.DoStuff(input);

        Assert.Equal(expected, ret);
    }
}