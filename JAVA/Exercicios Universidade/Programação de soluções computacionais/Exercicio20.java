/*

The company XSoftware granted a bonus of 20% of the salary value to all employees with a tenure at the company equal to or greater than five years, 
and a 10% bonus to the remaining employees.
Create an algorithm that reads the salary and the number of years of each employee, calculates, and prints the bonus value.

A empresa XSoftware concedeu um bônus de 20% do valor do salário para todos os funcionários com tempo de serviço na empresa igual ou superior a cinco anos,
e um bônus de 10% para os demais funcionários.
Crie um algoritmo que leia o salário e o número de anos de cada funcionário, calcule e imprima o valor do bônus.


*/

import java.util.Scanner;

public class Exercicio20 {
    public static void main(String[] args){
        double salary, years;
        Scanner userInput = new Scanner(System.in);

        System.out.println("How long are you employed is this company ?");
        years = userInput.nextDouble();
        System.out.println("What is your wage ?");
        salary = userInput.nextDouble();


        if(years >= 5){
            salary *= 1.20;

            System.out.printf("You receive a bonus of 20%%, you new wage is %.2f%n", salary);
            
            
        }
        else{
            salary *=1.10;
            System.out.printf("You receive a bonus of 10%%, you new wage is %.2f%n", salary);
            

            
        }

        userInput.close();

    }
    
}