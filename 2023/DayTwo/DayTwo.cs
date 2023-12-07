namespace DayTwo;
public class Class1
{

}

public class Transformer
{
    public int GetGameId(string s)
    {
        // find first space
        int spaceIdx = s.IndexOf(' ');
        // find first :
        int colonIdx = s.IndexOf(':');
        // Id between them
        var idStr = s.Substring(spaceIdx+1, colonIdx-(spaceIdx+1));

        return int.Parse(idStr);
    }
}
