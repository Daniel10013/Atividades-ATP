namespace Atividades
{
    public class Atividade4: BaseExercise
    {
        public void Run()
        {
            int value1, value2, value3;
   
            Console.WriteLine("Digite o primeiro valor:");
            value1 = GetInput();
                
            Console.WriteLine("Digite o segundo valor:");
            value2 = GetInput();
                
            Console.WriteLine("Digite o terceiro valor:");
            value3 = GetInput();
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