using System.Collections;
using aoc_2022;
using NUnit.Framework;



[TestFixture]
public class DayTwoTest
{
    PlayerMove ConvertOpposingMoveToPlayerMove(char c)
    {
        return c switch
        {
            'A' => PlayerMove.Rock,
            'B' => PlayerMove.Paper,
            'C' => PlayerMove.Scissors,
            _ => PlayerMove.None
        };
    }
    
    PlayerMove ConvertYourMoveToPlayerMove(char c)
    {
        return c switch
        {
            'X' => PlayerMove.Rock,
            'Y' => PlayerMove.Paper,
            'Z' => PlayerMove.Scissors,
            _ => PlayerMove.None
        };
    }

    enum PlayerMove
    {
        None,
        Rock = 1,
        Paper,
        Scissors
    }

    enum Outcome
    {
        Win,
        Draw,
        Loss
    }

    class Player
    {
        public int RunningScore { get; set; }
        public PlayerMove CurrentMove { get; set; }
    }
    
    List<(PlayerMove, PlayerMove, Outcome)> OutcomeTuples()
    {
        var result = new List<(PlayerMove, PlayerMove, Outcome)>();
        result.Add((PlayerMove.Rock, PlayerMove.Scissors, Outcome.Win));
        result.Add((PlayerMove.Rock, PlayerMove.Paper, Outcome.Loss));

        result.Add((PlayerMove.Paper, PlayerMove.Scissors, Outcome.Loss));
        result.Add((PlayerMove.Paper, PlayerMove.Rock, Outcome.Win));

        result.Add((PlayerMove.Scissors, PlayerMove.Rock, Outcome.Loss));
        result.Add((PlayerMove.Scissors, PlayerMove.Paper, Outcome.Win));
        return result;
    }

    Outcome RoundOutcomeForPlayerMove(PlayerMove p1, PlayerMove p2)
    {
        if (p1 == p2)
            return Outcome.Draw;

        var result = OutcomeTuples();
        var t = result.First(t => t.Item1 == p1 && t.Item2 == p2);
        return t.Item3;
    }

    PlayerMove DetermineYourMoveOnDesiredOutcome(char c, PlayerMove OpposingMove)
    {
        // x lose, y draw, z win
        if (c == 'Y')
            return OpposingMove;

        var result = OutcomeTuples();

        if (c == 'X')
        {
            var x = result.First(t =>
                t.Item2 == OpposingMove && t.Item3 == Outcome.Loss);
            return x.Item1;
        }
        else if (c == 'Z')
        {
            var x = result.First(t =>
                t.Item2 == OpposingMove && t.Item3 == Outcome.Win);
            return x.Item1;
        }

        return PlayerMove.None;
    }

    void Fight(Player p1, Player p2)
    {
        var outcome = RoundOutcomeForPlayerMove(p1.CurrentMove, p2.CurrentMove);

        p1.RunningScore += (int)p1.CurrentMove;
        p2.RunningScore += (int)p2.CurrentMove;

        if (outcome == Outcome.Draw)
        {
            p1.RunningScore += 3;
            p2.RunningScore += 3;
            return;
        }

        if (outcome == Outcome.Loss)
        {
            p2.RunningScore += 6;
            return;
        }

        if (outcome == Outcome.Win)
        {
            p1.RunningScore += 6;
            return;
        }
    }

    [Test]
    public void Fight_Win_Test()
    {
        var one = new Player { CurrentMove = PlayerMove.Paper };
        var two = new Player { CurrentMove = PlayerMove.Rock };

        Fight(one, two);

        Assert.That(one.RunningScore, Is.EqualTo(8));
        Assert.That(two.RunningScore, Is.EqualTo(1));
    }
    
    [Test]
    public void Fight_Loss_Test()
    {
        var one = new Player { CurrentMove = PlayerMove.Paper };
        var two = new Player { CurrentMove = PlayerMove.Scissors };

        Fight(one, two);

        Assert.That(one.RunningScore, Is.EqualTo(2));
        Assert.That(two.RunningScore, Is.EqualTo(9));
    }

    [Test]
    public void Fight_Draw_Test()
    {
        var one = new Player { CurrentMove = PlayerMove.Paper };
        var two = new Player { CurrentMove = PlayerMove.Paper };

        Fight(one, two);
        Fight(two, one);
        
        Assert.That(one.RunningScore, Is.EqualTo(10));
        Assert.That(two.RunningScore, Is.EqualTo(10));
    }



    [Test]
    public void Convert_To_PlayerMove()
    {
        Assert.That(PlayerMove.Rock, Is.EqualTo(ConvertOpposingMoveToPlayerMove('A')));
        Assert.That(PlayerMove.Paper, Is.EqualTo(ConvertOpposingMoveToPlayerMove('B')));
        Assert.That(PlayerMove.Scissors, Is.EqualTo(ConvertOpposingMoveToPlayerMove('C')));
    }
    
    [Test]
    public void Convert_Opposing_To_PlayerMove()
    {
        Assert.That(PlayerMove.Rock, Is.EqualTo(ConvertYourMoveToPlayerMove('X')));
        Assert.That(PlayerMove.Paper, Is.EqualTo(ConvertYourMoveToPlayerMove('Y')));
        Assert.That(PlayerMove.Scissors, Is.EqualTo(ConvertYourMoveToPlayerMove('Z')));
    }

    [Test]
    public void Rules_Test()
    {
        Assert.That(Outcome.Win, Is.EqualTo(RoundOutcomeForPlayerMove(
            PlayerMove.Rock, PlayerMove.Scissors)));
        
        Assert.That(Outcome.Loss, Is.EqualTo(RoundOutcomeForPlayerMove(
            PlayerMove.Rock, PlayerMove.Paper)));
        
        Assert.That(Outcome.Draw, Is.EqualTo(RoundOutcomeForPlayerMove(
            PlayerMove.Rock, PlayerMove.Rock)));
        
        Assert.That(Outcome.Win, Is.EqualTo(RoundOutcomeForPlayerMove(
            PlayerMove.Paper, PlayerMove.Rock)));
        
        Assert.That(Outcome.Loss, Is.EqualTo(RoundOutcomeForPlayerMove(
            PlayerMove.Paper, PlayerMove.Scissors)));
        
        Assert.That(Outcome.Draw, Is.EqualTo(RoundOutcomeForPlayerMove(
            PlayerMove.Paper, PlayerMove.Paper)));
        
        Assert.That(Outcome.Loss, Is.EqualTo(RoundOutcomeForPlayerMove(
            PlayerMove.Scissors, PlayerMove.Rock)));
        
        Assert.That(Outcome.Win, Is.EqualTo(RoundOutcomeForPlayerMove(
            PlayerMove.Scissors, PlayerMove.Paper)));
        
        Assert.That(Outcome.Draw, Is.EqualTo(RoundOutcomeForPlayerMove(
            PlayerMove.Scissors, PlayerMove.Scissors)));
    }

    [Test]
    public void Do_Day_Two_For_Real_Part_One()
    {
        // Get input
        var input_strings = File.ReadAllLines(
            $"/Users/liam.treacy/Dev/advent_of_code/aoc_2022/aoc_2022/" +
            $"DayTwoInput.txt");

        var p1 = new Player();
        var p2 = new Player();

        foreach (var str in input_strings)
        {
            p1.CurrentMove = ConvertOpposingMoveToPlayerMove(str[0]);
            p2.CurrentMove = ConvertYourMoveToPlayerMove(str[2]);

            Fight(p1, p2);
        }
        
        Assert.That(p2.RunningScore, Is.EqualTo(15422));
    }
    
    
    [Test]
    public void Do_Day_Two_For_Real_Part_Two()
    {
        // Get input
        var input_strings = File.ReadAllLines(
            $"/Users/liam.treacy/Dev/advent_of_code/aoc_2022/aoc_2022/" +
            $"DayTwoInput.txt");

        var p1 = new Player();
        var p2 = new Player();

        foreach (var str in input_strings)
        {
            p1.CurrentMove = ConvertOpposingMoveToPlayerMove(str[0]);
            p2.CurrentMove = DetermineYourMoveOnDesiredOutcome(str[2], p1.CurrentMove);

            Fight(p1, p2);
        }
        
        Assert.That(p2.RunningScore, Is.EqualTo(15442));
    }
}