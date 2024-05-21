namespace Exercises
{
    public class Exercise7: BaseExercise
    {
        public void Run()
        {
            GetConcept();   
        }

        public void GetConcept(){
            int finalGrade;

            Console.WriteLine("Digite a nota final:");
            finalGrade = GetInput();
        
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