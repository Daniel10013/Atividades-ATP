using System.IO;

namespace Exercises
{
    public class Exercise6: BaseExercise
    {
        public void Run()
        {   
            int userInput = GetInput(), somaDivisores = 0;
            StreamWriter sw = new StreamWriter("./Files/divisores.txt");

            Console.WriteLine("Os divisores desse numero sao: ");
            for(int i = 1; i < userInput; i++){
                if(userInput % i == 0){
                    somaDivisores += i;
                    Console.WriteLine(i);
                }
            }

            sw.Write(somaDivisores);
            sw.Close();
        }

        public static int GetInput()
        {
            bool inputIsValid;
            int input;

            Console.WriteLine("Digite um número: ");
            inputIsValid = int.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false || input < 0)
            {
                Console.WriteLine("Número inválido digitado, digite  novamente: ");
                inputIsValid = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}