using System;

namespace Exercises
{
    public class Exercise2: BaseExercise
    {
        public void Run()
        {
            Console.WriteLine("Digite uma frase: ");
            string userInput = Console.ReadLine();
            string updatedPhrase = GetPhraseWihoutVowels(userInput);
            Console.WriteLine(updatedPhrase);
        }

        static string GetPhraseWihoutVowels(string phrase){
            string result = "";
            string vowels = "aeiouAEIOU";

            foreach(char character in phrase){
                if(!vowels.Contains(character)){
                    result += character;
                }
            }

            return result;
        }
    }
}