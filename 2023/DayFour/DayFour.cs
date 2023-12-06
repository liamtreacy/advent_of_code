namespace DayFour;
public class CardCalculator
{
    public int DoStuff(string s)
    {
        return -1;
    }

    public void SplitLine(in string input, out int[] winningNos, out int[] playerNos)
    {
        string[] parts = input.Split(new char[] { ':', '|' }, StringSplitOptions.RemoveEmptyEntries);

        winningNos = new int[5];
        int count = 0;

        // Generate winning array
        string[] winningParts = parts[1].Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

        foreach(var c in winningParts)
        {
            winningNos[count] = int.Parse(c);
            count++;
        }

        
        playerNos = new int[8];
        count = 0;
        // Generate player array
        string[] playerParts = parts[2].Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

        foreach(var c in playerParts)
        {
            playerNos[count] = int.Parse(c);
            count++;
        }
    }
}
