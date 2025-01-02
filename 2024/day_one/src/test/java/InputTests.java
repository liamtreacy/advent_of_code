import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.stream.Collectors;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertTrue;

public class InputTests {

    public Integer calc(ArrayList<Integer> l, ArrayList<Integer> r){
        var sortedL = l.stream().sorted().collect(Collectors.toList());
        var sortedR = r.stream().sorted().collect(Collectors.toList());

        Integer distance = 0;

        for(int i = 0; i < sortedL.size(); i++){
            var localDistance = sortedL.get(i) - sortedR.get(i);
            distance += Math.abs(localDistance);
        }

        return distance;
    }

    @Test
    void demoTestMethod() {

        var left = new ArrayList<Integer>(Arrays.asList(3, 4, 2, 1, 3, 3));
        var right = new ArrayList<Integer>(Arrays.asList(4,3,5,3,9,3));


        // sort

        // then find absolute distance: l[n] - r[n]

        // add up all the distances

        var totalDistance = calc(left, right);
        assertEquals(11, totalDistance);
    }
}
