/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package carthingy;

import java.io.Serializable;

/**
 *
 * @author tiger
 */
public class Car implements Serializable {
    
    String Type;
    double iRate, Deposit;
    
    int PInstallment, Installments, SellingPrice, tCost, Balloon;
    String ImageUrl;
    
    public Car(String _Type, int _PInstallment, int _sellingPrice, double _iRate, double _Deposit, int _Balloon,
            int _Installments, int _tCost, String _ImageUrl) {
        this.Type = _Type; // Car Type (Polo or Something else)
        this.PInstallment = _PInstallment; // Price Installment
        this.SellingPrice = _sellingPrice; // Car Selling price
        this.iRate = _iRate; // Interest Rate
        this.Deposit = _Deposit; // Car Deposit
        this.Balloon = _Balloon; // Car Ballon Payment
        this.Installments = _Installments; // Total Installments
        this.tCost = _tCost; // Total Cost of Car
        this.ImageUrl = _ImageUrl; // Car Image URL
    }

    public String Details() {
        return "Installment: R" + PInstallment + "\n\nSelling price: R" + SellingPrice + "\n\nInterest Rate: " + iRate  + "%"+ "\n\nDeposit: " + Deposit + "%" + "\n\nBalloon Payment: R" + Balloon + 
                "\n\nInstallments: " + Installments + "\n\nTotal Cost of Credit: R" + tCost;
    }
    
}
