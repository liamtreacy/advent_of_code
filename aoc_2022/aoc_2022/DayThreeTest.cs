using NUnit.Framework;

namespace aoc_2022;

[TestFixture]
public class DayThreeTest
{
    public (String, String) SplitCompartment(String s)
    {
        return (s.Substring(0,s.Length/2), s.Substring(s.Length / 2));
    }
    
    [Test]
    public void Split_Compartment_Test()
    {
        var s = "vJrwpWtwJgWrhcsFMMfFFhFp";

        var (t1, t2) = SplitCompartment(s);
        
        Assert.That(t1, Is.EqualTo("vJrwpWtwJgWr"));
        Assert.That(t2, Is.EqualTo("hcsFMMfFFhFp"));
    }
}