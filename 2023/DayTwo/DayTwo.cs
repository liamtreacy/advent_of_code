namespace DayTwo;
public class Class1
{
    public int DoDayTwoPartOne()
    {
        var transformer = new Transformer();
        string line;
        int ret = 0;
        var games = new List<Game>();

        try
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/" + "day_two_input");

            line = sr.ReadLine();
            while (line != null)
            {
                games.Add(transformer.GetGame(line));

                line = sr.ReadLine();
            }
            sr.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }


        return transformer.GetSumIdsPossibleGames(games, 12, 13, 14);
    }

    public int DoDayTwoPartTwo()
    {
        var transformer = new Transformer();
        string line;
        int ret = 0;
        var games = new List<Game>();

        try
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/" + "day_two_input");

            line = sr.ReadLine();
            while (line != null)
            {
                games.Add(transformer.GetGame(line));

                line = sr.ReadLine();
            }
            sr.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

        // Get input


        return transformer.GetPowerOfGames(games);
    }
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
    public int GetPowerOfGames(List<Game> games)
    {
        int sum = 0;

        foreach(var game in games)
        {
            int maxR = 0;
            int maxG = 0;
            int maxB = 0;
            int pow = 1;

            foreach(var round in game.Rounds)
            {
                if( round.RedCubes > maxR)
                    maxR = round.RedCubes;
                if( round.GreenCubes > maxG)
                    maxG = round.GreenCubes;
                if( round.BlueCubes > maxB)
                    maxB = round.BlueCubes;
            }

            pow = maxR != 0 ? ( pow * maxR ) : pow;
            pow = maxG != 0 ? ( pow * maxG ) : pow;
            pow = maxB != 0 ? ( pow * maxB ) : pow;

            sum += pow;
        }


        return sum;
    }

    public int GetSumIdsPossibleGames(List<Game> games, int maxRed, int maxGreen, int maxBlue)
    {
        int sum = 0;
        bool addId = true;

        foreach(var game in games)
        {
            addId = true;

            foreach(var round in game.Rounds)
            {
                Console.WriteLine($"Round = {round.RedCubes}, {round.GreenCubes}, {round.BlueCubes}\nMax =   {maxRed}, {maxGreen}, {maxBlue}");
                if(round.RedCubes > maxRed || round.GreenCubes > maxGreen || round.BlueCubes > maxBlue)
                {
                    addId = false;
                    break;
                }
            }

            if(addId)
            {
                Console.WriteLine($"Adding gameId: {game.Id}\n");
                sum += game.Id;
            }
        }

        return sum;
    }

    public List<Game> ConvertStrToGames(string s)
    {
        string[] lines = s.Split('\n');
        var games = new List<Game>();

        foreach(var l in lines)
        {
            games.Add(GetGame(l));
        }

        return games;
    }

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

    private int GetIntFomSubstring(string s)
    {
        s = s.Trim();
        var spaceIdx = s.IndexOf(' ');

        return int.Parse(s.Substring(0,spaceIdx));
    }

    public Round ParseStrToRound(string s)
    {
        var parts = s.Split(',');
        var ret = new Round();

        foreach(var v in parts)
        {
            if(v.Contains("red"))
            {
                ret.RedCubes = GetIntFomSubstring(v);
            }
            else if(v.Contains("green"))
            {
                ret.GreenCubes= GetIntFomSubstring(v);
            }
            else if(v.Contains("blue"))
            {
                ret.BlueCubes = GetIntFomSubstring(v);
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
