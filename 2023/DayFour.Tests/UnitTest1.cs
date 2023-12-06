namespace DayFour.Tests;

public class UnitTest1
{
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
    public void FindNumWinningEntriesTest()
    {
        string input = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
        var sut = new CardCalculator();
        int[] winningNos;
        int[] playerNos;

        sut.SplitLine(in input, out winningNos, out playerNos);

        var ret = sut.GetNumMatches(winningNos, playerNos);

        Assert.Equal(4, ret);
    }


    [Fact]
    public void GetWinningScoreTest()
    {
        string input = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
        var sut = new CardCalculator();
        int[] winningNos;
        int[] playerNos;

        sut.SplitLine(in input, out winningNos, out playerNos);

        var ret = sut.WinningScore(winningNos, playerNos);

        Assert.Equal(8, ret);
    }

    [Fact]
    public void DoDayFourPartOne()
    {
        var sut = new CardCalculator();
        var ret = sut.DoDayFourPartOne();

        Assert.Equal(0, ret);
    }
}