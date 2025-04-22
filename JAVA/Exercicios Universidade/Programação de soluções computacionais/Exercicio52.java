/*
Read two arrays: A (of size 4) and B (of size 7).
Build a third array that is the combination of A and B,
placing the elements of A first, and then the elements of B in sequence.

Leia dois vetores: A (de tamanho 4) e B (de tamanho 7).
Construa um terceiro vetor que seja a junção de A e B
colocar os elementos de A, e em sequência, colocar os elementos de B.
*/

import java.util.Arrays;
import java.util.Scanner;

public class Exercicio52 {
    public static void main(String[]args ){
        int array[] = new int[4];
        int arrayB[] = new int[7];
        int arrayC[] = new int[array.length + arrayB.length];
        Scanner userInput = new Scanner(System.in);
        int control = 4;
        int i = 4;

        for(int exit  = 0; exit < 4; exit += 1){
            System.out.printf("Insert %d numbers \n", control);
            array[exit] = userInput.nextInt();
            control -= 1;
        }
        control = 7;

        for(int exit = 0; exit < 7; exit += 1){
            System.out.printf("Insert %d numbers \n", control);
            arrayB[exit] = userInput.nextInt();
            control -= 1;
        }

        for(int exit = 0; exit < 4; exit += 1){
            arrayC[exit] = array[exit];
        }

        for(int exit = 0; exit < 7; exit += 1){
            arrayC[i] = arrayB[exit];
            i += 1;
        }

        for(int exit = 0; exit < arrayC.length - 1; exit +=1){
            for(int exit1 = 0; exit1 < arrayC.length - 1; exit1 += 1){
                if(arrayC[exit1] > arrayC[exit1 + 1]){
                    int c = arrayC[exit1];
                    arrayC[exit1] = arrayC[exit1 + 1];
                    arrayC[exit1 + 1] = c;

                }
            }
        }
        
        System.out.println(Arrays.toString(arrayC));

        userInput.close();
    }

    
}
