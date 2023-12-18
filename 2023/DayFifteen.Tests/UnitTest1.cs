namespace DayFifteen.Tests;

public class UnitTest1
{
    [Fact]
    public void Test_GetAscii_Code_For_Character()
    {
        var sut = new MyStringHelper();

        Assert.Equal(102, sut.GetAsciiCode('f'));
        Assert.Equal(72, sut.GetAsciiCode('H'));
    }

    [Fact]
    public void Test_MultiplyAsciiCode_For_Character()
    {
        var sut = new MyStringHelper();

        Assert.Equal(1224, sut.MultiplyAsciiCode('H'));
    }
}