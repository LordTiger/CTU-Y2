package ahegao;

import javax.swing.*;

/*
Brandon de Bruyn 6854
Luke De Kiewit 7293
 */
public class UseBook {

    public static void main(String[] args) {
	// write your code here

        Book books;
        books = new Fiction("Chousuke Nagashima");
        JOptionPane.showMessageDialog(null, books.getBookTitle());
        books = new NonFiction("Omina Tachibana");
        JOptionPane.showMessageDialog(null, books);
    }
}
