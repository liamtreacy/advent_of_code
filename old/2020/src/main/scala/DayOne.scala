import scala.util.control.Breaks._

// Find the two entries that sum to 2020; what do you get if you multiply them together?
object DayOne extends App {
  def GetDayOneAnswer: Unit = {
    var entries = DataReader.readFile("").toList.map(_.toString.toInt)
    val soln = FindEntriesWhichSumToExpectedValue(entries, 2020)
    println(soln)
  }

  def FindEntriesWhichSumToExpectedValue( contents: List[Int], value: Int) = {
    var first, second = -1
    breakable {
      for (i <- 0 until contents.length)
      {
        for( j <- i+1 until contents.length)
        {
          if( contents(i) + contents(j) == value)
          {
            first = i
            second = j
            break
          }
        }
      }
    }
    (first,second)
  }

    def FindThreeEntriesWhichSumToExpectedValue( contents: List[Int], value: Int) = {
    var first, second, third = -1
    breakable {
      for (i <- 0 until contents.length)
      {
        for( j <- i+1 until contents.length)
        {
            for( k <- j+1 until contents.length)
            {
                if( contents(i) + contents(j) + contents(k) == value)
                {
                    first = i
                    second = j
                    third = k
                    break
                }
            }
        }
      }
    }
    (first,second, third)
  }
}