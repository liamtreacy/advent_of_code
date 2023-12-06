﻿namespace DayOne_AttemptTwo;

public class DayOneCalcultor
{
    private int GetFirstNumberFromDigitIndex(in string s)
    {
        return s.IndexOfAny("0123456789".ToCharArray());
    }

    private int GetLastNumberFromDigitIndex(in string s)
    {
       return s.LastIndexOfAny("0123456789".ToCharArray());
    }

    public int GetTwoDigitNumberFromString(string s)
    {
        string first = s[GetFirstNumberFromDigitIndex(s)].ToString();
        string last = s[GetLastNumberFromDigitIndex(s)].ToString();

        string twoDigitNum = first + last;

        return int.Parse(twoDigitNum);
    }

    public int DoDayOnePartOne()
    {
        string line;
        int ret = 0;

        try
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/" + "input_day_one_part_one.txt");

            line = sr.ReadLine();
            while (line != null)
            {
                ret += GetTwoDigitNumberFromString(line);

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


    public int DoDayOnePartTwo()
    {
        string line;
        int ret = 0;

        try
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/" + "input_day_one_part_one.txt");

            line = sr.ReadLine();
            while (line != null)
            {
                ret += GetTwoDigitNumberFromStringWithDigitAndNumberSpelledOut(line);

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
    public int GetTwoDigitNumberFromStringWithDigitAndNumberSpelledOut(string s)
    {
        int firstDigitIdx = GetFirstNumberFromDigitIndex(s);
        int lastDigitIdx = GetLastNumberFromDigitIndex(s);

        int firstSpelledNumberIdx = GetFirstNumberIdxFromSpelledOutIndex(s);
        int lastSpelledNumberIdx = GetLastNumberIdxFromSpelledOutIndex(s);

        string firstNum = "",  lastNum = "";

        if( firstDigitIdx >= 0 && firstDigitIdx < firstSpelledNumberIdx)
        {
            firstNum = s[GetFirstNumberFromDigitIndex(s)].ToString();
        }
        else
        {
            firstNum = ConvertToString(GetFirstSpelledOutNumber(s)).ToString();
        }

        if( lastDigitIdx >= 0 && lastDigitIdx > lastSpelledNumberIdx)
        {
            lastNum = s[GetLastNumberFromDigitIndex(s)].ToString();
        }
        else
        {
            lastNum = ConvertToString(GetLastSpelledOutNumber(s)).ToString();
        }

        
        Console.WriteLine($"s == {s}\nfirstDigitIdx == {firstDigitIdx}, firstSpelledNumberIdx == {firstSpelledNumberIdx}\nlastDigitIdx == {lastDigitIdx}, lastSpelledNumberIdx == {lastSpelledNumberIdx}\n");
        //Console.WriteLine($"ss == {ss}\n");

        if(firstNum == "-1")
            return int.Parse(lastNum);

        if(lastNum == "-1")
            return int.Parse(lastNum);


        string ss = firstNum + lastNum;
        return int.Parse(ss);
    }

    public int ConvertToString(string s)
    {
        switch(s)
        {
            case "zero": return 0;
            case "one": return 1;
            case "two": return 2;
            case "three": return 3;
            case "four": return 4;
            case "five": return 5;
            case "six": return 6;
            case "seven": return 7;
            case "eight": return 8;
            case "nine": return 9;
        }
        return -1;
    }

    public string GetFirstSpelledOutNumber(string s)
    {
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

        newDictionary.OrderBy(x => x.Value);

        return newDictionary.FirstOrDefault().Key;
    }

    public string GetLastSpelledOutNumber(string s)
    {
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

        newDictionary.OrderBy(x => x.Value);

        return newDictionary.LastOrDefault().Key;
    }

    public int GetFirstNumberIdxFromSpelledOutIndex(string s)
    {
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

        newDictionary.OrderBy(x => x.Value);

        return newDictionary.FirstOrDefault().Value;
    }

    public int GetLastNumberIdxFromSpelledOutIndex(string s)
    {
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

        newDictionary.OrderBy(x => x.Value);

        return newDictionary.LastOrDefault().Value;
    }
}