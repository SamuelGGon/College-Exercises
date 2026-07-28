/*
Make a program that read two integers values from the user keyboard input and print de follow results
adding
subtration
interger division
fraction division
remainder division
 */

import java.util.Scanner;

public class Exercicio04 {
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        int num1, num2;
        double dnum1, dnum2;   

        System.out.println("Type the first integer number:");
        num1 = userInput.nextInt();
        System.out.println("Type the second integer number:");
        num2 = userInput.nextInt();


        System.out.println("the sum of " + num1 + " + " + num2 + " = " + (num1 + num2));
        System.out.println("the subtration of " + num1 + " - " + num2 + " = " + (num1 - num2));
        System.out.println("the interger division of " + num1 + " : " + num2 + " = " + (num1 / num2));
        dnum1 = num1;
        dnum2 = num2;

        System.out.println("the dividsion of " + dnum1 + " + " + dnum2 + " = " + (dnum1 / dnum2));
        System.out.println("the remaider of  " + num1 + " + " + num2 + " = " + (num1 % num2));



        userInput.close();

    }
    
}
