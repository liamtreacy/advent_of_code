object DataReader{
    def readFile(filename: String): List[Any] = {
        var lines = List[Any]()
        try {
            val bufferedSource = io.Source.fromFile(filename)
            lines = (for (line <- bufferedSource.getLines()) yield line).toList
            bufferedSource.close
            lines
        }
        catch {
            case e:Exception=> println("Exception caught")
        }
        lines
    }

    def sumValuesFromFile(filename: String): Int = {
        var fileContents = readFile(filename)
        fileContents.toList.map(_.toString.toInt).sum
    }
}