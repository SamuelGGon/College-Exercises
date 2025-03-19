/*

Read two float numbers and print then, from bigger to smaller. Supose isn't equal.

Leia dois numero flutuantes e mostre em modo descrescente.

*/



import java.util.Scanner;

public class Exercicio17 {
    public static void main(String[] args){

        Scanner userInput =  new Scanner(System.in);
        float num1, num2, bigger, smaller;

        System.out.println("Write a number: ");
        num1 = userInput.nextFloat();
        System.out.println("Write another number: ");
        num2 = userInput.nextFloat();

        if(num1 > num2){
            bigger = num1;
            smaller =  num2;

            System.out.println("The number you choose from the bigger to smaller " + "[" + bigger + ", " + smaller +"]");
            
        }
        else if(num2 > num1){
            bigger = num2;
            smaller = num1;

            System.out.println("The number you choose from the bigger to smaller " +"["+ bigger + ", " + smaller +"]");
        }



        userInput.close();

    }
}
