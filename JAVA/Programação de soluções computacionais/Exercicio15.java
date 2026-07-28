/*
Guess the number game. The number to be guessed is 15, given a number provided by the user, check, got it right;
if the guess is above the number 15 or if it is below 15

Jogo da adivinhação. O numero para adivinhar é 15, o usuário vai escrever um numero, caso for maior, vai imprimir
é maior que  15, caso menor vai imprimir é menor que 15, até ser acertado.

*/


import java.util.Scanner;


public class Exercicio15 {
    public static void main(String[] args){

        Scanner userInput = new Scanner(System.in);
        int number = 15;
        int num1;
        System.out.println("Try to guess the number: ");

        num1 = userInput.nextInt();

        if(num1 == number){
            System.out.println("You win!! You Guessed ");


        }
        else if(num1 > number){
            System.out.println("The number you choose is bigger I'm thinking");
             
             
        }
        else if(num1 < number){
            System.out.println("The number you choose is lower then I'm thinking");

        }
        userInput.close();

        
    }
}
