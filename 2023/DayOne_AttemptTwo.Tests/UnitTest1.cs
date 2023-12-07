namespace DayOne_AttemptTwo.Tests;

public class UnitTest1
{
    [Fact]
    public void MorefailingTests()
    {
        // 83 and 79
        string[] arr = {"eighthree", "sevenine"};

        int expected = 162;

        var sut = new DayOneCalcultor();

        int sum = 0;

        foreach(var v in arr)
        {
            var t = sut.GetTwoDigitNumberFromStringWithDigitAndNumberSpelledOut(v);
            sum+=t;
        }



        Assert.Equal(expected, sum);
    }
    /*
    [Fact]
    public void DoDayOnePartTwo()
    {
        int expected = 0;

        var sut = new Solver();

        var ret = sut.SolveDayOnePartTwo();

        Assert.Equal(expected, ret);
    }

    /*
    [Fact]
    public void TestAnotherFailFromInput()
    {
        string s = "four2tszbgmxpbvninebxns6nineqbqzgjpmpqr";

        var sut = new DayOneCalcultor();
        var t = sut.GetTwoDigitNumberFromStringWithDigitAndNumberSpelledOut(s);

        Assert.Equal(49, t);
    }
    
    [Fact]
    public void TestFromInputGivenExample()
    {
        // 97
        // 49
        // 92
        // 47
        // 2
        //
        // sum = 287
        string[] input = {"kjrqmzv9mmtxhgvsevenhvq7",
        "four2tszbgmxpbvninebxns6nineqbqzgjpmpqr",
        "rkzlnmzgnk91zckqprrptnthreefourtwo",
        "fouronevzkbnzm6seven47",
        "zphgdcznqsm2"
        };
        int expected = 287;

        var sut = new DayOneCalcultor();

        int sum = 0;

        foreach(var v in input)
        {
            var t = sut.GetTwoDigitNumberFromStringWithDigitAndNumberSpelledOut(v);
            sum+=t;
        }



        Assert.Equal(expected, sum);
    }

    
    [Fact]
    public void TestFromFailingInput()
    {
        string s = "rkzlnmzgnk91zckqprrptnthreefourtwo";
        var sut = new DayOneCalcultor();
        int expected = 92;

        var ret = sut.GetTwoDigitNumberFromStringWithDigitAndNumberSpelledOut(s);

        Assert.Equal(expected, ret);
    }
    
    [Fact]
    public void FindDigitsInString()
    {
        var sut = new DayOneCalcultor();

        var s = "abc8d6e7f";

        var ret = sut.GetTwoDigitNumberFromString(s);

        Assert.Equal(87, ret);
    }

    [Fact]
    public void DoDayOnePartOne()
    {
        var sut = new DayOneCalcultor();

        var ret = sut.DoDayOnePartOne();

        Assert.Equal(55447, ret);
    }



    [Fact]
    public void TestFromInputFile()
    {
        string input = "dfdf1threehd7nine";
        int expected = 19;

        var sut = new DayOneCalcultor();

        var ret = sut.GetTwoDigitNumberFromStringWithDigitAndNumberSpelledOut(input);

        Assert.Equal(expected, ret);
    }
    */
}