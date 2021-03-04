package GA5;

import java.util.Arrays;
import java.util.Collections;

public class NineInts {

    public static void reverse(Integer NineInts[]) {
        Collections.reverse(Arrays.asList(NineInts));
        System.out.println("Reversed Array: " + Arrays.asList(NineInts));
    }

    public static void main(String[] args) {
        Integer[] NineInts = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        System.out.println("Original Array: " + Arrays.asList(NineInts));
        reverse(NineInts);


    }
}
