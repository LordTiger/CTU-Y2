package SammysMotto2;

public class SammysMotto2 {

    public static void main(String[] args) {
        border("Sammy’s makes it fun in the sun.");
    }


    public static void border(String contents) {
        int n = contents.length();
        for (int i = 0; i < n - 13; i++) {
            System.out.print("Ss");
        }
        System.out.println();
        System.out.println("Ss " + contents + " Ss");
        for (int i = 0; i < n - 13; i++) {
            System.out.print("Ss");
        }
        System.out.println();
    }
}
