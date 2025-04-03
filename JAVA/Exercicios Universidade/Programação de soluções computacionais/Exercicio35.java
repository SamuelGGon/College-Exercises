/*

Construct an algorithm that reads an integer and prints the sequence:  
- 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024...  
- while the sequence value is less than or equal to the read number.

Construir um algoritmo que leia um número inteiro e imprime a sequência:
– 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024. . .
– enquanto o valor da sequência for menor ou igual ao número lido.



*/

import java.util.Scanner;

public class Exercicio35 {
    public static void main(String[] args){
        int startNum, stopPoint, count;
        Scanner userInput = new Scanner(System.in);
        startNum = 1;
        count = 0;
        System.out.println("Please insert a number: ");
        stopPoint = userInput.nextInt();


        while(stopPoint > startNum){
            count += 1;
            startNum *= 2;
            System.out.printf("The sequence of powers of 2^%d is %d; ",count, startNum );


        }

        userInput.close();
    }
    
}
