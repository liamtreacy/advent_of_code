namespace DayTwo.Tests;

public class UnitTest1
{
    [Fact]
    public void DoDayTwoPartTwoTest()
    {
        var c = new Class1();
        var ret = c.DoDayTwoPartTwo();

        Assert.Equal(70265, ret);
    }

    [Fact]
    public void DoDayTwoPartOneTest()
    {
        var c = new Class1();
        var ret = c.DoDayTwoPartOne();

        //Assert.Equal(2505, ret);
    }

    [Fact]
    public void TestGetSumOfIds()
    {
        string s = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
        int expectedSum = 8;

        var sut = new Transformer();
        var games = sut.ConvertStrToGames(s);
        var ret = sut.GetSumIdsPossibleGames(games, 12, 13, 14);

       Assert.Equal(expectedSum, ret);
    }

    [Fact]
    public void TestConvertStrToGames()
    {
        string s = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
        int expectedNumGames = 5;

        var sut = new Transformer();
        var ret = sut.ConvertStrToGames(s);

        Assert.Equal(expectedNumGames, ret.Count);
    }


    [Fact]
    public void SplitStringIntoGame()
    {
        string s = "Game 21: 1 blue, 2 green, 3 red; 7 red, 8 green";

        var sut = new Transformer();

        var ret = sut.GetGame(s);
        var expected = new Game{Id = 21, Rounds = new List<Round>{
            new Round{RedCubes = 3, GreenCubes = 2, BlueCubes = 1},
            new Round{RedCubes = 7, GreenCubes = 8}
        }};

        Assert.Equal(expected, ret);
    }

    [Fact]
    public void SplitRoundStringIntoRound_TwoDigits()
    {
        string s = " 1 blue, 20 green, 3 red";
        var sut = new Transformer();

        var expected = new Round{RedCubes = 3, GreenCubes = 20, BlueCubes = 1};
        var ret = sut.ParseStrToRound(s);

        Assert.Equal(expected.RedCubes, ret.RedCubes);
        Assert.Equal(expected.GreenCubes, ret.GreenCubes);
        Assert.Equal(expected.BlueCubes, ret.BlueCubes);
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