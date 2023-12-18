namespace DayFifteen;
public class Class1
{
    public int Run()
    {
        string line;
        int ret = 0;

        try
        {
            var path = Directory.GetCurrentDirectory() + "/" + "day_15_input";
            string readText = File.ReadAllText(path);

            var Helper = new MyStringHelper();
            return Helper.GetHasSumForCommaSeperatedString(readText);

        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

        return ret;
    }
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
