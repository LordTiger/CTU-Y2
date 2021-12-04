Student.java:

package student;

// Student class created here

class Student {

public String IDnumber;

public double HourlyCredit[];

public double points[];

public double average;

// Methods created below to set values

public void setIDNumber(String n) {

IDnumber = n;

}

public void setCreditHours(double c[]) {

int i, n;

n = c.length;

HourlyCredit = new double[n];

for (i = 0; i < n; i++) {
HourlyCredit[i] = c[i];
}

}

public void setPoints(double p[]) {

int i, n;

n = p.length;

points = new double[n];

for (i = 0; i < n; i++) {
points[i] = p[i];
}

}

//Average calculated here

public double calculateAverage() {

double sum1 = 0, sum2 = 0;

int i, n;

n = points.length;

for (i = 0; i < n; i++) {

sum1 += HourlyCredit[i];

sum2 += HourlyCredit[i] * points[i];

}

average = sum2 / sum1;

return average;

}

// Display method created to display methods

public void display() {

int i, n;

n = points.length;

System.out.println("Student ID: " + IDnumber);

for (i = 0; i < n; i++) {

System.out.println("Hourly credits earned: = " + HourlyCredit[i] + " Original point = " + points[i]);

}

System.out.println("Student average is: " + average);

}

}