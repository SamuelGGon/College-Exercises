/*

Read a person's salary and calculate and print  from the INSS ewSalary (calculated!!) according to  table below:

Salary Range            from the INSS iscount
≤ R$ 600.00	                   Exempt
> R$ 600.00 and ≤ R$ 1200.00	20%
> R$ 1200.00 and ≤ R$ 2000.00	25%
> R$ 2000.00	                30%

Ler o salário de uma pessoa e calcular e imprimir o desconto do from the INSS calculado!!) de acordo com a tabela a seguir

*/


import java.util.Scanner;
public class Exercicio25 {
    public static void main(String[] args){
        double salary, newSalary, discount1;

        Scanner userInput = new Scanner(System.in);

        System.out.println("Please inform your wage: ");
        salary = userInput.nextDouble();

        if(salary <= 600.00){

            System.out.println("Your don't have to pay anything");            

        }
        else if(salary > 600.00 && salary <= 1200.00){
            newSalary = salary * 0.80;
            discount1 = salary - newSalary;
            
            System.out.printf("Discounting from your salary, the INSS charges %.2f - %.2f = %.2f ", salary, newSalary, discount1);
        }
        else if(salary > 1200.00 && salary <= 2000.00) {
            newSalary = salary * 0.75;
            discount1 = salary - newSalary;            
            
            System.out.printf("Discounting from your salary, the INSS charges %.2f - %.2f = %.2f ", salary, newSalary, discount1);
        }
        else if(salary > 2000.00){
            newSalary = salary * 0.70;
            discount1 = salary - newSalary;            
            
            System.out.printf("Discounting from your salary, the INSS charges %.2f - %.2f = %.2f ", salary, newSalary, discount1);

        }


        userInput.close();


    }
    
}
