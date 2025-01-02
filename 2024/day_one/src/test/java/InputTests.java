import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertTrue;

public class InputTests {

    public Integer calc(ArrayList<Integer> l, ArrayList<Integer> r){
        return 0;
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
