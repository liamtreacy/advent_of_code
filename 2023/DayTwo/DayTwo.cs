namespace DayTwo;
public class Class1
{

}

public class Round
{
    public int RedCubes { get; set; } = 0;
    public int GreenCubes { get; set; } = 0;
    public int BlueCubes { get; set; } = 0;

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Round other = (Round)obj;
        return this.RedCubes == other.RedCubes && 
        this.GreenCubes == other.GreenCubes &&
        this.BlueCubes == other.BlueCubes;
    }
}

public class Game
{
    public int Id { get; set; }
    public List<Round> Rounds{ get; set;} = new List<Round>();
    public Game(string s)
    {}
    public Game()
    {}

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Game other = (Game)obj;
        return this.Id == other.Id && this.Rounds.SequenceEqual(other.Rounds);
    }
}

public class Transformer
{
    public Game GetGame(string s)
    {
        var ret = new Game();
        ret.Id = GetGameId(s);

        var roundStrs = GetRoundStrings(s);

        foreach(var v in roundStrs)
        {
            ret.Rounds.Add(ParseStrToRound(v));
        }
        return ret;
    }

    public Round ParseStrToRound(string s)
    {
        var parts = s.Split(',');
        var ret = new Round();

        foreach(var v in parts)
        {
            if(v.Contains("red"))
            {
                var idx = v.IndexOfAny("0123456789".ToCharArray());
                ret.RedCubes = v[idx] - '0';
            }
            else if(v.Contains("green"))
            {
                var idx = v.IndexOfAny("0123456789".ToCharArray());
                ret.GreenCubes = v[idx] - '0';
            }
            else if(v.Contains("blue"))
            {
                var idx = v.IndexOfAny("0123456789".ToCharArray());
                ret.BlueCubes = v[idx] - '0';
            }
        }

        return ret;
    }

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
