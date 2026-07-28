import java.util.Scanner;

public class Dasafio02 {
    public static void main(String[] args){

        Scanner userInput = new Scanner(System.in);

        System.out.println("Enter a number:");
        int result;
        int usernumber = userInput.nextInt(); 

        for(int num = 0; num <= 10; num += 1){

            result = usernumber * num;

            System.out.printf("%d X %d = %d \n ", usernumber, num, result);
        }
    }
    
}
