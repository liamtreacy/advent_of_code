//package foo.bar

// <range> <character>: <password>
// 1-3 a: abcde

class PwDbEntry (val str: String){

    var min: Int = str.substring(0, str.indexOf('-')).toInt
    var max: Int = str.substring(str.indexOf('-')+1,str.indexOf(' ')).toInt
    var c: Char = str.substring(str.indexOf(' ')+1, str.indexOf(' ')+2).charAt(0)
    var pw: String = str.substring(str.lastIndexOf(' '))

    private var valid: Boolean = pw.toList.count(_ == c) >= min && pw.count(_ == c) <= max

    def IsValid: Boolean = {
        valid
    }
}