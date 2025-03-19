/*
Build a algorithm that read any integer given as a second / Construa um algoritmo que lê uma quantidade qualquer de segundos 
and convert this values to hour, minutes and  seconds / e converta esse valor em horas, minutos e segundos.
➢ Exemple:
■ input: 12345
■ output: 3 horas 25 minutos e 45 segundos
 */



import java.util.Scanner;

public class Exercicio5 {
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        int hour, minutes, seconds;
        System.out.println("Write any seconds so we can se the hours/min and seconds");
        seconds = userInput.nextInt();
        
        hour = seconds / 3600;
        minutes = ((seconds % 3600) / 60);
        seconds = seconds % 60;

        System.out.println("It's " + hour + " hour and " + minutes + " minutes" + " and " + seconds +" seconds ");




        userInput.close();
        
    }
}
