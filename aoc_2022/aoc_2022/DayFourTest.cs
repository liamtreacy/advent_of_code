using NUnit.Framework;

namespace aoc_2022;

[TestFixture]
public class DayFourTest
{
    class Elf
    {
        public Range Section { get; set; }
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

        eff.elf1 = new Elf
        {
            Section = new Range(Int32.Parse(first[0]), Int32.Parse(first[1]))
        };



        // second

    return eff;
    }

    [Test]
    public void Parse_Input_Test()
    {
        var s = "2-7,4-9";

        var f = ParseInput(s);
        
        Assert.That(f.elf1.Section, Is.EqualTo(new Range(2,7)));
        //Assert.That(f.elf2.Section, Is.EqualTo(new Range(4,9)));
    }
}