using System.Collections;
using aoc_2022;
using NUnit.Framework;



[TestFixture]
public class DayTwoTest
{
    PlayerMove ConvertToPlayerMove(char c)
    {
        return c switch
        {
            'A' => PlayerMove.Rock,
            'B' => PlayerMove.Paper,
            'C' => PlayerMove.Scissors,
            _ => PlayerMove.None
        };
    }
    
    PlayerMove ConvertOpposingMoveToPlayerMove(char c)
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
        Rock,
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

    Outcome RoundOutcomeForPlayerMove(PlayerMove p1, PlayerMove p2)
    {
        if (p1 == p2)
            return Outcome.Draw;

        var result = new List<(PlayerMove, PlayerMove, Outcome)>();
        result.Add((PlayerMove.Rock, PlayerMove.Scissors, Outcome.Win));
        result.Add((PlayerMove.Rock, PlayerMove.Paper, Outcome.Loss));

        result.Add((PlayerMove.Paper, PlayerMove.Scissors, Outcome.Loss));
        result.Add((PlayerMove.Paper, PlayerMove.Rock, Outcome.Win));
        
        result.Add((PlayerMove.Scissors, PlayerMove.Rock, Outcome.Loss));
        result.Add((PlayerMove.Scissors, PlayerMove.Paper, Outcome.Win));

        var t = result.First(t => t.Item1 == p1 && t.Item2 == p2);
        return t.Item3;
    }

    void Fight(Player p1, Player p2)
    {
        var outcome = RoundOutcomeForPlayerMove(p1.CurrentMove, p2.CurrentMove);

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
    public void Fight_win_test()
    {
        var one = new Player { CurrentMove = PlayerMove.Paper };
        var two = new Player { CurrentMove = PlayerMove.Rock };

        Fight(one, two);

        Assert.That(one.RunningScore, Is.EqualTo(6));
        Assert.That(two.RunningScore, Is.EqualTo(0));
    }
    
    [Test]
    public void Fight_loss_test()
    {
        var one = new Player { CurrentMove = PlayerMove.Paper };
        var two = new Player { CurrentMove = PlayerMove.Scissors };

        Fight(one, two);

        Assert.That(one.RunningScore, Is.EqualTo(0));
        Assert.That(two.RunningScore, Is.EqualTo(6));
    }

    [Test]
    public void Fight_draw_test()
    {
        var one = new Player { CurrentMove = PlayerMove.Paper };
        var two = new Player { CurrentMove = PlayerMove.Paper };

        Fight(one, two);
        Fight(two, one);
        
        Assert.That(one.RunningScore, Is.EqualTo(6));
        Assert.That(two.RunningScore, Is.EqualTo(6));
    }



    [Test]
    public void Convert_To_PlayerMove()
    {
        Assert.That(PlayerMove.Rock, Is.EqualTo(ConvertToPlayerMove('A')));
        Assert.That(PlayerMove.Paper, Is.EqualTo(ConvertToPlayerMove('B')));
        Assert.That(PlayerMove.Scissors, Is.EqualTo(ConvertToPlayerMove('C')));
    }
    
    [Test]
    public void Convert_Opposing_To_PlayerMove()
    {
        Assert.That(PlayerMove.Rock, Is.EqualTo(ConvertOpposingMoveToPlayerMove('X')));
        Assert.That(PlayerMove.Paper, Is.EqualTo(ConvertOpposingMoveToPlayerMove('Y')));
        Assert.That(PlayerMove.Scissors, Is.EqualTo(ConvertOpposingMoveToPlayerMove('Z')));
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
}