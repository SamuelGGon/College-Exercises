/*

In a presidential election, there are four candidates.  
Votes are recorded using a code:  
- **1, 2, 3, or 4** - Vote for the respective candidate  
- **5** - Null vote  
- **6** - Blank vote  
Create an algorithm that reads the votes of 10 voters.  
Calculate and display:  
- **a)** The total number of votes for each candidate  
- **b)** The total number of null votes  
- **c)** The total number of blank votes  
- **d\n)** The percentage of blank and null votes


Em uma eleição presidencial, existem quatro candidatos.
Os votos são informados através de um código:
¨ 1, 2, 3 ou 4 - Voto para o respectivo candidato
¨ 5 - Voto nulo
¨ 6 - Voto em branco
Faça um algoritmo que leia o voto de 10 eleitores.
Calcule e mostre:
¨ a) O total de votos para cada candidato;
¨ b) O total de votos nulos;
¨ c) O total de votos em branco;
¨ d\n) O percentual dos votos brancos e nulos.



*/

import java.util.Scanner;

public class Exercicio46 {
    public static void main(String []args ){
        System.out.println("Code\tCandidates");
        System.out.println("1\tMichael Corleone");
        System.out.println("2\tTony Montana");
        System.out.println("3\tScooby Doo");
        System.out.println("4\tRené Belloq");
        System.out.println("5\tNull");
        System.out.println("6\tBlank");

        int exit, totalNul, totalBlan, cand1, cand2, cand3, cand4, chose;
        double percentage;

        Scanner userInput = new Scanner(System.in);

        exit = totalBlan = totalNul = cand1 = cand2 = cand3 = cand4 = chose = 0;
        percentage = 0;

        for(; exit <= 9; exit += 1){
            do{
                System.out.println("Who would like to vote ? ");
                chose = userInput.nextInt();
                
        
            }while(chose < 1 || chose > 6);
            switch (chose) {
                case 1:
                    cand1 += 1;
                    break;

                case 2:
                    cand2 += 1;
                    break;
                
                case 3:
                    cand3 += 1;
                    break;

                case 4:
                    cand4 += 1;
                    break;

                case 5:
                    totalNul += 1;
                    break;
                                          
                default:
                    totalBlan += 1;
                    break;
            }

            
        }

        percentage = (((double)totalNul + (double)totalBlan) / 10) * 100;

        System.out.printf("Candidate 1, recive %d\n", cand1);
        System.out.printf("Candidate 2, recive %d\n", cand2);
        System.out.printf("Candidate 3, recive %d\n", cand3);
        System.out.printf("Candidate 4, recive %d\n", cand4);
        System.out.printf("Null, recive %d\n", totalNul);
        System.out.printf("Blank, recive %d\n", totalBlan);

        System.out.printf("The percentage of null and blanks is %.2f%%", percentage);
        

        userInput.close();
    }
    
}
