/*
Write a program that reads two grades from a student, calculates and displays the student's average grade.

Escreva um programa que lê duas notas de um estudante, calcule e mostre a média desse estudante.

*/

import java.util.Scanner;

public class Exercicio11 {

    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);

        double note, note2, average;

        System.out.println("Write your first grade: ");
        note = userInput.nextDouble();
        System.out.println("Write your second grade: ");
        note2 = userInput.nextDouble();

        average = (note + note2) / 2;

        System.out.println("Your grade's average is " + average);

        userInput.close();
        


    }
}