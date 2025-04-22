/*

Read two arrays A and B of the same size. 
Construct array C, also of the same size,  
where each element of C is the result of subtracting the elements of B from A.  
Display C.

Leia dois vetores A e B de mesmo tamanho.
construa o vetor C, de mesmo tamanho,
cujo elementos de C são a subtração dos elementos de A por B.
mostre C.

*/

import java.util.Scanner;

public class Exercicio51 {
    public static void main(String[]args ){

        int array[] = new int[5];
        int arrayB[] = new int[5];
        int arrayC[] = new int[5];
        int control = 5;
        Scanner userInput = new Scanner(System.in);

        for(int exit = 0; exit < 5; exit += 1){

            System.out.printf("Please insert %d numbers \n", control);
            array[exit] = userInput.nextInt();
            control -= 1;           

        }

        control = 5;

        for(int exit = 0; exit < 5; exit += 1){

            System.out.printf("Please insert other %d numbers \n", control);
            arrayB[exit] = userInput.nextInt();
            control -= 1;

        }

        for(int exit = 0; exit < 5; exit += 1){

            arrayC[exit] = array[exit] - arrayB[exit];
            System.out.printf("%d - %d = %d \n", array[exit], arrayB[exit], arrayC[exit]);

        }


        userInput.close();

    }
    
}
