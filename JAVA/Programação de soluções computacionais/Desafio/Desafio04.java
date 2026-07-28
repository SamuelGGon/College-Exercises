import java.util.Arrays;
import java.util.Scanner;

public class Desafio04 {

    public static void main(String [] args){
        char array[][] = new char[3][3];
        int row, column;
        boolean rowColumFill = false;
        Scanner userInput = new Scanner(System.in);

        System.out.println("Please insert row and column");
        System.out.println("Row");
        row = userInput.nextInt();
        System.out.println("Column");
        column = userInput.nextInt();


        //olha o teste.java, ele vai te dar a resposta de ver elementos vazios ou não :)


      
        
        for(int exit = 0; exit <= array.length; exit += 1){

            System.out.println(Arrays.toString(array[exit]));
        }

    }
    
}
