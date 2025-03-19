/*
Make a program that read two student's grade and take weighted average, a note has weight of 4 and 6.

Faça um programa que leia duas notas de um estudante e tire a média ponderada, primeira nota vale 1 e a segunda 6
*/

import java.util.Scanner;

public class Exercicio10 {

    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        double note1, note2, average;

        System.out.println("Write your first grade:");
        note1 = userInput.nextInt();
        System.out.println("Write your second grade: ");
        note2 = userInput.nextInt();

        average = (((note1 * 4) + (note2 * 6)) /  (4 + 6));

        System.out.println("Your average is " + average);

        userInput.close();

    }

    
}
