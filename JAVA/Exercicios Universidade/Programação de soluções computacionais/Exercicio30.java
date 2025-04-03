/*

An employee will receive a raise according to their work plan.
Create an algorithm that reads:

The work plan;
Work Plan	Increase (%)
A	          10%
B	          15%
C	          20%

The employee's current salary;
Calculate and print their new salary.

Um funcionário receberá aumento de acordo com seu plano de trabalho.
Faça um algoritmo que leia:
¨ o plano de trabalho;
¨ e o salário atual de um funcionário;
Calcule e imprima o seu novo salário.


*/

import java.util.Scanner;

public class Exercicio30 {
    public static void main(String[] args){
        String plan;
        char plan1;
        double salary, newsalary;
        Scanner userInpunt = new Scanner(System.in);

        System.out.println("Which is your work plan ? [A, B or C]");
        plan =  userInpunt.nextLine();
        System.out.println("How much is your wage ? ");
        salary = userInpunt.nextInt();
        plan = plan.toUpperCase();
        plan1 = plan.charAt(0);


        switch(plan1) {
            case 'A':
                newsalary = salary * 1.10;
                System.out.printf("You are on plan A your salary with the bounus of 10%% is $%.2f", newsalary);
                break;
            case 'B':
                newsalary = salary * 1.15;
                System.out.printf("You are on plan B your salary with the bounus of 15%% is $%.2f", newsalary);
                break;
            case 'C':
                newsalary = salary * 1.20;
                System.out.printf("You are on plan C your salary with the bounus of 15%% is $%.2f", newsalary);
                break;
            default:
                System.out.println("Invalid input");
                break;
              
            

        }
        userInpunt.close();

    }
    
}
