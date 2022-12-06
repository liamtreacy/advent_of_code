namespace aoc_2022;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    class Elf
    {
        public int Calories { get; set; }
    }

    List<Elf> ParseStringForElves(String s)
    {
        return null;
    }

    [Test]
    public void Parse_Input()
    {
        var input = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n" +
                    "8000\n9000\n\n10000";

        var elves = ParseStringForElves(input);
        Assert.Equals(elves[0].Calories, 6000);
    }
}