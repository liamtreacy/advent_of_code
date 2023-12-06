namespace DayFour.Tests;

public class UnitTest1
{
    [Fact]
    public void LineTest()
    {
        string input = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
        int expected = 0;

        var sut = new CardCalculator();
        var ret = sut.DoStuff(input);

        //Assert.Equal(expected, ret);
    }

    [Fact]
    public void SplitLineTest()
    {
        string input = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
        var sut = new CardCalculator();
        int[] winningNos;
        int[] playerNos;

        int[] expectedWinningNos = {41, 48, 83, 86, 17};
        int[] expectedPlayNos = {83, 86,  6, 31, 17,  9, 48, 53};

        sut.SplitLine(in input, out winningNos, out playerNos);

        Assert.Equal(expectedWinningNos, winningNos);
        Assert.Equal(expectedPlayNos, playerNos);
    }

    [Fact]
    public void FindNoWinningEntriesTest()
    {
        string input = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
        var sut = new CardCalculator();
        int[] winningNos;
        int[] playerNos;

        sut.SplitLine(in input, out winningNos, out playerNos);

        var ret = sut.GetNumMatches(winningNos, playerNos);

        Assert.Equal(4, ret);
    }
}