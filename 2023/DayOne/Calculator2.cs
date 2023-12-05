namespace DayOne;

using System.Collections;
using System.IO;
using Microsoft.VisualBasic;

public class CalibrationCalculator2
{
    public int ReadFileAndSumCalibrationValuesPartTwo(string fileName)
    {
        string line;
        int ret = 0;

        try
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/" + fileName);

            line = sr.ReadLine();
            while (line != null)
            {
                ret += SolvePuzzle(line);

                //Console.WriteLine($"ret == {ret}\n");

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

    public int SolvePuzzle(string s)
    {
        var idxValueMap = GetNumbersAndIndexes(s);

        int first = idxValueMap.FirstOrDefault().Value;
        int last = idxValueMap.LastOrDefault().Value;

        string ss = first.ToString() + last.ToString();

        return int.Parse(ss);
    }

    public Dictionary<int,int> GetNumbersAndIndexes(string s)
    {
        var idxNumberMap = new Dictionary<int,int>();

        // Get spelled numbers and indexes
        var letterIndexMap = new Dictionary<string, int>();
        letterIndexMap["zero"] = -1;
        letterIndexMap["one"] = -1;
        letterIndexMap["two"] = -1;
        letterIndexMap["three"] = -1;
        letterIndexMap["four"] = -1;
        letterIndexMap["five"] = -1;
        letterIndexMap["six"] = -1;
        letterIndexMap["seven"] = -1;
        letterIndexMap["eight"] = -1;
        letterIndexMap["nine"] = -1;

        foreach(var li in letterIndexMap)
        {
            letterIndexMap[li.Key] = s.IndexOf(li.Key);
        }

        var newDictionary = letterIndexMap.Where(pair => pair.Value >= 0)
                                 .ToDictionary(pair => pair.Key,
                                               pair => pair.Value);


        letterIndexMap = newDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        foreach(var ss in letterIndexMap)
        {
            //Console.WriteLine($"{ss.Key} , {ss.Value}\n");
        }

        // Convert to numbers and indexes
        foreach(var letterIndex in letterIndexMap)
        {
            idxNumberMap.Add(letterIndex.Value, convertSpelledNumberToDigit(letterIndex.Key));
        }

        // Get all digits
        for(int i = 0; i < s.Length; i++)
        {
            if( Char.IsDigit(s[i]))
            {
                idxNumberMap.Add(i, (int)(s[i] - '0'));
            }
        }

        foreach(var ss in idxNumberMap)
        {
            Console.WriteLine($"{ss.Key} , {ss.Value}\n");
        }


        return idxNumberMap;
    }

    public int convertSpelledNumberToDigit(string s)
    {
        s = s.ToLower();
        switch(s)
        {
            case "zero":
                return 0;
            case "one":
                return 1;
            case "two":
                return 2;
            case "three":
                return 3;
            case "four":
                return 4;
            case "five":
                return 5;
            case "six":
                return 6;
            case "seven":
                return 7;
            case "eight":
                return 8;
            case "nine":
                return 9;
        }
        return -1;
    }
}