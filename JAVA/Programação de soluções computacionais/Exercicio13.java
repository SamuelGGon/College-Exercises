/*

Make a algorithm that read interge input by the user and check if is even or odd.

Faça um algoritmo que lê um numero inteiro inserido pelo usuario e verifique se é par ou impar.

*/

import java.util.Scanner;

public class Exercicio13 {
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        int num1;
        System.err.println("Insert a number:");
        num1 = userInput.nextInt();

        if(num1 % 2 == 0){
            System.err.println("The number "  + num1 + " is Even");

        }
        else{
            System.err.println("The number "  + num1 + " is Odd");
            
        }
        
        
        userInput.close();
    }
    
}
