/*

Read 5 people's names and store them in an array.
(a) Print the names from last to first.
(b) Print the first and the last stored names.

Leia 5 nomes de pessoas e armazene-os em um vetor.
(a) imprima os nomes do último para o primeiro.
(b) imprima o primeiro e o último nome armazenado

*/

import java.util.Scanner;

public class Exercicio49 {
    public static void main(String [] args ){
        String array[] = new String[5];
        Scanner userInput = new Scanner(System.in);
        int control = 5;

        for(int exit = 0; exit < 5; exit += 1){
            System.out.printf("Please write %d names \n", control);
            array[exit] = userInput.nextLine();
            control -= 1;

        }

        for(int exit = 4; exit > -1; exit -=1){
            System.out.printf("Names %s, ",array[exit]);
        }

        System.out.printf("First name is %s \n", array[0]);
        System.out.printf("Last name is %s \n", array[4]);

        userInput.close();
    }    
}
