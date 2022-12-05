class DayTwoTests extends org.scalatest.funsuite.AnyFunSuite {
  test("Parse string to password and rules entry, valid entry") {
    val s: String = "1-4 g: bgo"
    val p = new PwDbEntry(s)
    assert( p.IsValid equals true)
  }

  test("Parse string to password and rules entry, invalid entry") {
    val s: String = "1-4 g: bipppo"
    val p = new PwDbEntry(s)
    assert( p.IsValid equals false)
  }

  test("Parse string to password and rules entry, invalid entry(2)") {
    val s: String = "1-4 g: bipgggggppo"
    val p = new PwDbEntry(s)
    assert( p.IsValid equals false)
  }

  test("DayTwo.ParseListToPwDbEntries") {
    val l: List[Any] = List("1-4 g: bipgggggppo", "3-44 r: rte")
    
    val pwdEntries = DayTwo.ParseListToPwDbEntries(l)
    assert( pwdEntries.size equals 2)
  }

  test("DayTwo.CountValidPasswords") {
    val l: List[Any] = List("1-4 g: bipgggggppo", "3-44 r: rtrer", "1-3 w: hewllouv")
    
    val pwdEntries = DayTwo.ParseListToPwDbEntries(l)
    var numberValid = DayTwo.CountValidPasswords(pwdEntries)

    assert( numberValid equals 2)
  }

  test("DayTwo Soln") {
    val l = DataReader.readFile(getClass.getResource("/input_for_puzzle_from_site.txt").getPath).map(_.toString)
    
    val pwdEntries = DayTwo.ParseListToPwDbEntries(l)
    var numberValid = DayTwo.CountValidPasswords(pwdEntries)
    println(numberValid)
    assert( numberValid equals 628)
  }
}