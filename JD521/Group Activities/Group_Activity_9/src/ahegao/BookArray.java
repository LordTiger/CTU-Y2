package ahegao;

import java.util.ArrayList;
import java.util.List;

public class BookArray {
    static List<Book> bookList = new ArrayList<Book>();
    public static void main(String[] args) {
        Book books;
        books = new Fiction("Chousuke Nagashima");
        bookList.add(books);
        books = new NonFiction("Naoto Fukuyama");
        bookList.add(books);
        books = new Fiction("Omina Tachibana");
        bookList.add(books);
        books = new Fiction("Kaiwai Haraise");
        bookList.add(books);
        books = new Fiction("Ichiri");
    }
}
