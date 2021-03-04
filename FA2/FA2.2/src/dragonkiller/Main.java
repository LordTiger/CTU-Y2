package dragonkiller;

import javax.swing.*;
import java.util.Arrays;
import java.util.Random;

class nameSurname {

    public void removeSpace() {
        String nameSurname = JOptionPane.showInputDialog(null, "Enter your Name & Surname: ",
                "Welcome to DragonKiller", JOptionPane.INFORMATION_MESSAGE);
        String nas = nameSurname.replace(" ", "");
        int c = nas.length();

        //Dragon killer Array
        int[] arrayDragon = new int[c];

        //Random thingy
        Random r = new Random();
        for (int i = 0; i < c; i++) {
            int rint = r.nextInt(50);
            arrayDragon[i] = rint + 10;
        }

        Arrays.sort(arrayDragon);

        int inputNum = Integer.parseInt(JOptionPane.showInputDialog(null,"Array Dragon: " + Arrays.toString(arrayDragon) +
                "\nChoose a Number in the array: " ));

        int index =  Arrays.binarySearch(arrayDragon, inputNum);

        if (index < 0) {
            JOptionPane.showMessageDialog(null, "The Array doesn't have that value.");
        } else {
            arrayDragon[index] = 0;
            JOptionPane.showMessageDialog(null, "Sorted arrayDragon with removed item" +
                    "\n The number " + inputNum + " was removed at index[" + index + "]");

            JOptionPane.showMessageDialog(null, "Original: " + nameSurname + "\nSpace Removed: "
                    + nas + "\nTotal Characters in name: " + c + "\nNumber Chosen: " + inputNum + "\nDragon has Been Killed!");
        }

    }

}

public class Main {

    public static void main(String[] args) {
	// write your code here
        nameSurname nas = new nameSurname();
        nas.removeSpace();
    }
}
