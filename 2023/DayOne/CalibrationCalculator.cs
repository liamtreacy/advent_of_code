namespace DayOne;

using System.Collections;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class CalibrationCalculator
{
    public int GetFirstNumberFromSpelledOutIndex(in string s)
    {
        var letterIndexMap = new Dictionary<string, int>();
        
        SortDictAndRemoveNegativeKeyValues(ref letterIndexMap, s);

        if (letterIndexMap.Count == 0)
            return -1;

        return letterIndexMap.FirstOrDefault().Value;
    }

    public int GetLastNumberFromSpelledOutIndex(in string s)
    {
        var letterIndexMap = new Dictionary<string, int>();

        SortDictAndRemoveNegativeKeyValues(ref letterIndexMap, in s);

        if (letterIndexMap.Count == 0)
            return -1;

        return letterIndexMap.LastOrDefault().Value;
    }

    public int GetFirstNumberFromDigitIndex(in string s)
    {
        return s.IndexOfAny("0123456789".ToCharArray());
    }

    public int GetLastNumberFromDigitIndex(in string s)
    {
       return s.LastIndexOfAny("0123456789".ToCharArray());
    }

    //

    public int GetTwoDigitNumberFromStringPartTwo(in string s)
    {
        // TODO
        int firstDigitIdx = GetFirstNumberFromDigitIndex(s);
        int firstNumberIdx = GetFirstNumberFromSpelledOutIndex(s);

        int lastDigitIdx = GetLastNumberFromDigitIndex(s);
        int lastNumberIdx = GetLastNumberFromSpelledOutIndex(s);

        string first = "", last = "", tmp = "";

        Console.WriteLine($"firstDigitIdx == {firstDigitIdx}\nfirstNumberIdx == {firstNumberIdx}\nlastDigitIdx == {lastDigitIdx}\nlastNumberIdx == {lastNumberIdx}");

        if( firstNumberIdx == -1 || (firstDigitIdx != -1 && firstDigitIdx < firstNumberIdx) )
        {
            // use it
            GetFirstAndLastDigits(s, out first, out tmp);
        }

        if( lastNumberIdx == -1 || (lastDigitIdx != -1 && lastDigitIdx < lastNumberIdx) )
        {
            // use it
            GetFirstAndLastDigits(s, out tmp, out last);
        }

        first = first + last;
        Console.WriteLine($" first == {first}");
        return int.Parse(first);
    }


    public int GetTwoDigitNumberFromString(in string s)
    {
        string first, last = "";

        GetFirstAndLastDigits(s, out first, out last);

        first += last;

        int ret;

         bool success = int.TryParse(first, out ret);
         if (success)
         {
            return ret;
         }
         else
         {
            return -1;
         }
    }

    private void SortDictAndRemoveNegativeKeyValues(ref Dictionary<string, int> letterIndexMap, in string s)
    {
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
    }

    public string GetFirstNumberFromSpelledOut(in string s)
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

    public void GetFirstAndLastDigits(in string s, out string first, out string last)
    {
        string numStr = "";

        foreach(var c in s)
        {
            if(char.IsDigit(c))
                numStr += c;
        }

        if(numStr == "")
        {
            first = "";
            last = "";
            return;
        }

        //Console.WriteLine($"\nnumStr == {numStr}\n");
        first = numStr[0].ToString();
        last = numStr[numStr.Length-1].ToString();
    }

    public int ReadFileAndSumCalibrationValuesPartOne(string fileName)
    {
        string line;
        int ret = 0;

        try
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/" + fileName);

            line = sr.ReadLine();
            while (line != null)
            {
                ret += GetTwoDigitNumberFromString(line);

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
                ret += GetTwoDigitNumberFromStringPartTwo(line);

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