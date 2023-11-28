using NUnit.Framework;

namespace aoc_2022;

[TestFixture]
public class DayThreeTest
{
    public (String, String) SplitCompartment(String s)
    {
        return (s.Substring(0,s.Length/2), s.Substring(s.Length / 2));
    }

    public char FindCommonType(String s1, String s2)
    {
        return s1.Intersect(s2).First();
    }

    public char FindCommonType(String s1, String s2, String s3)
    {
        var x = s1.Intersect(s2);

        foreach (var match in x)
        {
            if (s3.Contains(match))
                return match;
        }

        return ' ';
    }

    public int GetPriority(char c)
    {
        if (char.IsUpper(c))
        {
            return (int)c - 38;
        }
        else
        {
            return (int)c - 96;
        }
    }

    [Test]
    public void Day_Three_Part_Two_For_Real()
    {
        // Get input
        var input_strings = File.ReadAllLines(
            $"/Users/liam.treacy/Dev/advent_of_code/aoc_2022/aoc_2022/" +
            $"DayThreeInput.txt");

        int sum = 0;
        for (int i = 0; i < input_strings.Length; i += 3)
        {
            var (s1, s2, s3) = (input_strings[i], input_strings[i + 1],
                input_strings[i + 2]);
            
            Console.WriteLine(input_strings[i + 2]);

            var t = FindCommonType(s1, s2, s3);
            sum += GetPriority(t);
        }
        Assert.That(sum, Is.EqualTo(2644));
    }

    [Test]
    public void Day_Three_Part_One_For_Real()
    {
        // Get input
        var input_strings = File.ReadAllLines(
            $"/Users/liam.treacy/Dev/advent_of_code/aoc_2022/aoc_2022/" +
            $"DayThreeInput.txt");

        int sum = 0;

        foreach (var inputString in input_strings)
        {
            var (s1, s2) = SplitCompartment(inputString);
            var t = FindCommonType(s1, s2);
            sum += GetPriority(t);
        }
        
        Assert.That(sum, Is.EqualTo(7701));
    }

    [Test]
    public void Split_Compartment_Test()
    {
        var s = "vJrwpWtwJgWrhcsFMMfFFhFp";

        var (t1, t2) = SplitCompartment(s);
        
        Assert.That(t1, Is.EqualTo("vJrwpWtwJgWr"));
        Assert.That(t2, Is.EqualTo("hcsFMMfFFhFp"));
        
        Assert.That(FindCommonType(t1,t2), Is.EqualTo('p'));
    }

    [Test]
    public void Priority_Lower_Test()
    {
        Assert.That(GetPriority('a'), Is.EqualTo(1));
        Assert.That(GetPriority('z'), Is.EqualTo(26));
        Assert.That(GetPriority('Z'), Is.EqualTo(52));
        Assert.That(GetPriority('A'), Is.EqualTo(27));
    }
}