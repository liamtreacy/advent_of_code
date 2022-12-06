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
        string[] tokens = s.Split('\n');

        List<Elf> elves = new List<Elf>();
        int running_calorie_total = 0;

        foreach (var t in tokens)
        {
            if (!String.IsNullOrEmpty(t))
            {
                running_calorie_total += Int32.Parse(t);
            }
            else
            {
                elves.Add(new Elf{Calories = running_calorie_total});
                running_calorie_total = 0;
            }
        }

        return elves;
    }

    int GetPositonLargestCalorieCount(List<Elf> elves)
    {
        return elves.IndexOf(elves.OrderByDescending(
            i => i.Calories).First());
    }

    [Test]
    public void Parse_Input()
    {
        var input = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n" +
                    "8000\n9000\n\n10000";

        var elves = ParseStringForElves(input);
        Assert.That(6000, Is.EqualTo(elves[0].Calories));
    }

    [Test]
    public void Return_Elf_With_Most_Calories()
    {
        var elves = new List<Elf>();
        elves.Add(new Elf{Calories = 300});
        elves.Add(new Elf{Calories = 400});
        elves.Add(new Elf{Calories = 900});
        elves.Add(new Elf{Calories = 0});
        
        Assert.AreEqual(2, GetPositonLargestCalorieCount(elves));
    }
}