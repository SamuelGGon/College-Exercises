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
using System;

namespace Exercicio45
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageStudant, averageCla, grade1, grade2;
            int approved, exam, failed;
            approved = exam = failed = 0;
            averageCla = 0;

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Write your first grade, studant {i}");
                grade1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Write your second grade, studant {i}");
                grade2 = Convert.ToDouble(Console.ReadLine());

                averageStudant = (grade2 +  grade1) / 2;
                averageCla += averageStudant;

                Console.WriteLine($"Your average  is {averageStudant}");

                if (averageStudant <= 3)
                {
                    failed += 1;
                }
                else if (averageStudant > 3 && averageStudant < 7)
                {
                    exam++;
                }
                else
                {
                    approved++;
                }

            }

            Console.WriteLine($"The class average is {averageCla / 6}");
            Console.WriteLine($"Studants that faill {failed}");
            Console.WriteLine($"Studants that is exam {exam}");
            Console.WriteLine($"Approved {approved}");
        }
    }
}