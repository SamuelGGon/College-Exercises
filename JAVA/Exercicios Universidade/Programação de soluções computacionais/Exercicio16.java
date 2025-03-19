/* 
Read two intergers number, if is equal number print "Equal", if not, show the bigger and the smaller.

Leia dois numeros inteiros, se é igual mostre "Igual", se não, mostre o maior e o menor.


*/

import java.util.Scanner;

public class Exercicio16 {
    public static void main (String[] args){

        Scanner userInput = new Scanner(System.in);

        double num1, num2, bigger, smaller;

        System.out.println("White any number please: ");
        num1 = userInput.nextInt();
        System.out.println("White another number please: ");
        num2 = userInput.nextInt();

        if(num1 == num2){
            System.out.println("The number " + num1 + " and " + num2 + " are equal.");
        }
        else if(num1 > num2){
            bigger = num1;
            smaller = num2;
            System.out.println("The number " + bigger + " is bigger then " + smaller );
            
            
        }
        else if(num1 < num2){
            smaller = num1;
            bigger = num2;
            System.out.println("The number " + bigger + " is bigger then " + smaller );
        }



        userInput.close();


    }
    
}
