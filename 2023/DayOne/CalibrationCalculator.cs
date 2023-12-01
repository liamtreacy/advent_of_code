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
}