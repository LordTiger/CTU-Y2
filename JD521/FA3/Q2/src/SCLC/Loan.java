package SCLC;

/*
Brandon de Bruyn 6854
Class Loan
 */

import java.util.InputMismatchException;


public abstract class Loan implements LoanConstants {
    private String loanNum; // Loan Number
    private String lastName; // Client Last Name
    private double loanAmt; // Loan Amount
    protected double interestRate; // Loan Interest Rate
    private int term; // Terms (1,3,5)

    Loan(String loanNum, String lastName, double loanAmt, int term) {
        this.loanNum = loanNum;
        this.lastName = lastName.toUpperCase();

        //Try & Catch Function to validate the loan amount
        try {
            if (loanAmt > Max_Loan_Amount) {
                throw (new InputMismatchException("Loam amount can't be over R100,000.00"));
            } else {
                this.loanAmt = loanAmt;
            }
        } catch (InputMismatchException e) {
            System.out.println(e.getMessage());
        }

        //Sets the term to default and the default is 1 Year
        switch (term) {
            case M_TERM:
            case L_TERM:
                this.term = term;
                break;
            case S_TERM:
            default:
                this.term = 1;
                break;
        }
    }
    @Override
    public String toString() {
        return String.format("%s\t\t%s\t\t$%,.2f\t%.2f%%\t\t%d\t\t$%,.2f",
                this.loanNum, this.lastName, this.loanAmt, this.interestRate * 100,
                this.term, this.loanAmt + (this.loanAmt * this.interestRate));
    }
}
