namespace DayTwo.Tests;

public class UnitTest1
{
    [Fact]
    public void SplitLineIntoGame_Id()
    {
        string s = "Game 1: 1 blue, 2 green, 3 red; 7 red, 8 green; 1 green, 2 red, 1 blue; 2 green, 3 red, 1 blue; 8 green, 1 blue";

        var sut = new Transformer();
        var ret = sut.GetGameId(s);
        var expected = 1;

        Assert.Equal(expected, ret);
    }
}