/*

Given the menu of a snack bar:

Code	Product	Price
100	Hot Dog	1.20
101	Plain Bauru	1.30
102	Bauru with Egg	1.50
103	Hamburger	1.20
104	Cheeseburger	1.30
105	Soda	1.00

Create an algorithm that reads the product code and the quantity the customer wants to purchase.
The customer can buy more than one product; ask if they wish to continue shopping.
Calculate the total amount to be paid for each product and the total value of the purchase.



*/

import java.util.Scanner;

public class Exercicio40 {
    public static void main(String[]args ){
        int  code, quantity;
        double totalPrice;
        String exit1;
        char exit;
        Scanner userInput = new Scanner(System.in);

        System.out.println("Code\tProduct\t\tPrice");
        System.out.println("100\tHot Dog\t\t1.20");
        System.out.println("101\tPlain Bauru\t1.30");
        System.out.println("102\tBauru with egg\t1.50");
        System.out.println("103\tHamburger\t1.20");
        System.out.println("104\tCheeseburger\t1.30");
        System.out.println("105\tSoda\t\t1.00");

        exit = 'Y';
        code = 0;
        totalPrice = 0;


        while (exit != 'N') {

            do{
                System.out.println("What you like to order ? [Insert code]: ");
                code = userInput.nextInt();

            }while(code < 100 || code > 105);
            
            System.out.println("How many would like to buy ? ");
            quantity = userInput.nextInt();

            switch (code) {
                case 100:
                    totalPrice += (quantity * 1.20);

                    break;
                case 101:
                    totalPrice += (quantity * 1.30);

                    break;   
                case 102:
                    totalPrice += (quantity * 1.50);

                    break;
                case 103:
                    totalPrice += (quantity * 1.20);

                    break;
                case 104:
                    totalPrice += (quantity * 1.30);
                    break;

                default:
                    totalPrice += (quantity * 1);

                    break;
            } 
                     
            System.out.println("Anything else ? [y / n]");
            userInput.nextLine();
            exit1 = userInput.nextLine();
            exit1 = exit1.toUpperCase();
            exit = exit1.charAt(0);
                                 
        }

        System.out.printf("Your total bill is $%.2f", totalPrice);
        userInput.close();
    }
    
}
