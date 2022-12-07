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
        return ((p.elf1.r[0] <= p.elf2.r[0]) && (p.elf1.r[1] >= p.elf2.r[1])) ||
               ((p.elf2.r[0] <= p.elf1.r[0]) && (p.elf2.r[1] >= p.elf1.r[1]));
    }

    bool OverlapSection(ElvesPair p)
    {
        var firstElf = p.elf1;
        var secElf = p.elf2;

        var sec_one_start_pos = firstElf.r[0];
        var sec_one_end_pos = firstElf.r[1];
        
        var sec_two_start_pos = secElf.r[0];
        var sec_two_end_pos = secElf.r[1];
        
        /*
         *  i)
         *      2,3,4,5
         *          4,5,6
         *
         *      sec_one_start_pos = 2
         *      sec_one_end_pos = 5
         *
         *      sec_two_start_pos = 4
         *      sec_two_end_pos = 6
         *
         *      if ( ( sec_two_start_pos <= sec_one_end_pos) &&
         *              ( sec_two_start_pos >= sec_one_start_pos) )
         * 
         *  ii)
         *          6,7,8
         *      4,5,6,7
         *
         *      sec_one_start_pos = 6
         *      sec_one_end_pos = 8
         *
         *      sec_two_start_pos = 4
         *      sec_two_end_pos = 7
         *
         *      if( ( sec_one_start_pos >= sec_two_start_pos) &&
         *          ( sec_one_start_pos <= sec_two_end_pos) )
         */


        if ((sec_two_start_pos <= sec_one_end_pos) &&
            (sec_two_start_pos >= sec_one_start_pos))
        {
            return true;
        }

        if ((sec_one_start_pos >= sec_two_start_pos) &&
            (sec_one_start_pos <= sec_two_end_pos))
        {
            return true;
        }

        return false;
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

    [Test]
    public void Day_Four_Part_One_For_Real()
    {
        // get input
        var input_strings = File.ReadAllLines(
            $"/Users/liam.treacy/Dev/advent_of_code/aoc_2022/aoc_2022/" +
            $"DayFourInput.txt");

        var l = new List<ElvesPair>();

        int number_pairs_contained = 0;

        foreach (var inputString in input_strings)
        {
            if (ContainsSubSection(ParseInput(inputString)))
                number_pairs_contained++;
        }
        
        Assert.That(number_pairs_contained, Is.EqualTo(532));
    }
    
    
    [Test]
    public void Day_Four_Part_Two_For_Real()
    {
        // get input
        var input_strings = File.ReadAllLines(
            $"/Users/liam.treacy/Dev/advent_of_code/aoc_2022/aoc_2022/" +
            $"DayFourInput.txt");

        var l = new List<ElvesPair>();

        int number_pairs_overlapped = 0;

        foreach (var inputString in input_strings)
        {
            if (OverlapSection(ParseInput(inputString)))
                number_pairs_overlapped++;
        }
        
        Assert.That(number_pairs_overlapped, Is.EqualTo(854));
    }
}