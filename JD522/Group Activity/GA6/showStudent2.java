package showStudent2;

// Student Class from previous two questions is reused
// setName and calculateAverage methods removed to show the usage of Constructor

class Student {

public String IDnumber;

public double HourlyCredit[];

public double points[];

public double average;

// Constructor created here

Student() {

IDnumber = "9999";

average = 4.0;

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


public void display() {

int i, n;

n = points.length;

System.out.println("Name of Student: " + IDnumber);

for (i = 0; i < n; i++) {

System.out.println("Hourly credits earned: = " + HourlyCredit[i] + " Original point = " + points[i]);

}

System.out.println("Average is :" + average);

}

}

// Everything reused from previous class but now with constructor to demonstrate
// That Constructor works

class ShowStudent {

public static void main(String args[]) {

Student s = new Student();

double c[] = {3.0, 1.2, 3, 5};

double p[] = {1, 2, 3, 4};

s.setCreditHours(c);

s.setPoints(p);

s.display();

}

}