namespace DayOne;

public class CalibrationCalculator
{
    public int GetFirstDigit(string s)
    {
        var numStr = new string(s.TakeWhile(char.IsDigit).ToArray());

        if(numStr == "")
            return -1;

        return int.Parse(numStr[0].ToString());
    }
}