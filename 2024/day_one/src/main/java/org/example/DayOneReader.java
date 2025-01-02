package org.example;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class DayOneReader {

    ArrayList left = new ArrayList<Integer>();
    ArrayList right = new ArrayList<Integer>();
    public DayOneReader(){
        var fileLocation = "/Users/liam.treacy/Desktop/tmpFile";
        parseFile(fileLocation, left, right);
    }

    public static void parseFile(String filePath, ArrayList<Integer> leftList, ArrayList<Integer> rightList) {
        try (BufferedReader br = new BufferedReader(new FileReader(filePath))) {
            String line;
            while ((line = br.readLine()) != null) {
                String[] parts = line.split("\\s+");
                if (parts.length == 2) {
                    leftList.add(Integer.parseInt(parts[0]));
                    rightList.add(Integer.parseInt(parts[1]));
                }
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public ArrayList<Integer> GetL(){
        return left;
    }

    public ArrayList<Integer> GetR(){
        return right;
    }
}
