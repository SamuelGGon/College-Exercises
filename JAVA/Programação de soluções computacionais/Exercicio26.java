
/*

Create a basic operations calculator:

addition, subtraction, multiplication, and division.
the algorithm must read two numbers and the symbol corresponding to the desired operation;
use the char type to read the operation;
at the end, the result must be printed.
Restrictions:
if the entered symbol does not correspond to an operation...
display the message Invalid Symbol and terminate.
for the division operation, check if the divisor is valid (greater than zero)!
if it is less than or equal to zero, display the message "Impossible to divide!!".


Crie uma calculadora de operações básicas:

Adição, subtração, multiplicação e divisão.
O algoritmo deve ler dois números e o símbolo correspondente à operação desejada.
Use o tipo char para ler a operação.
No final, o resultado deve ser impresso.
Restrições:
Se o símbolo inserido não corresponder a uma operação válida, exiba a mensagem "Símbolo inválido" e termine o programa.
Para a operação de divisão, verifique se o divisor é válido (maior que zero)!
Se for menor ou igual a zero, exiba a mensagem "Impossível dividir!!".

*/

import java.util.Scanner;

public class Exercicio26 {
    public static void main(String[] args){

        double num1, num2, result;
        char symbol;

        Scanner userInput = new Scanner(System.in);
        System.out.println("This is a simply calculator.");

        System.out.println("Please insert a number:");
        num1 = userInput.nextDouble();
        System.out.println("Insert a another one: ");
        num2 = userInput.nextDouble();
        System.out.println("Which operation you would like to do [ +, -, *, / ]: ");
        symbol = userInput.next().charAt(0);

        if(symbol != '+' && symbol != '-' && symbol != '*' && symbol != '/' ){
            System.out.println("your input a wrong operation symbol");
            System.out.println("Programing closing...");

        }else if(symbol == '+'){
            result = num1 + num2;
            System.out.println("The sum of " + num1 + " and " + num2);
            System.out.printf("is: %.2f", result);


        }else if(symbol == '-'){
            result = num1 - num2;
            System.out.println("The sum of " + num1 + " and " + num2 + " Is: ");
            System.out.printf("is: %.2f", result);

        }else if(symbol == '*'){
            result = num1 * num2;
            System.out.println("The sum of " + num1 + " and " + num2 + " Is: ");
            System.out.printf("is: %.2f", result);

        }else if(symbol == '/'){
            if(num2 == 0){
                System.out.println("We don't know how to divide to zero yet: ");

            }
            else{
                result = num1 / num2;
                System.out.println("The sum of " + num1 + " and " + num2 + " Is: ");
                System.out.printf("is: %.2f", result);
            }


        }







        userInput.close();


    }
    
}
