namespace DayOne;

using System.IO;

public class CalibrationCalculator
{
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
/*
    public int ReadFileAndSumCalibrationValues(string fileName)
    {
        string line;
        int ret = -1;
        int first = -1;
        int last = -1;
        string firstLastNumStr = "";

        try
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/" + fileName);

            line = sr.ReadLine();
            while (line != null)
            {
                GetFirstAndLastDigits(line, out first, out last);
                firstLastNumStr += first.ToString();
                firstLastNumStr += last.ToString();

                Console.WriteLine($"\n\n{firstLastNumStr}\n");


                ret = ret + int.Parse(firstLastNumStr);
                Console.WriteLine($"ret == {ret}\n");
                firstLastNumStr = "";

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
    */
}