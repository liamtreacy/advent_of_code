namespace DayTwo;
public class Class1
{

}

public class Transformer
{
    public string[] GetRoundStrings(string s)
    {
        int colonIdx = s.IndexOf(':');
        var roundsStr = s.Substring(colonIdx+1);

        return roundsStr.Split(';');;
    }

    public int GetGameId(string s)
    {
        int spaceIdx = s.IndexOf(' ');
        int colonIdx = s.IndexOf(':');
        var idStr = s.Substring(spaceIdx+1, colonIdx-(spaceIdx+1));

        return int.Parse(idStr);
    }
}
