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

        if (p1 == PlayerMove.Rock && p2 == PlayerMove.Scissors)
            return Outcome.Win;

        if (p1 == PlayerMove.Rock && p2 == PlayerMove.Paper)
            return Outcome.Loss;

        if (p1 == PlayerMove.Paper && p2 == PlayerMove.Scissors)
            return Outcome.Loss;

        if (p1 == PlayerMove.Paper && p2 == PlayerMove.Rock)
            return Outcome.Win;
        
        if (p1 == PlayerMove.Scissors && p2 == PlayerMove.Paper)
            return Outcome.Win;

        if (p1 == PlayerMove.Scissors && p2 == PlayerMove.Rock)
            return Outcome.Loss;

        return Outcome.Loss;
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