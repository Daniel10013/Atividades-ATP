namespace Exercises
{
    public class Exercise6: BaseExercise
    {
        public void Run()
        {   
            int value;
            bool isToContinue = true;
            string message;

            while(isToContinue != false){

                Console.WriteLine("Digite um número:");
                value = GetInput();

                message = NumberIsPositive(value) == true ? "é positivo" : "é negativo";
                Console.WriteLine("O número " + message);

                Console.WriteLine("Deseja continuar? S | N");
                isToContinue = Console.ReadLine().ToLower() == "s" ? true : false;            
            }
        }

        public bool NumberIsPositive(int value){
            return value > 0;
        }

        public static int GetInput()
        {
            bool inputIsValid;
            int input;

            inputIsValid = int.TryParse(Console.ReadLine(), out input);

            while (inputIsValid == false)
            {
                Console.WriteLine("Número inválido digitado, digite novamente: ");
                inputIsValid = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }
    }
}