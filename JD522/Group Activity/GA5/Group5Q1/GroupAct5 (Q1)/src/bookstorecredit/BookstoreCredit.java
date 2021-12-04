
package bookstorecredit;

import java.util.Scanner; //import statement allow use of Scanner class
public class BookstoreCredit
{
public static void main(String[] args)
{  
//Add variables (student name, student gap and bookstore credit)
String studentName;
double studentGpa; 
double bookstoreCredit;
  

Scanner input=new Scanner(System.in);
System.out.println("Enter student name");
  
studentName = input.nextLine(); 
  

System.out.println("Enter student gpa");
studentGpa = input.nextDouble();
  

bookstoreCredit = studentGpa * 10;
print(studentName,studentGpa,bookstoreCredit);
  
}

private static void print(String studentName, double studentGpa, double bookstoreCredit) {
 
System.out.println(studentName + ", with a " + studentGpa + " GPA you receive a R" + bookstoreCredit + "credit!");   

}
}

