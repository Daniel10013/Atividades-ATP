using System;

namespace Exercises
{
    public class Exercise1: BaseExercise
    {
        public void Run()
        {
            double grade1, grade2, grade3;
            char selectedMedia;

            grade1 = GetInput("Digite o valor da primeira nota: ");
            grade2 = GetInput("Digite o valor da segunda nota: ");
            grade3 = GetInput("Digite o valor da terceira nota: ");

            Console.WriteLine("Selecione o tipo de media: A - Aritmetica | P - Ponderada");
            selectedMedia = char.Parse(Console.ReadLine());

            if(selectedMedia != 'A' && selectedMedia != 'P'){
                Console.WriteLine("Selecione uma opção de média válida!");
                return;
            }

            StudentGradeMedia(grade1, grade2, grade3, selectedMedia);
        }

        public static void StudentGradeMedia(double grade1, double grade2, double grade3, char mediaType){
            double sumOfGrades = grade1 + grade2 + grade3;
            double media;
            if(mediaType == 'A'){
                media = getAritmeticMedia(sumOfGrades);
                Console.WriteLine("A media aritmetica das notas e: {0:f2}", media);
            }

            if(mediaType == 'P'){
                media = getPounderedMedia(grade1, grade2, grade3);
                Console.WriteLine("A media ponderada das notas e: {0:f2}", media);
            }
        }

        public static double getAritmeticMedia(double sumOfGrades){
            return sumOfGrades / 3;
        }

        public static double getPounderedMedia(double grade1, double grade2, double grade3){
            double value1 = grade1 * 5;
            double value2 = grade2 * 3;
            double value3 = grade3 * 2;
            double sumOfWeights = 5 + 3 + 2;
            double pounderedMedia = (value1 + value2 + value3) / sumOfWeights;
            return pounderedMedia;
        }

        public static double GetInput(string message)
        {
            bool inputIsValid;
            double input;

            Console.WriteLine(message);
            inputIsValid = double.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false || input < 0)
            {
                Console.WriteLine("Número inválido digitado, digite novamente: ");
                inputIsValid = double.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}