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
    
    int CaloriesOfTopNElves(int n, List<Elf> elves)
    {
        var top_n = elves.OrderByDescending(t => t.Calories).Take(n);
        var total_calories = 0;

        foreach (var elf in top_n)
        {
            total_calories += elf.Calories;
        }

        return total_calories;
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

    [Test]
    public void Not_A_Unit_Test_But_The_Real_Day_One()
    {
        // Get input
        var input_string = File.ReadAllText(
            $"/Users/liam.treacy/Dev/advent_of_code/aoc_2022/aoc_2022/" +
            $"input.txt");
        
        // Get elves
        var elves = ParseStringForElves(input_string);
        
        // Get largest calorie count
        var pos = GetPositonLargestCalorieCount(elves);

        Assert.AreEqual(70613, elves[pos].Calories);
    }
    
    [Test]
    public void Not_A_Unit_Test_But_The_Real_Day_Two()
    {
        // Get input
        var input_string = File.ReadAllText(
            $"/Users/liam.treacy/Dev/advent_of_code/aoc_2022/aoc_2022/" +
            $"input.txt");
        
        // Get elves
        var elves = ParseStringForElves(input_string);
        
        // Get top three calorie count

        Assert.AreEqual(205805, CaloriesOfTopNElves(3, elves));
    }
}