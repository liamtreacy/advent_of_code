import scala.collection.mutable.ListBuffer

// <range> <character>: <password>
// 1-3 a: abcde

// Password must contain a number of the characters within the range
object DayTwo {
    def ParseListToPwDbEntries(list: List[Any]): List[PwDbEntry] = {

        var e = new ListBuffer[PwDbEntry]()

        for(entry <- list){
            e += new PwDbEntry(entry.toString())
        }

        e.toList
    }

    def CountValidPasswords(list: List[PwDbEntry]): Int = {
        var count = 0

        for(l <- list){
            if(l.IsValid){
                count+=1
            }
        }
        count
    }
}