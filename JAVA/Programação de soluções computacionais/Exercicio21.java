/*

Create an algorithm that verifies the validity of a password provided by the user.
Knowing that the correct password is R10p5:
Print the message "Access granted" or "Access denied"

Crie um algoritmo que verifique a validade de uma senha fornecida pelo usuário.
Sabendo que a senha correta é R10p5:
Exiba a mensagem "Acesso concedido" ou "Acesso negado".


*/

import java.util.Scanner;

public class Exercicio21{
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        String password, password2;
        password = "R10p5";

        System.out.println("Please insert the password");
        password2 = userInput.nextLine();

        if(password.equals(password2)){
            System.out.println("Access granted");

        }
        else{
            System.out.println("Access denied");
        }

        userInput.close();
    }

}


