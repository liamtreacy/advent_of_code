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

    Outcome RoundOutcomeForPlayer(PlayerMove p1, PlayerMove p2)
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
        Assert.That(Outcome.Win, Is.EqualTo(RoundOutcomeForPlayer(
            PlayerMove.Rock, PlayerMove.Scissors)));
        
        Assert.That(Outcome.Loss, Is.EqualTo(RoundOutcomeForPlayer(
            PlayerMove.Rock, PlayerMove.Paper)));
        
        Assert.That(Outcome.Draw, Is.EqualTo(RoundOutcomeForPlayer(
            PlayerMove.Rock, PlayerMove.Rock)));
        
        Assert.That(Outcome.Win, Is.EqualTo(RoundOutcomeForPlayer(
            PlayerMove.Paper, PlayerMove.Rock)));
        
        Assert.That(Outcome.Loss, Is.EqualTo(RoundOutcomeForPlayer(
            PlayerMove.Paper, PlayerMove.Scissors)));
        
        Assert.That(Outcome.Draw, Is.EqualTo(RoundOutcomeForPlayer(
            PlayerMove.Paper, PlayerMove.Paper)));
        
   
        Assert.That(Outcome.Loss, Is.EqualTo(RoundOutcomeForPlayer(
            PlayerMove.Scissors, PlayerMove.Rock)));
        
        Assert.That(Outcome.Win, Is.EqualTo(RoundOutcomeForPlayer(
            PlayerMove.Scissors, PlayerMove.Paper)));
        
        Assert.That(Outcome.Draw, Is.EqualTo(RoundOutcomeForPlayer(
            PlayerMove.Scissors, PlayerMove.Scissors)));
    }
}