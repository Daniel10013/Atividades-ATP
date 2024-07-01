using System;

namespace Exercises
{
    public class Exercise1: BaseExercise
    {
        public void Run()
        {
            string userInput;
            int quantityOfWhiteSpaces = 0;
            
            Console.WriteLine("Digite uma frase: ");
            userInput = Console.ReadLine();
            foreach (char character in userInput)
            {
                if (character == ' ')
                {
                    quantityOfWhiteSpaces++;
                }
            }

            Console.WriteLine("O numero de espacos em branco eh de: " + quantityOfWhiteSpaces);
        }
    }
}