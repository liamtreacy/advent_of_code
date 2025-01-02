package org.example;

import java.util.ArrayList;

public class DayOneReader {

    ArrayList left = new ArrayList<Integer>();
    ArrayList right = new ArrayList<Integer>();
    public DayOneReader(){
        var fileLocation = "~/Desktop/tmpFile";
    }

    public ArrayList<Integer> GetL(){
        return left;
    }

    public ArrayList<Integer> GetR(){
        return right;
    }
}
