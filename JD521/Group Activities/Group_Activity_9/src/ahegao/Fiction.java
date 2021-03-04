package ahegao;

public class Fiction extends Book {

    public Fiction(String title) {
        super(title);
        setbPrice();
    }

    public void setbPrice() {
        super.bPrice = 24.99;
    }
}
