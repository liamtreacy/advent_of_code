using NUnit.Framework;

namespace aoc_2022;

[TestFixture]
public class DayFiveTest
{
    Stack<char>[] GetStackInput()
    {
        var stackArr = new Stack<char>[9];
        
        // 0
        stackArr[0].Push('P');
        stackArr[0].Push('F');
        stackArr[0].Push('M');
        stackArr[0].Push('Q');
        stackArr[0].Push('W');
        stackArr[0].Push('G');
        stackArr[0].Push('R');
        stackArr[0].Push('T');
        
        // 1
        stackArr[1].Push('H');
        stackArr[1].Push('F');
        stackArr[1].Push('R');
        
        // 2
        stackArr[2].Push('P');
        stackArr[2].Push('Z');
        stackArr[2].Push('R');
        stackArr[2].Push('V');
        stackArr[2].Push('G');
        stackArr[2].Push('H');
        stackArr[2].Push('S');
        stackArr[2].Push('D');
        
        // 3
        stackArr[3].Push('Q');
        stackArr[3].Push('H');
        stackArr[3].Push('P');
        stackArr[3].Push('B');
        stackArr[3].Push('F');
        stackArr[3].Push('W');
        stackArr[3].Push('G');
        
        // 4
        stackArr[4].Push('P');
        stackArr[4].Push('S');
        stackArr[4].Push('M');
        stackArr[4].Push('J');
        stackArr[4].Push('H');
        
        
        // 5
        stackArr[5].Push('M');
        stackArr[5].Push('Z');
        stackArr[5].Push('T');
        stackArr[5].Push('H');
        stackArr[5].Push('S');
        stackArr[5].Push('R');
        stackArr[5].Push('P');
        stackArr[5].Push('L');
        
        
        // 6
        stackArr[6].Push('P');
        stackArr[6].Push('T');
        stackArr[6].Push('H');
        stackArr[6].Push('N');
        stackArr[6].Push('M');
        stackArr[6].Push('L');
        
        
        // 7
        stackArr[7].Push('F');
        stackArr[7].Push('D');
        stackArr[7].Push('Q');
        stackArr[7].Push('R');
        
        // 8
        stackArr[8].Push('D');
        stackArr[8].Push('S');
        stackArr[8].Push('C');
        stackArr[8].Push('N');
        stackArr[8].Push('L');
        stackArr[8].Push('P');
        stackArr[8].Push('H');
        
        

        return stackArr;
    }
    
    [Test]
    public void Test_Stack()
    {
        
    }
}