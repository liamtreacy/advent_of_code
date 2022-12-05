class DayOneTests extends org.scalatest.funsuite.AnyFunSuite {
  test("DayOne.FindEntriesWhichSumToExpectedValue empty list") {
    assert(DayOne.FindEntriesWhichSumToExpectedValue(List(), 10) equals (-1,-1))
  }

  test("DayOne.FindEntriesWhichSumToExpectedValue too high a value to reach") {
    val l = List(1,5,7,8)
    assert(DayOne.FindEntriesWhichSumToExpectedValue(l, 30) equals (-1,-1))
  }

  test("DayOne.FindEntriesWhichSumToExpectedValue gets expected value") {
    val l = List(1,5,7,8,13,15)
    assert(DayOne.FindEntriesWhichSumToExpectedValue(l, 13) equals (1,3))
  }

  test("DayOne.FindEntriesWhichSumToExpectedValue gets expected value again") {
    val l = List(1,5,7,6,8,13,15,2)
    assert(DayOne.FindEntriesWhichSumToExpectedValue(l, 10) equals (4,7))
  }


  test("DayOne Solution") {
    //val l = DataReader.readFile(getClass.getResource("/input_for_puzzle_from_site.txt").getPath).map(_.toString.toInt)
    //val soln = DayOne.FindEntriesWhichSumToExpectedValue(l, 2020)
    // Multiply the following two for the answer
    //println(l(76))
    //println(l(173))
    //
    // Only enable the below when the test data is accurate
    //
    //assert(soln equals (76,173))
  }
  
    test("DayOne.FindThreeEntriesWhichSumToExpectedValue empty list") {
    assert(DayOne.FindThreeEntriesWhichSumToExpectedValue(List(), 10) equals (-1,-1,-1))
  }

  test("DayOne.FindThreeEntriesWhichSumToExpectedValue too high a value to reach") {
    val l = List(1,5,7,8)
    assert(DayOne.FindThreeEntriesWhichSumToExpectedValue(l, 30) equals (-1,-1,-1))
  }

    test("DayOne.FindThreeEntriesWhichSumToExpectedValue gets expected value") {
    val l = List(1,5,7,8,13,15)
    assert(DayOne.FindThreeEntriesWhichSumToExpectedValue(l, 16) equals (0,2,3))
  }

    test("DayOne.FindThreeEntriesWhichSumToExpectedValue gets expected value again") {
    val l = List(1,5,7,6,8,13,15,2)
    assert(DayOne.FindThreeEntriesWhichSumToExpectedValue(l, 30) equals (2,4,6))
  }

    test("DayOne Part Two Solution") {
    //val l = DataReader.readFile(getClass.getResource("/input_for_puzzle_from_site.txt").getPath).map(_.toString.toInt)
    //val soln = DayOne.FindThreeEntriesWhichSumToExpectedValue(l, 2020)
    
    // Multiply the following three for the answer
    // println(l(48))
    //println(l(105))
    //println(l(119))
    //
    // Only enable the below when the test data is accurate
    //
    //assert(soln equals (48,105,119))
  } 
}