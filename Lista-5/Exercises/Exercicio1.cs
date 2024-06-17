using System;

namespace Exercises
{
    public class Exercise1: BaseExercise
    {
        public void Run()
        {
            int[] numbers = new int[20];
            int highestNumber = 0, position = 0;

            Console.WriteLine("Digite 20 numeros:");
            for(int i = 0; i < 20; i++){
                numbers[i] = GetInput();
                if(numbers[i] > highestNumber){
                    highestNumber = numbers[i];
                    position = i + 1;
                }
            }

            Console.WriteLine("O numero mais alto e: " + highestNumber + " e sua posicao e: " + position);
        }

        public static int GetInput()
        {
            bool inputIsValid;
            int input;

            inputIsValid = int.TryParse(Console.ReadLine(), out input);
            while (inputIsValid == false)
            {
                Console.WriteLine("Número inválido digitado, digite  novamente:");
                inputIsValid = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }   
    }
}