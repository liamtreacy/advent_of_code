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