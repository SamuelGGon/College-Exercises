/*

Create an algorithm that reads ten positive integers and displays the smallest among them.

Faça um algoritmo que leia dez números inteiros positivos e mostre o menor entre eles.

*/

import java.util.Scanner;

public class Exercicio38 {
    public static void main(String[] args){
        int big, smallest, num, count;
        Scanner userInput = new Scanner(System.in);
        big = smallest = count = 0;

        while (count <= 10) {
            System.out.println("Write a number ");
            num = userInput.nextInt();

            if(count == 0){
                big = smallest = num;

            }else{
                if (num > smallest) {
                    big = num;
                    
                }else{
                    smallest = num;
                }
            }
            count ++;
            
        }
        System.out.println("The Smallest number input " + smallest);
        
        userInput.close();

    }
}
