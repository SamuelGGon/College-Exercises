/*

Given the menu of a snack bar:

Code	Product	     Price
100	     Hot Dog	  $1.20
101	  Simple Bauru	  $1.30
102	  Bauru with Egg  $1.50
103	    Hamburger	  $1.20
104	   Cheeseburger	  $1.30
105	     Soda	      $1.00

Write an algorithm that:
Reads the product code and quantity;
Calculates the total amount to be paid by the customer;
Prints the total amount to be paid;
Prints the product name.

Faça um algoritmo que:
Leia o código do produto e a quantidade;
Calcule o valor a ser pago pelo cliente;
Imprima o valor a ser pago;
Imprima o nome do produto.

*/

import java.util.Scanner;

public class Exercicio32 {
    public static void main(String[] args){
        int cod, quantity;
        Scanner userInput = new Scanner(System.in);
        System.out.println("Code\tProduct\t\tPrice");
        System.out.println("100\tHot Dog\t\t$1,20");
        System.out.println("101\tSimple Bauru\t$1,30");
        System.out.println("102\tBauru with Egg\t$1,50");
        System.out.println("103\tHamburger\t$1.20");
        System.out.println("104\tCheeseburger\t$1,30");
        System.out.println("105\tSoda\t\t$1,00");
        System.out.println("Which product you will choose ?");
        System.out.println("Insert code:");
        cod = userInput.nextInt();
        System.out.println("How many ?");
        quantity = userInput.nextInt();

        switch (cod) {
            case 100:
                System.out.printf("Your bill will be $%.2f", quantity * 1.20);
                break;

            case 101:
                System.out.printf("Your bill will be $%.2f", quantity * 1.30);
                break;

            case 102:
                System.out.printf("Your bill will be $%.2f", quantity * 1.50);
                break;

            case 103:
                System.out.printf("Your bill will be $%.2f", quantity * 1.20);
                break;

            case 104:
                System.out.printf("Your bill will be $%.2f", quantity * 1.30);
                break;
                
            case 105:
                System.out.printf("Your bill will be $%.2f", quantity * 1.00);
                break;    
        
            default:
                System.out.println("Insert the wrong code or quantity");
                break;
        }
        
        userInput.close();


    }
    
}
