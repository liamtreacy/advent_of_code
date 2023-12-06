namespace DayFour;
public class CardCalculator
{
    private int[] GenerateArray(string[] strArr)
    {
        int[] generatedArray = new int[strArr.Length];
        int count = 0;

        foreach(var s in strArr)
        {
            generatedArray[count] = int.Parse(s);
            count++;
        }

        return generatedArray;
    }

    public void SplitLine(in string input, out int[] winningNos, out int[] playerNos)
    {
        string[] parts = input.Split(new char[] { ':', '|' }, StringSplitOptions.RemoveEmptyEntries);

        winningNos = GenerateArray(parts[1].Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries));
        playerNos = GenerateArray(parts[2].Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries));
    }

    public int GetNumMatches(int[] winningArr, int[] playerArr)
    {
        return winningArr.Intersect(playerArr).Count();
    }

    public int WinningScore(int[] winningArr, int[] playerArr)
    {
        int n = GetNumMatches(winningArr, playerArr);

        if (n == 0)
            return 0;
        
        return PowerOf(2, n-1);
    }

    private int PowerOf(int number, int powerOf)
    {
        int res = 1;

        for(int i = 0; i < powerOf; i++)
        {
            res = res *2;
        }

        return res;
    }

    public int SolvePuzzle(string s)
    {
        int[] winningNumArr;
        int[] playerNumArr;

        SplitLine(in s, out winningNumArr, out playerNumArr);

        return WinningScore(winningNumArr, playerNumArr);
    }

    public int DoDayFourPartOne()
    {
        string line;
        int ret = 0;

        try
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/" + "day_four_input");

            line = sr.ReadLine();
            while (line != null)
            {
                ret += SolvePuzzle(line);

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

        return ret;
    }
}
