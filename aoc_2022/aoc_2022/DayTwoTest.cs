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

// A for Rock, B for Paper, and C for Scissors

    enum PlayerMove
    {
        None,
        Rock,
        Paper,
        Scissors
    }

    [Test]
    public void Convert_To_PlayerMove()
    {
        Assert.That(PlayerMove.Rock, Is.EqualTo(ConvertToPlayerMove('A')));
        Assert.That(PlayerMove.Paper, Is.EqualTo(ConvertToPlayerMove('B')));
        Assert.That(PlayerMove.Scissors, Is.EqualTo(ConvertToPlayerMove('C')));
    }
}