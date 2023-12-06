﻿namespace DayFour;
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

    public int GetNumMatches(int[] arrOne, int[] arrTwo)
    {
        return arrOne.Intersect(arrTwo).Count();
    }

    public int WinningScore(int[] arrOne, int[] arrTwo)
    {
        int n = GetNumMatches(arrOne, arrTwo);

        if (n == 0)
            return 0;
        
        Console.WriteLine($"n == {n}\n");
        return PowerOf(2, n-1);
    }

    private int PowerOf(int number, int powerOf)
    {
        int result = number;
        for (int i = 2; i <= powerOf; i++)
            result *= number;
        return result;
    }
}