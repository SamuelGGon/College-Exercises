/*

Read an integer number and print on the screen the sequence of numbers from 1 up to the number read.

Ler um número inteiro e imprimir na tela a sequência de números que vai do número 1 até o número lido.

*/

import java.util.Scanner;

public class Exercicio43 {
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        int num, counter;

        System.out.println("Please insert a number.");
        num = userInput.nextInt();
        counter = 1;

        for(; counter <= num; counter += 1){
            System.out.printf("The sequence of choose number is %d\n", counter);

        }

        userInput.close();
    }
    
}
