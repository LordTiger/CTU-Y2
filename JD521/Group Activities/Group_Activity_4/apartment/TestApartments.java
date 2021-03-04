package apartment;
import java.util.Scanner;

// Brandon de Bruyn 6854
// Luke de Kiwiet 7293

public class TestApartments {

    public static void main(String args[]) {
        Scanner input = new Scanner(System.in);

        apartment apt1 = new apartment(101, 2, 1, 725);

        apartment apt2 = new apartment(102, 2, 1, 775);

        apartment apt3 = new apartment(103, 3, 2, 870);

        apartment apt4 = new apartment(104, 3, 2, 960);

        apartment apt5 = new apartment(105, 3, 3, 1100);

        int bdrms;

        int baths;

        int rent;

        int count = 0;

        System.out.print("Enter number of bedrooms needed: ");

        bdrms = input.nextInt();

        System.out.print("Enter  number of bathrooms needed: ");

        baths = input.nextInt();

        System.out.print("Enter maximum rent willing to pay: ");

        rent = input.nextInt();

        System.out.println("\nApartments meeting citeria of\nat least " + bdrms +

                " bedrooms, at least " + baths + " baths, and " + " no more than R" +

                rent + " rent:");

        apartment[] Apartments = {apt1, apt2, apt3, apt4, apt5};

        for (int i = 0; i < Apartments.length; i++ ){
            if(checkApt(Apartments[i], bdrms, baths, rent)){
                display(Apartments[i]);
            }
        }
    }

    public static boolean checkApt(apartment apt, int bdrms, int baths, int rent)
    {

        if (apt.getNumberOfBedroom() <= bdrms && apt.getNumberOfBath() <= baths
                && apt.getRentAmount() <= rent){
            return true;
        }
        return false;

    }

    public static void display(apartment apt) {

        System.out.println("   Apt #" + apt.getApartmentNumber() + "    " +
                apt.getNumberOfBedroom() +

                " bedrooms, and " + apt.getNumberOfBath() + " baths. Rent R"
                + apt.getRentAmount());

    }

}