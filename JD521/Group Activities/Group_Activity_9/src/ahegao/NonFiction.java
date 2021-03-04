package ahegao;

public class NonFiction extends Book {

    public NonFiction(String title) {
        super(title);
        setbPrice();
    }

    public void setbPrice() {
        super.bPrice = 37.99;
    }
}
