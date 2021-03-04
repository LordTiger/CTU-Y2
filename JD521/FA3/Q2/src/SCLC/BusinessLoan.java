package SCLC;
/*
Brandon de Bruyn 6854
Class BusinessLoan
 */

public class BusinessLoan extends Loan{
    BusinessLoan(String loanNum, String lastName, double loanAmt, int term, double primeIntRate) {
        super(loanNum, lastName, loanAmt, term);
        super.interestRate = 0.01 / (primeIntRate / 100);
    }
}
