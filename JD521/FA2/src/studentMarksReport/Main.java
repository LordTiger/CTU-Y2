package studentMarksReport;
import javax.swing.*;

abstract class student {
    private int snum;
    private int tres;
    private int ares;
    private int eres;

    public student(int snum, int tres, int ares, int eres) {
        this.snum = snum;
        this.tres = tres;
        this.ares = ares;
        this.eres = eres;
    }

    public int getSnum() {
        return snum;
    }

    public int getTres() {
        return tres;
    }

    public int getAres() {
        return ares;
    }

    public int getEres() {
        return eres;
    }

    public void setSnum(int snum) {
        this.snum = snum;
    }

    public void setTres(int tres) {
        this.tres = tres;
    }

    public void setAres(int ares) {
        this.ares = ares;
    }

    public void setEres(int eres) {
        this.eres = eres;
    }

    public abstract void print_report(double report);
}

class student_report extends student {
    int TResult;
    int AResult;
    int EResult;

    public student_report(int snum, int tres, int ares, int eres, int TResult, int AResult, int EResult) {
        super(snum, tres, ares, eres);
        TResult = tres;
        AResult = ares;
        EResult = eres;
    }

    @Override
    public void print_report(double report) {
        int SNum = Integer.parseInt(JOptionPane.showInputDialog(null,"Enter your Student Number:"));
        int TResult = Integer.parseInt(JOptionPane.showInputDialog(null,"Enter your Test Result:"));
        int AResult = Integer.parseInt(JOptionPane.showInputDialog(null,"Enter your Assigment Result:"));
        int EResult = Integer.parseInt(JOptionPane.showInputDialog(null,"Enter your Exam Result:"));

        double t = (TResult * 0.25);
        double a = (AResult * 0.25);
        double e = (EResult * 0.50);
        report = (t + a + e);

        JOptionPane.showMessageDialog(null,  "Test Result: " + TResult + "/100" +"\n"+ "Assignment Result: "
                + AResult + "/100" + "\n" + "Exam Result: " + EResult + "/100" + "\n" + "Final Weight: " + report + "%", "Student Number: " +
                SNum, JOptionPane.INFORMATION_MESSAGE);

    }

}

public class Main {

    public static void main(String[] args) {
        student_report s = new student_report(0,0,0,0,0,0,0);
        s.print_report(0);

    }
}





