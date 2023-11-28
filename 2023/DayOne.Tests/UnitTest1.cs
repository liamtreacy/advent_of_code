namespace DayOne.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var v = new DayOne();
        Assert.True(v.DoStuff(), "It should return true");
    }
}