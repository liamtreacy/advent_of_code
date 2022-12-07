using NUnit.Framework;

namespace aoc_2022;

[TestFixture]
public class DayFourTest
{
    class Elf
    {
        public int[] r;

        public Elf()
        {
            r = new int[2];
        }
    }

    class ElvesPair
    {
        public Elf elf1 { get; set; }
        public Elf elf2 { get; set; }
    }
    
    // 22-77,14-96
    ElvesPair ParseInput(String s)
    {
        var eff = new ElvesPair();
        var t = s.Split(',');

        // first
        var first = t[0].Split('-');

        eff.elf1 = new Elf();
        eff.elf1.r[0] = Int32.Parse(first[0]);
        eff.elf1.r[1] = Int32.Parse(first[1]);

        // second
        
        var second = t[1].Split('-');

        eff.elf2 = new Elf();
        eff.elf2.r[0] = Int32.Parse(second[0]);
        eff.elf2.r[1] = Int32.Parse(second[1]);

        return eff;
    }

    bool ContainsSubSection(ElvesPair p)
    {
        return (p.elf1.r[0] <= p.elf2.r[0]) && (p.elf1.r[1] >= p.elf2.r[1]) ||
               (p.elf2.r[0] <= p.elf1.r[0]) && (p.elf2.r[1] >= p.elf1.r[1]);
    }



    [Test]
    public void Elf_Section_Doesnt_Contains_The_Other()
    {
        var s = "2-6,7-9";
        var f = ParseInput(s);

        Assert.That(ContainsSubSection(f), Is.EqualTo(false));
    }
    
    [Test]
    public void Elf_Section_Does_Contains_The_Other()
    {
        var s = "2-10,4-7";
        var f = ParseInput(s);

        Assert.That(ContainsSubSection(f), Is.EqualTo(true));
    }
    
    [Test]
    public void Elf_Section_Does_Contains_The_Other_Two()
    {
        var s = "10-15,9-16";
        var f = ParseInput(s);

        Assert.That(ContainsSubSection(f), Is.EqualTo(true));
    }
}