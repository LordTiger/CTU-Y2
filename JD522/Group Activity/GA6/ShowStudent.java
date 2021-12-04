package student;

// ShowStudent class created here
// All methods are set and displayed using the display method

public class ShowStudent {

public static void main(String args[]) {

Student s = new Student();

double c[] = {3.0, 1.2, 3, 5};

double p[] = {1, 2, 3, 4};

s.setIDNumber("123");

s.setCreditHours(c);

s.setPoints(p);

s.calculateAverage();

s.display();

}
}
