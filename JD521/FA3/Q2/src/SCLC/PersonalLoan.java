package SCLC;
/*
Brandon de Bruyn 6854
Class PersonalLoan
 */

public class PersonalLoan extends Loan {
    PersonalLoan(String loanNum, String lastName, double loanAmt, int term, double primeIntRate) {
        super(loanNum, lastName, loanAmt, term);
        super.interestRate = 0.02 / (primeIntRate / 100);

    }
}
