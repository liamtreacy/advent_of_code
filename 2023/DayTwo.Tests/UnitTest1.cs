namespace DayTwo.Tests;

public class UnitTest1
{
    [Fact]
    public void SplitStringIntoGame()
    {
        string s = "Game 21: 1 blue, 2 green, 3 red; 7 red, 8 green";

        var sut = new Transformer();

        var ret = sut.GetGame(s);
        var expected = new Game{Id = 21, Rounds = new Round[]{
            new Round{RedCubes = 3, GreenCubes = 2, BlueCubes = 1},
            new Round{RedCubes = 7, GreenCubes = 8}
        }};

        Assert.Equal(expected, ret);
    }

    [Fact]
    public void SplitRoundStringIntoRound()
    {
        string s = " 1 blue, 2 green, 3 red";
        var sut = new Transformer();

        var expected = new Round{RedCubes = 3, GreenCubes = 2, BlueCubes = 1};
        var ret = sut.ParseStrToRound(s);

        Assert.Equal(expected.RedCubes, ret.RedCubes);
        Assert.Equal(expected.GreenCubes, ret.GreenCubes);
        Assert.Equal(expected.BlueCubes, ret.BlueCubes);
    }

    [Fact]
    public void SplitRoundStringIntoRoundNoGreen()
    {
        string s = " 1 blue, 2 red";
        var sut = new Transformer();

        var expected = new Round{RedCubes = 2, BlueCubes = 1};
        var ret = sut.ParseStrToRound(s);

        Assert.Equal(expected.RedCubes, ret.RedCubes);
        Assert.Equal(expected.GreenCubes, ret.GreenCubes);
        Assert.Equal(expected.BlueCubes, ret.BlueCubes);
    }

    [Fact]
    public void SplitLineIntoRoundStrings()
    {
        string s = "Game 1: 1 blue, 2 green, 3 red; 7 red, 8 green; 1 green, 2 red, 1 blue; 2 green, 3 red, 1 blue; 8 green, 1 blue";

        var sut = new Transformer();
        var ret = sut.GetRoundStrings(s);
        string[] expected = {   " 1 blue, 2 green, 3 red",
                                " 7 red, 8 green",
                                " 1 green, 2 red, 1 blue",
                                " 2 green, 3 red, 1 blue",
                                " 8 green, 1 blue"
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