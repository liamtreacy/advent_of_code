namespace DayFour;
public class CardCalculator
{
    public int DoStuff(string s)
    {
        return -1;
    }

    private int[] GenerateArray(int sizeArr, string[] strArr)
    {
        int[] generatedArray = new int[sizeArr];
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

        winningNos = GenerateArray(5, parts[1].Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries));

        
        playerNos = GenerateArray(8, parts[2].Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries));
    }
}
