namespace DayFifteen;
public class Class1
{

}


public class MyStringHelper
{
    public int GetAsciiCode(char c, int currValue)
    {
        return currValue + (int)c;
    }

    public int MultiplyAsciiCode(char c, int currValue)
    {
        return 17 * GetAsciiCode(c, currValue);
    }

    public int GetHashForChar(char c, int currValue)
    {
        int t = MultiplyAsciiCode(c, currValue);
        return t % 256;
    }

    public int GetHashForString(string s)
    {
        int currValue  = 0;
        foreach(char c in s)
        {
            currValue = GetHashForChar(c, currValue);
        }
        return currValue;
    }

    public int GetHasSumForCommaSeperatedString(string s)
    {
        string[] words = s.Split(',');

        int currValue = 0;

        foreach(var word in words)
        {
            currValue += GetHashForString(word);
        }

        return currValue;
    }
}
