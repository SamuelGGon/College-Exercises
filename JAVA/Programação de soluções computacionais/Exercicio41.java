/*

Make a program that print the sequence
100, 99, 98 .... 1

Faça um programa que imprima a seguinte sequência:
– 100, 99, 98, . . . 1.

*/


public class Exercicio41 {
    public static void main(String[] args){
        int num;
        
        for(num = 100; num >= 1; num -= 1){

            System.out.printf("The counting down %d \n", num);

        }

    }
    
}
