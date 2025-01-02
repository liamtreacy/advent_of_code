package org.example;

import java.util.ArrayList;
import java.util.stream.Collectors;

public class DayOneCalculator {
    public static Integer GetDistance(ArrayList<Integer> l, ArrayList<Integer> r){
        var sortedL = l.stream().sorted().collect(Collectors.toList());
        var sortedR = r.stream().sorted().collect(Collectors.toList());

        Integer distance = 0;

        for(int i = 0; i < sortedL.size(); i++){
            var localDistance = sortedL.get(i) - sortedR.get(i);
            distance += Math.abs(localDistance);
        }

        return distance;
    }

    public static Integer GetSimilarityScore(ArrayList<Integer> l, ArrayList<Integer> r){
        Integer score = 0;

        for(int i = 0; i < l.size(); i++){
            int finalI = i;
            var multiplier = r.stream().filter(x -> x.equals(l.get(finalI))).count();
            score = score + ( (int) (long)multiplier *l.get(i));
        }

        return score;
    }
}
