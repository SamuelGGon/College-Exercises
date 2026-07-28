/*
**Read 10 integer values and store them in an array.**  
(a) Create a loop to print the even elements.  
(b) Create a loop to print the odd elements.

Leia 10 valores inteiros e armazene-os em um vetor.
(a) faça um laço para imprimir os elementos pares.
(b) faça um laço para imprimir os elementos ímpares.


*/

import java.util.Scanner;

public class Exercicio48 {
    public static void main (String []args ){
        Scanner userInput = new Scanner(System.in);
        int array[] = new int[10];
        int control = 10; 

        for(int exit = 0; array.length > exit; exit += 1){
            System.out.printf("Please insert a number. We need %d \n", control);
            array[exit] = userInput.nextInt();
            control -= 1;

        }

        System.out.println("Let print out the even numbers ");
        for(int exit = 0; exit < 10; exit += 1){
            if(array[exit] % 2 == 0){
                System.out.printf("%d; ", array[exit]);
            }
            
        }
        
        System.out.println("");
        
        System.out.println("Let print out the odd numbers ");
        for(int exit = 0; exit < 10; exit += 1){
            if(array[exit] % 2 != 0){
                System.out.printf("%d; ", array[exit]);
            }
        }

                      
        
        userInput.close();
    }
    
}
