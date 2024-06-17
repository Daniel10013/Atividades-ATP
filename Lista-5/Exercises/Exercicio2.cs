using System;

namespace Exercises
{
    public class Exercise2: BaseExercise
    {
        public void Run()
        {
            int[] grades = new int[10];
            GetGrades(ref grades);
            ShowMedia(ref grades);
        }

        public static void ShowMedia(ref int[] grades){
            int media, gradesSum = 0, qntAboveMedia = 0;

            foreach (int grade in grades){   
                gradesSum += grade;
            }
            
            media = gradesSum / 10;
            
            foreach (int grade in grades){   
                if(grade > media){
                    qntAboveMedia++;
                }
            }

            Console.WriteLine("A media das notas e: " + media + ". A quantidade de notas acima da media e: " + qntAboveMedia);
        }

        public static void GetGrades(ref int[] grades){
            Console.WriteLine("Digite as 10 notas dos alunos: ");
            for(int i = 0; i < 10; i++){
                grades[i] = GetInput();
            }
        }

        public static int GetInput()
        {
            bool inputIsValid;
            int input;

            inputIsValid = int.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false || input > 10 || input < 0)
            {
                Console.WriteLine("Número inválido digitado, digite  novamente: ");
                inputIsValid = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}