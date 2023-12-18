namespace DayFifteen;
public class Class1
{

}


public class MyStringHelper
{
    public int GetAsciiCode(char c)
    {
        return (int)c;
    }

    public int MultiplyAsciiCode(char c)
    {
        return 17 * GetAsciiCode(c);
    }

    public int GetHashForChar(char c)
    {
        int t = MultiplyAsciiCode(c);
        return t % 256;
    }
}
