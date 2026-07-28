/*

Create an algorithm that receives two grades from 6 students, calculates, and displays:  
a) The arithmetic mean of the two grades for each student.  
b) Display the following message according to the average:  
   - **"FAILED"** if the average is less than or equal to 3.  
   - **"EXAM"** if the average is above 3 and less than 7.  
   - **"APPROVED"** if the average is 7 or higher.  
c) The total number of approved students.  
d) The total number of students in the exam.  
e) The total number of failed students.  
f) The class average.

Faça um algoritmo que receba duas notas de 6 alunos, calcule e mostre:
a) A média aritmética das duas notas de cada aluno;
b) Forneça a seguinte mensagem de acordo com a nota:
¨ REPROVADO se média é menor ou igual a 3.
¨ EXAME se média é acima de 3 e menor que 7. 3 < x < 7
¨ APROVADO maior ou igual a 7
c) O total de alunos aprovados.
d) O total de alunos de exame.
e) O total de alunos reprovados.
f) A média da classe.


*/

import java.util.Scanner;

public class Exercicio45 {
    public static void main(String[] args) {
        double average, averageClass, grade, grade2;
        int totalApro, totalExam, totalFail, exit;

        Scanner userInput = new Scanner(System.in);

        average = exit = totalApro = totalExam = totalFail = 0;
        averageClass = 0;

        for(; exit <= 5; exit += 1){
            System.out.println("Insert your first grade: ");
            grade = userInput.nextDouble();

            System.out.println("Insert your second grade: ");
            grade2 = userInput.nextDouble();

            average = (grade + grade2) / 2;
            averageClass += average;

            if(average <= 3){
                System.out.println("Failed");
                totalFail += 1;


            }else if (average > 3 && average < 7) {
                System.out.println("To do Exam again");
                totalExam += 1;

                
            }else if (average >= 7) {
                System.out.println("Approved");
                totalApro += 1;
                
            }



        }
        System.out.println("Total of studants that fail: " + totalFail);
        System.out.println("Total of studants that was approved: " + totalApro);
        System.out.println("Total of studants that need to do exam: " + totalExam);
        System.out.printf("The class room average is %.2f", averageClass /= 6);


    }
    
}
