/*

Create an algorithm that reads an integer between 1 and 12.  
Print the months in full.

Faça um algoritmo que leia um inteiro entre 1 a 12
imprima os meses por extenso

*/

import java.util.Scanner;

public class Exercicio28 {
    public static void main(String[] args){

        Scanner userInput = new Scanner(System.in);
        int num1;

        System.out.println("Please write a number within the interval [1 .. 12]");
        num1 = userInput.nextInt();
        switch (num1) {
            case 1:
                System.out.println("January");
                break;
            case 2:
                System.out.println("February");
                break;
            case 3:
                System.out.println("March");
                break;
            case 4:
                System.out.println("April");
                break;
            case 5:
                System.out.println("May");
                break;
            case 6:
                System.out.println("June");
                break;
            case 7:
                System.out.println("July");
                break;
            case 8:
                System.out.println("August");
                break;
            case 9:
                System.out.println("September");
                break;
            case 10:
                System.out.println("October");
                break;
            case 11:
                System.out.println("November");
                break;
            case 12:
                System.out.println("Dezember");
                break;
        
            default:
                System.out.println("You insert the wrong interval");
                break;
        }





        userInput.close();

    }
    
}
