namespace DayOne_AttemptTwo;

public class Solver
{
    public int SolveDayOnePartTwo()
    {
        string line;
        int ret = 0;
        var calc = new DayOneCalcultor();

        try
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/" + "input_day_one_part_one.txt");

            line = sr.ReadLine();
            while (line != null)
            {
                var t = calc.GetTwoDigitNumberFromStringWithDigitAndNumberSpelledOut(line);

                Console.Write($"  t == {t}\n");

                ret += t;

                Console.Write($"  sum == {ret}\n\n");

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

    private (int, int) GetSpelledOutNumsIndexes(string s)
    {
        var letterIndexMap = new Dictionary<string, int>();
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

        //newDictionary.OrderByA(x => x.Value);
        newDictionary = newDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        int firstNumIdx = newDictionary.FirstOrDefault().Value;

        //

        var letterIndexMap2 = new Dictionary<string, int>();
        letterIndexMap2["one"] = -1;
        letterIndexMap2["two"] = -1;
        letterIndexMap2["three"] = -1;
        letterIndexMap2["four"] = -1;
        letterIndexMap2["five"] = -1;
        letterIndexMap2["six"] = -1;
        letterIndexMap2["seven"] = -1;
        letterIndexMap2["eight"] = -1;
        letterIndexMap2["nine"] = -1;

        foreach(var li in letterIndexMap2)
        {
            letterIndexMap2[li.Key] = s.LastIndexOf(li.Key);
        }

        var newDictionary2 = letterIndexMap2.Where(pair => pair.Value >= 0)
                                 .ToDictionary(pair => pair.Key,
                                               pair => pair.Value);

        newDictionary2 = newDictionary2.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        //Console.WriteLine("====\n");
        foreach(var v in newDictionary)
        {
            //Console.WriteLine($"{v.Key} , {v.Value}\n\n");
        }
        //Console.WriteLine("====\n");

       // return (newDictionary.FirstOrDefault().Value, newDictionary.LastOrDefault().Value);

        int lastNumIdx = newDictionary2.LastOrDefault().Value;
        return (firstNumIdx, lastNumIdx);
    }


    public int GetTwoDigitNumberFromStringWithDigitAndNumberSpelledOut(string s)
    {
        int firstDigitIdx = GetFirstNumberFromDigitIndex(s);
        int lastDigitIdx = GetLastNumberFromDigitIndex(s);

        int firstSpelledNumberIdx, lastSpelledNumberIdx;

        (firstSpelledNumberIdx, lastSpelledNumberIdx) = GetSpelledOutNumsIndexes(s);

        string firstNum = "",  lastNum = "";

        if( firstDigitIdx >= 0 && firstDigitIdx < firstSpelledNumberIdx)
        {
            firstNum = s[GetFirstNumberFromDigitIndex(s)].ToString();
        }
        else
        {
            firstNum = ConvertSpelledNumberToStringRepresentation(GetFirstSpelledOutNumber(s)).ToString();
        }

Console.WriteLine($"lastDigitIdx == {lastDigitIdx}\nlastSpelledNumberIdx == {lastSpelledNumberIdx}\n");
        if( lastDigitIdx >= 0 && lastDigitIdx > lastSpelledNumberIdx)
        {
            lastNum = s[GetLastNumberFromDigitIndex(s)].ToString();
        }
        else
        {
            lastNum = ConvertSpelledNumberToStringRepresentation(GetLastSpelledOutNumber(s)).ToString();
        }

        Console.WriteLine($"s == {s}\nfirstNum == {firstNum}\nlastNum == {lastNum}\n");

        if(firstNum == "-1")
            return int.Parse(lastNum);

        if(lastNum == "-1")
            return int.Parse(lastNum);

        string ss = firstNum + lastNum;
        return int.Parse(ss);
    }

    public int ConvertSpelledNumberToStringRepresentation(string s)
    {
        switch(s)
        {
            case "one":     return 1;
            case "two":     return 2;
            case "three":   return 3;
            case "four":    return 4;
            case "five":    return 5;
            case "six":     return 6;
            case "seven":   return 7;
            case "eight":   return 8;
            case "nine":    return 9;
        }
        return -1;
    }

    public string GetFirstSpelledOutNumber(string s)
    {
        var letterIndexMap = new Dictionary<string, int>();
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

        newDictionary = newDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        return newDictionary.FirstOrDefault().Key;
    }

    public string GetLastSpelledOutNumber(string s)
    {
        var letterIndexMap = new Dictionary<string, int>();
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

        newDictionary = newDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        return newDictionary.LastOrDefault().Key;
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
}
