package ahegao;
/*
Brandon de Bruyn 6854
Luke De Kiewit 7293
 */
public abstract class Book {
    String BookTitle; // Title of Book
    double bPrice; // Book Price

    public Book(String title) {
        BookTitle = title;
    }

    public String getBookTitle() {
        return BookTitle;
    }

    public double getbPrice() {
        return bPrice;
    }

    public abstract void setbPrice();
}
