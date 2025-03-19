/*

The City of Rio de Janeiro has opened a credit line for statutory employees.
The maximum installment amount cannot exceed 30% of the gross salary.
Create an algorithm that reads the gross salary and the installment amount and informs whether the loan can be granted or not.
Example:
Gross salary: 1200.00
Installment amount: 400.00
Loan cannot be granted!

*/

import java.util.Scanner;

public class Exercicio22 {
    public static void main(String[] args){
        double salary, installment;
        Scanner userInput = new Scanner(System.in);

        System.out.println("How much installment you like to receive ?");
        installment = userInput.nextDouble();

        System.out.println("Informe your salary: ");
        salary = userInput.nextDouble();
        

        if((salary * 0.30) <= installment){
            System.out.println("Loan can't be granted!");


        }
        else{
            System.out.println("Loan granted!");
        }   

        userInput.close();

    }
    
}
