namespace DayTwo.Tests;

public class UnitTest1
{
    [Fact]
    public void SplitLineIntoRoundStrings()
    {
        string s = "Game 1: 1 blue, 2 green, 3 red; 7 red, 8 green; 1 green, 2 red, 1 blue; 2 green, 3 red, 1 blue; 8 green, 1 blue";

        var sut = new Transformer();
        var ret = sut.GetRoundStrings(s);
        string[] expected = {   "1 blue, 2 green, 3 red",
                                "7 red, 8 green",
                                "1 green, 2 red, 1 blue",
                                "2 green, 3 red, 1 blue",
                                "8 green, 1 blue"
                            };

        Assert.Equal(expected, ret);
    }

    [Fact]
    public void SplitLineIntoGame_Id()
    {
        string s = "Game 1: 1 blue, 2 green, 3 red; 7 red, 8 green; 1 green, 2 red, 1 blue; 2 green, 3 red, 1 blue; 8 green, 1 blue";

        var sut = new Transformer();
        var ret = sut.GetGameId(s);
        var expected = 1;

        Assert.Equal(expected, ret);
    }

    [Fact]
    public void SplitLineIntoGame_Id_TwoDigits()
    {
        string s = "Game 27: 2 green, 8 blue, 2 red; 1 blue, 1 red, 5 green; 3 green, 7 blue";

        var sut = new Transformer();
        var ret = sut.GetGameId(s);
        var expected = 27;

        Assert.Equal(expected, ret);
    }
}