/*

Create an algorithm that receives two numbers;

Executes the operations listed below...

According to the user's choice.

Option	Message
A	    Average of the entered numbers
S	    Difference between the larger and the smaller number
P	    Product of the entered numbers
D	    Division of the first number by the second

Faça um algoritmo que receba dois números;

Execute as operações listadas abaixo...

De acordo com a escolha do usuário.


*/

import java.util.Scanner;

public class Exercicio31 {
    public static void main(String[] args){
        double num1, num2, result;
        String letter;
        char letter1;
        Scanner userInput = new Scanner(System.in);

        System.out.println("Please insert a number: ");
        num1 = userInput.nextDouble();
        System.out.println("Please insert another number");
        num2 = userInput.nextDouble();

        System.out.println("Choose an option");
        System.out.printf("A  Average of %.2f and %.2f \n", num1, num2);
        System.out.printf("S  Difference between %.2f and %.2f \n", num1, num2);
        System.out.printf("P  Product of %.2f and %.2f \n", num1, num2);
        System.out.printf("D  Division %.2f / %.2f \n", num1, num2);
        userInput.nextLine();
        letter = userInput.nextLine();
        letter1 = letter.toUpperCase().charAt(0);
        

        switch (letter1) {
            case 'A':
                result = (num1 + num2) / 2;
                System.out.printf("The average is %.2f", result);
                break;

            case 'S':
                result = num1 - num2;
                System.out.printf("The average is %.2f", result);
                break;

            case 'P':
                result = num1 * num2;
                System.out.printf("The product is %.2f", result);
                break;
            
            case 'D':
                result = num1 / num2;
                System.out.printf("The division is %.2f", result);
                break;
                
        
            default:
                System.out.println("Invalid input");
                break;
        }
        

        userInput.close();





    }
    
}
