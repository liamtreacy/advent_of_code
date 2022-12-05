class DataReaderSpec extends org.scalatest.funsuite.AnyFunSuite {
  test("DataReader.readFile no file name") {
    assert(DataReader.readFile("").isEmpty)
  }

  test("DataReader.readFile returns correct number of entries from test file") {
    assert(DataReader.readFile(getClass.getResource("/test_data_for_reading.txt").getPath).size equals 8)
  }

  test("DataReader.sumValuesFromFile returns correct sum from test file") {
    assert( DataReader.sumValuesFromFile(getClass.getResource("/test_data_for_reading.txt").getPath) equals 1018 )
  }
}