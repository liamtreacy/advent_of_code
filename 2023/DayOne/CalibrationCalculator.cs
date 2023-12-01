namespace DayOne;

public class CalibrationCalculator
{
    public int GetFirstDigit(string s)
    {
        string numStr = "";

        foreach(var c in s)
        {
            if(char.IsDigit(c))
                numStr += c;
        }

        if(numStr == "")
            return -1;

        return int.Parse(numStr[0].ToString());
    }

    public int GetLastDigit(string s)
    {
        string numStr = "";

        foreach(var c in s)
        {
            if(char.IsDigit(c))
                numStr += c;
        }

        if(numStr == "")
            return -1;

        return int.Parse(numStr[numStr.Length-1].ToString());
    }

    public void GetFirstAndLastDigits(in string s, out int first, out int last)
    {
        string numStr = "";

        foreach(var c in s)
        {
            if(char.IsDigit(c))
                numStr += c;
        }

        if(numStr == "")
        {
            first =-1;
            last = -1;
            return;
        }

        first = int.Parse(numStr[0].ToString());
        last = int.Parse(numStr[numStr.Length-1].ToString());
    }
}