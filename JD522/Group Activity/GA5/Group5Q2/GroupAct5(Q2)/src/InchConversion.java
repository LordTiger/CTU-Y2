import java.util.Scanner;

public class InchConversion {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Enter number of inches: ");
        int inches = in.nextInt();
        convertToFeet(inches);
        convertToYards(inches);
    }

    public static void convertToFeet(int inches) {
        System.out.println(inches + " inches is " + (inches/12.0) + " feets.");
    }

    public static void convertToYards(int inches) {
        System.out.println(inches + " inches is " + (inches/36.0) + " yards.");
    }
}
