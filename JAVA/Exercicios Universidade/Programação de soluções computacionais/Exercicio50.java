/*

Read 5 elements into an integer array A.
Construct another array B, with the same size as A,
such that each of its elements is the result of multiplying the elements of A by 3.
Display the elements of B.

Leia 5 elementos em um vetor inteiro A.
construa um outro vetor B, de mesma dimensão de A,
sendo que, seus elementos são a multiplicação dos elementos de A por 3.
mostre os elementos de B.


*/

import java.util.Scanner;

public class Exercicio50 {
    public static void main(String[]args ){
        int array[] = new int[5];
        int arrayB[] = new int[5];
        int control = 5;
        Scanner userInput = new Scanner(System.in);

        for(int exit = 0; exit < 5; exit += 1){
            System.out.printf("Please insert %d numbers \n", control);
            array[exit] = userInput.nextInt();
            control -= 1;

        }

        for(int exit = 0; exit < 5; exit += 1){

            arrayB[exit] = array[exit] * 3;
            System.out.printf("The mutiplication of %d by 3 is %d \n", array[exit], arrayB[exit] );
        }
        userInput.close();

    }
}
