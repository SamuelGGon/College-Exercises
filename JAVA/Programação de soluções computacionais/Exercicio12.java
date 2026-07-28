/* 
Write a program that reads the four values corresponding to two points on the x and y axes in the plane, p1(x1,y1) and p2(x2,y2)
and calculates the distance between them according to the formula: Distance SQRT((x2-x1)²+(y2-y1)²)

Escreva um programa que leia os quatro valores correspondentes a dois pontos nos eixos x e y no plano, p1(x1, y1) e p2(x2, y2),
e calcule a distância entre eles usando a fórmula: Distancia SQRT((x2-x1)²+(y2-y1)²)

*/

import java.util.Scanner;

public class Exercicio12 {
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        double x1, x2, y1, y2, lineLenght;

        System.out.println("Write down the value of x1: ");
        x1 = userInput.nextDouble();
        System.out.println("Write down the value of x2: ");
        x2 = userInput.nextDouble();
        System.out.println("Write down the value of y1: ");
        y1 = userInput.nextDouble();
        System.out.println("Write down the value of y2: ");
        y2 = userInput.nextDouble();

        lineLenght = Math.sqrt((Math.pow((x2-x1),2)) + (Math.pow((y2-y1), 2)));

        System.out.println("The line lenght is " + lineLenght);

        userInput.close();



    }
}
