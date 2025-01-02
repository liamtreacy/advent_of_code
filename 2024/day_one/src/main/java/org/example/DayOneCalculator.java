package org.example;

import java.util.ArrayList;
import java.util.stream.Collectors;

public class DayOneCalculator {
    public static Integer calc(ArrayList<Integer> l, ArrayList<Integer> r){
        var sortedL = l.stream().sorted().collect(Collectors.toList());
        var sortedR = r.stream().sorted().collect(Collectors.toList());

        Integer distance = 0;

        for(int i = 0; i < sortedL.size(); i++){
            var localDistance = sortedL.get(i) - sortedR.get(i);
            distance += Math.abs(localDistance);
        }

        return distance;
    }
}
