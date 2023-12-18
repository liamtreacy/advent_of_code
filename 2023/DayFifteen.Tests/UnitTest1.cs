namespace DayFifteen.Tests;

public class UnitTest1
{
    [Fact]
    public void Test_GetAscii_Code_For_Character()
    {
        var sut = new MyStringHelper();

        Assert.Equal(102, sut.GetAsciiCode('f', 0));
        Assert.Equal(72, sut.GetAsciiCode('H', 0));
        Assert.Equal(104, sut.GetAsciiCode('f', 2));
    }

    [Fact]
    public void Test_MultiplyAsciiCode_For_Character()
    {
        var sut = new MyStringHelper();

        Assert.Equal(1224, sut.MultiplyAsciiCode('H', 0));
    }

    [Fact]
    public void Test_GetHashForChar()
    {
        var sut = new MyStringHelper();

        Assert.Equal(200, sut.GetHashForChar('H', 0));
        Assert.Equal(153, sut.GetHashForChar('A', 200));
    }

    [Fact]
    public void Test_GetHashForString()
    {
        var sut = new MyStringHelper();
        var s = "HASH";

        Assert.Equal(52, sut.GetHashForString(s));
    }
}