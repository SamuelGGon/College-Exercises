/*

Write an algorithm that reads 10 integers and says:
How many are even;
And how many are odd.

Faça um algoritmo que leia 10 números inteiros e diga:
quantos são pares;
e quantos são ímpares.

*/



import java.util.Scanner;

public class Exercicio34 {
    public static void main(String[] args){
        double even, odd, count, verif;

        Scanner userInput = new Scanner(System.in);

        count = 0;
        even = 0;
        odd = 0;

        while (count < 10) {
            count += 1;
            System.out.println("Insert a number: ");
            verif = userInput.nextDouble();

            if(verif % 2 == 0){
                even += 1;

            }else{
                odd += 1;
            }            
        }

        System.out.printf("There was inputed %.2f even number\n", even);
        System.out.printf("There was inputed %.2f odd number", odd);


        userInput.close();
    }
    
}
