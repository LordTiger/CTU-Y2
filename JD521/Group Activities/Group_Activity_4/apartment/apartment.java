package apartment;
// Brandon de Bruyn 6854
// Luke de Kiwiet 7293

public class apartment {
    private int apartmentNumber, numberOfBath, numberOfBedroom, rentAmount;

    public apartment(int apartmentNumber, int numberOfBedroom, int numberOfBath, int rentAmount){
        this.apartmentNumber = apartmentNumber;
        this.numberOfBedroom = numberOfBedroom;
        this.numberOfBath = numberOfBath;
        this.rentAmount = rentAmount;
    }

    public int getApartmentNumber() {
        return apartmentNumber;
    }

    public int getNumberOfBedroom() {
        return numberOfBedroom;
    }

    public int getNumberOfBath() {
        return numberOfBath;
    }

    public double getRentAmount() {
        return rentAmount;
    }

}