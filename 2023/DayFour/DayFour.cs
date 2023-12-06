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

    public int GetNumMatches(int[] arrOne, int[] arrTwo)
    {
        Console.WriteLine($"===\narrOne = {arrOne.ToString()}\narrTwo == {arrTwo.ToString()}\n{arrOne.Intersect(arrTwo).Count()}\n");
        return arrOne.Intersect(arrTwo).Count();
    }

    public int WinningScore(int[] arrOne, int[] arrTwo)
    {
        int n = GetNumMatches(arrOne, arrTwo);

        if (n == 0)
            return 0;
        
        Console.WriteLine($"n == {n}\n{PowerOf(2, n-1)}");
        return PowerOf(2, n-1);
    }

    private int PowerOf(int number, int powerOf)
    {
        Console.WriteLine($"number == {number} , powerOf == { powerOf}\n");
        int res = 1;

        for(int i = 0; i < powerOf; i++)
        {
            res = res *2;
        }
        Console.WriteLine($"res == {res}\n");
        return res;
    }

    public int SolvePuzzle(string s)
    {
        int[] arrOne;
        int[] arrTwo;
        Console.WriteLine($"s={s}");
        SplitLine(in s, out arrOne, out arrTwo);
        Console.WriteLine("-----");

        return WinningScore(arrOne, arrTwo);
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

                Console.WriteLine($"ret == {ret}\n");

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
